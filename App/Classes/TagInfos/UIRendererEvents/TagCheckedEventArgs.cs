namespace SPDB_MKII.Classes.TagInfos.UIRendererEvents
{
    internal class TagCheckedEventArgs : EventArgs
    {
        private readonly TagRecord tag;

        public TagCheckedEventArgs(TagRecord tag)
        {
            this.tag = tag;
        }

        public TagRecord Tag { get { return tag; } }
    }
}
