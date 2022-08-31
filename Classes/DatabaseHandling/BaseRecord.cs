using SPDB_MKII.Classes.DatabaseHandling.RecordEvents;

namespace SPDB_MKII.Classes.DatabaseHandling
{
    internal abstract class BaseRecord
    {
        protected long id;
        protected DBHelper db;
        protected Dictionary<string, string> data;
        protected List<string> modifiedColumns = new();

        public long ID { get => id; }

        public BaseRecord(long id)
        {
            this.id = id;
            db = DBHelper.Instance;

            data = db.Fetch(
                string.Format(
                    @"SELECT
                        *
                    FROM
                        `{0}`
                    WHERE
                       `{1}`=@id
                    ",
                    GetTableName(),
                    GetPrimaryName()
                ),
                new Dictionary<string, string>
                {
                    { "id", ID.ToString() }
                }
            );
        }

        protected abstract string GetTableName();
        protected abstract string GetPrimaryName();

        public string GetColumn(string column)
        {
            if(data.ContainsKey(column))
            {
                return data[column];
            }

            return "";
        }

        public long GetColumnInt(string column)
        {
            return Int64.Parse(GetColumn(column));  
        }

        public bool GetColumnBool(string column)
        {
            string value = GetColumn(column);

            return value == "yes" || value == "true";
        }

        public void SetColumn(string column, string value)
        {
            if (!data.ContainsKey(column))
            {
                return;
            }

            if (data[column] != value)
            {
                string oldValue = data[column];
                data[column] = value;
                modifiedColumns.Add(column);

                ColumnModified?.Invoke(this, new RecordColumnModifiedEventArgs(this, column, oldValue, value));
            }
        }

        public bool IsModified
        {
            get => modifiedColumns.Count > 0;
        }

        public void SaveWithTransaction()
        {
            db.StartTransaction();

            Save();

            db.CommitTransaction();
        }

        public void Save()
        {
            if (!IsModified) {
                return;
            }

            DBHelper.RequireTransaction();

            Dictionary<string, string> values = new();

            values[GetPrimaryName()] = ID.ToString();

            foreach(string column in modifiedColumns)
            {
                values[column] = GetColumn(column);
            }

            db.UpdateDynamic(
                GetTableName(),
                GetPrimaryName(),
                values
            );

            Saved?.Invoke(this, new RecordSavedEventArgs(this, modifiedColumns));

            modifiedColumns.Clear();
        }

        public event EventHandler? ColumnModified;
        public event EventHandler<RecordSavedEventArgs>? Saved;
    }
}
