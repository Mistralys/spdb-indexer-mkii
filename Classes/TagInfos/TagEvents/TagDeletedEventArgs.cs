namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class TagDeletedEventArgs : EventArgs
    {
        private readonly long id;
        private readonly string name;
        private readonly TagCategoryRecord? deletingCategory;

        public TagDeletedEventArgs(long id, string name, TagCategoryRecord? deletingCategory=null)
        {
            this.id = id;
            this.name = name;
            this.deletingCategory = deletingCategory;
        }

        public long ID { get { return id; } }
        public string Name { get { return name; } }
        
        /// <summary>
        /// Category being deleted, if this tag is being deleted to remove
        /// a category (all its tags are deleted before it).
        /// </summary>
        public TagCategoryRecord? DeletingCategory { get { return deletingCategory; } }
    }
}