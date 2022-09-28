namespace SPDB_MKII.Classes.DatabaseHandling.RecordEvents
{
    internal class RecordSavedEventArgs : EventArgs
    {
        private readonly List<string> modifiedColumns;
        private readonly BaseRecord record;

        public RecordSavedEventArgs(BaseRecord record, List<string> modifiedColumns)
        {

            this.modifiedColumns = modifiedColumns;
            this.record = record;
        }

        public List<string> ModifiedColumns { get => modifiedColumns; }
        public BaseRecord Record { get => record; }
    }
}
