namespace SPDB_MKII.Classes.TagInfos.UIRendererEvents
{
    internal class TagUncheckedEventArgs : EventArgs
    {
        private readonly TagRecord tag;

        public TagUncheckedEventArgs(TagRecord tag)
        {
            this.tag = tag;
        }

        public TagRecord Tag { get { return tag; } }
    }
}
