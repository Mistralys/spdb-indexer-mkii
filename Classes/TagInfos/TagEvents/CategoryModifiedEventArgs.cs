namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategoryModifiedEventArgs : EventArgs
    {
        private readonly TagCategoryDefinition category;

        public CategoryModifiedEventArgs(TagCategoryDefinition category)
        {
            this.category = category;
        }

        public TagCategoryDefinition Category { get { return category; } }
    }
}
