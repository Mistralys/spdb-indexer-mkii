namespace SPDB_MKII.Classes.UI
{
    internal class StatusBarManager
    {
        private readonly ToolStripStatusLabel control;

        public StatusBarManager(ToolStripStatusLabel labelControl)
        {
            control = labelControl;

            ResetText();
        }

        public StatusBarManager ShowText(string text)
        {
            control.Text = text;
            return this;
        }

        public StatusBarManager ResetText()
        {
            control.Text = "";
            return this;
        }
    }
}
