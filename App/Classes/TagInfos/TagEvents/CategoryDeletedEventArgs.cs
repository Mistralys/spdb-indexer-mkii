namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategoryDeletedEventArgs : EventArgs
    {
        private readonly long id;
        private readonly string name;

        public long ID
        {
            get => id;
        }

        public string Name
        {
            get => name;
        }

        public CategoryDeletedEventArgs(long id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
