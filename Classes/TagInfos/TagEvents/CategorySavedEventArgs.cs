namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class CategorySavedEventArgs : EventArgs
    {
        private readonly TagCategoryRecord category;

        public CategorySavedEventArgs(TagCategoryRecord category)
        {
            this.category = category;
        }

        public TagCategoryRecord Category { get { return category; } }
    }
}
