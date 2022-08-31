using Newtonsoft.Json;

namespace SPDB_MKII.Classes.DatabaseInfos
{
    internal class DatabaseCollection
    {
        private const string RecordsSeparator = "__DELIM__";
        private static List<DatabaseDefinition>? databases = null;
        private static DatabaseDefinition? active = null;

        public static DatabaseDefinition ActiveDatabase
        {
            get
            {
                if(active != null)
                {
                    return active;
                }

                throw new Exception("No database is currently active.");
            }

            set
            {
                active = value;
            }
        }

        public static List<DatabaseDefinition> Databases 
        { 
            get 
            {
                if (databases == null) 
                { 
                    databases = new List<DatabaseDefinition>();

                    if (!string.IsNullOrWhiteSpace(Program.AppSettings.Databases))
                    {
                        LoadData(new DelimitedJSONParser(Program.AppSettings.Databases, RecordsSeparator), databases);
                    }
                    else
                    {
                        Program.Log.Debug("Databases | No stored database configurations found, skipping.");
                    }
                }

                return databases; 
            } 
        }

        private static void LoadData(DelimitedJSONParser parsed, List<DatabaseDefinition> collection)
        {
            Program.Log.Debug("Databases | Found [{0}] stored configurations, adding them.", parsed.Count);

            foreach (string definitionJSON in parsed.Items)
            {
                DatabaseDefinition? def = JsonConvert.DeserializeObject<DatabaseDefinition>(definitionJSON);

                if (def != null) 
                {
                    Program.Log.Debug("Databases | Detected database configuration [{0}@{1}].", def.DatabaseName, def.Host);

                    collection.Add(def);
                }
            }
        }

        public static DatabaseDefinition AddDefinition(string host, string user, string password, string database, int port)
        {
            DatabaseDefinition def = new(host, user, password, database, port);

            Program.Log.Debug("Databases | Added new database configuration [{0}@{1}].", def.DatabaseName, def.Host);

            Databases.Add(def);

            return def;
        }

        public static void Save()
        {
            Program.Log.Debug("Databases | Saving [{0}] database configurations.", Databases.Count);

            List<string> values = new();

            foreach(DatabaseDefinition database in Databases)
            {
                values.Add(JsonConvert.SerializeObject(database));
            }

            Program.AppSettings.Databases = string.Join(RecordsSeparator, values.ToArray());
            Program.AppSettings.Save(); 
        }

        internal static void DeleteDefinition(DatabaseDefinition def)
        {
            List<DatabaseDefinition> keep = new();

            foreach(DatabaseDefinition databaseDefinition in Databases)
            {
                if (databaseDefinition != def)
                {
                    keep.Add(databaseDefinition);
                }
                else
                {
                    Program.Log.Information("Databases | Deleted the database configuration [{0}@{1}].", def.DatabaseName, def.Host);
                }
            }

            databases = keep;
        }
    }
}
