namespace SPDB_MKII.Classes.TagInfos
{
    internal class TagParentSwitched
    {
        private TagRecord tag;
        private TagRecord? oldTag;
        private TagRecord? newTag;

        public TagParentSwitched(TagRecord tagRecord, TagRecord? oldParent, TagRecord newParent)
        {
            this.tag = tagRecord;
            this.oldTag = oldParent;
            this.newTag = newParent;
        }

        public TagParentSwitched(TagRecord tagRecord, TagRecord oldParent)
        {
            this.tag = tagRecord;
            this.oldTag = oldParent;
        }
    }
}