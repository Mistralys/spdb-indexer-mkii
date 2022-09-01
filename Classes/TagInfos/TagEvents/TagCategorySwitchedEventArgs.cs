namespace SPDB_MKII.Classes.TagInfos.TagEvents
{
    internal class TagCategorySwitchedEventArgs : EventArgs
    {
        private readonly TagRecord tagDefinition;
        private readonly TagCategoryRecord old;
        private readonly TagCategoryRecord value;

        public TagCategorySwitchedEventArgs(TagRecord tagDefinition, TagCategoryRecord old, TagCategoryRecord value)
        {
            this.tagDefinition = tagDefinition;
            this.old = old;
            this.value = value;
        }

        public TagRecord Tag { get { return tagDefinition; } }
        public TagCategoryRecord OldCategory { get { return old; } }    
        public TagCategoryRecord NewCategory { get { return value; } }
    }
}