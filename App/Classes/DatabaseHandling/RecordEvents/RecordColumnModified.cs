namespace SPDB_MKII.Classes.DatabaseHandling.RecordEvents
{
    internal class RecordColumnModifiedEventArgs : EventArgs
    {
        private readonly BaseRecord record;
        private readonly string column;
        private readonly string? oldValue;
        private readonly string? newValue;

        public RecordColumnModifiedEventArgs(BaseRecord record, string column, string? oldValue, string? newValue)
        {
            this.record = record;
            this.column = column;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public BaseRecord Record { get { return record; } }
        public string Column { get { return column; } }
        public string? OldValue { get { return oldValue; } }
        public string? NewValue { get { return newValue; } }
    }
}
