namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategoryAddedEventArgs : EventArgs
    {
        private TagCategoryDefinition category;

        public TagCategoryDefinition Category { get => category; }

        public CategoryAddedEventArgs(TagCategoryDefinition category)
        {
            this.category = category;
        }
    }
}
