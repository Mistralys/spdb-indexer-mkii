namespace SPDB_MKII.Forms.Dialogs.TextPromptEvents
{
    public class OKEventArgs : EventArgs
    {
        private readonly string text;

        public string Text => text;

        public OKEventArgs(string text) : base()
        {
            this.text = text;
        }
    }
}
