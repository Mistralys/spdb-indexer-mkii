using MySqlConnector;
using SPDB_MKII.Classes.DatabaseInfos;
using SPDB_MKII.Properties;
using System;
using System.Data.Common;

namespace SPDB_MKII.Classes.DatabaseHandling
{
    public class DBHelper
    {
        public const int DB_REVISION = 1;
        private static DBHelper? instance = null;
        private readonly MySqlConnection connection;

        public DBHelper()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = DatabaseCollection.ActiveDatabase.Host,
                UserID = DatabaseCollection.ActiveDatabase.UserName,
                Password = DatabaseCollection.ActiveDatabase.Password,
                Database = DatabaseCollection.ActiveDatabase.DatabaseName,
            };

            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
        }

        private long? activeRevision = null;

        public long ActiveRevision
        {
            get 
            { 
                activeRevision ??= FetchKeyInt(
                    "config_value", 
                    @"
                    SELECT
                        `config_value`
                    FROM
                        `spdb_config`
                    WHERE
                        `config_name` = 'db_revision'"
                );

                return (long)activeRevision;
            }
        }

        protected bool transactionStarted = false;

        public void StartTransaction()
        {
            if (transactionStarted)
            {
                return;
            }

            transactionStarted = true;

            Execute("START TRANSACTION");
        }

        public bool TransactionStarted
        {
            get { return transactionStarted; }
        }

        protected void Execute(string queryString, string source = "")
        {
            RegisterQuery(source, queryString);

            using (MySqlCommand cmd = new MySqlCommand(queryString, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void CommitTransaction()
        {
            if (!transactionStarted)
            {
                return;
            }

            Execute("COMMIT");

            transactionStarted = false;
        }

        public void RollbackTransaction()
        {
            if (!transactionStarted)
            {
                return;
            }

            Execute("ROLLBACK");

            transactionStarted = false;
        }

        public static DBHelper Instance
        {
            get
            {
                instance ??= new DBHelper();

                return instance;
            }
        }

        public void UpdateDynamic(string tableName, string primaryName, Dictionary<string, string?> data)
        {
            var setFields = new List<string>();

            if (!data.ContainsKey(primaryName))
            {
                throw new Exception(string.Format("Primary value for {0} not present in update data set", primaryName));
            }

            foreach (KeyValuePair<string, string?> kvp in data)
            {
                setFields.Add(string.Format("{0}=@{0}", kvp.Key));
            }

            var query = string.Format(
                @"UPDATE 
                    {0}
                SET
                    {1}
                WHERE
                    {2}=@{2}",
                tableName,
                String.Join(",", setFields.ToArray()),
                primaryName
            );

            Update(query, data);
        }

        public long Insert(string queryString, Dictionary<string, string?>? variables = null)
        {
            using (MySqlCommand cmd = new MySqlCommand(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("Insert", queryString, variables);

                cmd.ExecuteNonQuery();
                return cmd.LastInsertedId;
            }
        }

        /// <summary>
        /// Converts the datetime to a mysql compatible datetime string.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string GetDatetimeString(DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// Converts a mysql datetime string to a datetime object.
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetDateFromDatetimeString(string datetime)
        {
            return DateTime.Parse(datetime);
        }

        public static bool DebugQueriesEnabled
        {
            get => Program.DebugEnabled && Settings.Default.DebugQueries;
        }

        protected static void RegisterQuery(string source, string queryString, Dictionary<string, string?>? variables = null)
        {
            if (!DebugQueriesEnabled)
            {
                return;
            }

            if (variables != null)
            {
                foreach (KeyValuePair<string, string?> kvp in variables)
                {
                    var name = kvp.Key;
                    if (name.Substring(0, 1) != "@")
                    {
                        name = "@" + name;
                    }

                    var value = kvp.Value;
                    value ??= "NULL";

                    queryString = queryString.Replace(name, value);
                }
            }

            Program.Log.Debug("Query {0}", source);
            Program.Log.Debug("{0}", queryString);
        }

        public bool TableExists(string tableName)
        {
            return Tables.Contains(tableName);
        }

        public List<string> Tables
        {
            get
            {
                var result = new List<string>();
                var tables = FetchAll("SHOW TABLES");
                foreach (Dictionary<string, string?> kvp in tables)
                {
                    string? name = kvp[kvp.Keys.First()];

                    if (name != null)
                    {
                        result.Add(name);
                    }
                }

                return result;
            }
        }

        public void Update(string queryString, Dictionary<string, string?>? variables = null)
        {
            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("Update", queryString, variables);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string queryString, Dictionary<string, string?>? variables = null)
        {
            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("Delete", queryString, variables);

                cmd.ExecuteNonQuery();
            }
        }

        public Dictionary<string, string?> Fetch(string queryString, Dictionary<string, string?>? variables = null)
        {
            var result = new Dictionary<string, string?>();

            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("Fetch", queryString, variables);

                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    Reader.Read();

                    if (!Reader.HasRows)
                    {
                        return result;
                    }

                    for (var i = 0; i < Reader.FieldCount; i++)
                    {
                        result.Add(Reader.GetName(i), ConvertValue(Reader, i));
                    }
                }
            }

            return result;
        }

        private string? ConvertValue(MySqlDataReader Reader, int index)
        {
            string column = Reader.GetName(index);
            Type type = Reader.GetFieldType(column);
            string? value = null;

            if (Reader.IsDBNull(index))
            {
            }
            else if (type == typeof(uint) || type == typeof(int))
            {
                value = Reader.GetInt64(index).ToString();
            }
            else
            {
                value = Reader.GetString(index);
            }

            return value;
        }

        /// <summary>
        /// Fetches a single record from the query, and returns the value of a specific column.
        /// </summary>
        /// <param name="columnName">The name of the column for which to retrieve the value</param>
        /// <param name="queryString">The raw query string</param>
        /// <param name="variables">Any variables to bind, as column name > value pairs.</param>
        /// <returns></returns>
        public string? FetchKey(string columnName, string queryString, Dictionary<string, string?>? variables = null)
        {
            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("FetchKey", queryString, variables);

                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    Reader.Read();

                    if (Reader.HasRows)
                    {
                        for (var i = 0; i < Reader.FieldCount; i++)
                        {
                            if (Reader.GetName(i) == columnName)
                            {
                                return ConvertValue(Reader, i);
                            }
                        }
                    }
                }
            }

            return null;
        }

        public long FetchKeyInt(string columnName, string queryString, Dictionary<string, string?>? variables = null)
        {
            string? result = FetchKey(columnName, queryString, variables);

            if (result != null)
            {
                return Int64.Parse(result);
            }

            return 0;
        }

        /// <summary>
        /// Fetches all resulting rows from the query.
        /// </summary>
        /// <param name="queryString">The raw query string</param>
        /// <param name="variables">Any variables to bind, as column name > value pairs.</param>
        /// <returns></returns>
        public List<Dictionary<string, string?>> FetchAll(string queryString, Dictionary<string, string?>? variables = null)
        {
            var result = new List<Dictionary<string, string?>>();

            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("FetchAll", queryString, variables);

                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        var entry = new Dictionary<string, string?>();
                        for (var i = 0; i < Reader.FieldCount; i++)
                        {
                            entry.Add(Reader.GetName(i), ConvertValue(Reader, i));
                        }

                        result.Add(entry);
                    }
                }
            }

            return result;
        }

        public List<string?> FetchAllKey(string columnName, string queryString, Dictionary<string, string?>? variables = null)
        {
            var result = new List<string?>();

            using (MySqlCommand cmd = new(queryString, connection))
            {
                Prepare(cmd, variables);

                RegisterQuery("FetchAllKey", queryString, variables);

                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        for (var i = 0; i < Reader.FieldCount; i++)
                        {
                            var column = Reader.GetName(i);

                            if (column == columnName)
                            {
                                result.Add(ConvertValue(Reader, i));
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<long> FetchAllKeyInt(string columnName, string queryString, Dictionary<string, string?>? variables = null)
        {
            List<string?> values = FetchAllKey(columnName, queryString, variables);
            List<long> result = new();

            foreach(string? value in values)
            {
                if (value == null)
                {
                    result.Add(0);
                }
                else
                {
                    result.Add(Int64.Parse(value));
                }
            }

            return result;
        }

        protected static void Prepare(MySqlCommand cmd, Dictionary<string, string?>? variables = null)
        {
            if (variables == null)
            {
                return;
            }

            foreach (KeyValuePair<string, string?> kvp in variables)
            {
                var name = kvp.Key;
                if (name.Substring(0, 1) != "@")
                {
                    name = "@" + name;
                }

                if (kvp.Value == null)
                {
                    cmd.Parameters.AddWithValue(name, DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue(name, kvp.Value);
                }
            }
        }

        public void ExecuteUpdates()
        {
            long rev = ActiveRevision;

            if (rev == DB_REVISION)
            {
                Program.Log.Debug("DB revision [{0}] | Revision is OK, no updates needed.", DB_REVISION);
                return;
            }

            Program.Log.Debug("DB revision [{0}] | Current revision is older, updating...", DB_REVISION);

            var type = GetType();
            while (rev < DB_REVISION)
            {
                Program.Log.Debug("DB revision [{0}] | Revision [{1}] | Processing.", DB_REVISION, rev);

                var method = type.GetMethod("Update_REV_" + rev.ToString());
                if (method != null)
                {
                    Program.Log.Debug("DB revision [{0}] | Revision [{1}] | Found specific update routines.", DB_REVISION, rev);
                    method.Invoke(this, null);
                }

                rev++;
            }

            Program.Log.Debug("DB revision [{0}] | Updates done.", DB_REVISION);
        }

        public void Update_REV_00000()
        {
            Update(
                @"ALTER TABLE 
                    [...]"
            );
        }

        internal void RequireTransaction()
        {
            if (transactionStarted) { 
                return;
            }

            throw new DBTransactionException(
                "This operation requires a transaction."    
            );
        }
    }
}
