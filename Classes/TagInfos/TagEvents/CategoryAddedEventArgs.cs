namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategoryAddedEventArgs : EventArgs
    {
        private TagCategoryRecord category;

        public TagCategoryRecord Category { get => category; }

        public CategoryAddedEventArgs(TagCategoryRecord category)
        {
            this.category = category;
        }
    }
}
