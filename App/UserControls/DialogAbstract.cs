namespace SPDB_MKII.UserControls
{
    public partial class DialogAbstract : UserControl
    {
        public DialogAbstract()
        {
            InitializeComponent();
        }

        public string Abstract
        {
            get { return LabelAbstract.Text; }
            set { LabelAbstract.Text = value; }
        }
    }
}
