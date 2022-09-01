namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategoryTagDisconnectedEventArgs : EventArgs
    {
        private readonly TagCategoryRecord tagCategoryDefinition;
        private readonly TagRecord tag;

        public CategoryTagDisconnectedEventArgs(TagCategoryRecord tagCategoryDefinition, TagRecord tag)
        {
            this.tagCategoryDefinition = tagCategoryDefinition;
            this.tag = tag;
        }

        public TagCategoryRecord Category { get { return tagCategoryDefinition; } }
        public TagRecord Tag { get { return tag; } }
    }
}