using SPDB_MKII.Classes.FormHandling;
using SPDB_MKII.Classes.FormHandling.Elements;
using SPDB_MKII.Forms.Dialogs.TextPromptEvents;
using SPDB_MKII.Properties;

namespace SPDB_MKII.Forms.Dialogs
{
    public partial class TextPrompt : Form
    {
        private TextBoxElement elInput;
        private FormManager formManager;

        public string Message
        {
            set 
            {
                LabelMessage.Text = value;
            }
        }

        public string Title
        {
            set
            {
                Text = value;
            }
        }

        public TextPrompt()
        {
            InitializeComponent();

            formManager = new FormManager(ErrorDisplay);

            elInput = formManager.RegisterTextBox(FieldInput)
                .ValidateNotEmpty();

            TranslateUI();
        }

        private void TranslateUI()
        {
            Text = Localization.Dialog_TextPrompt_Title;
            LabelMessage.Text = Localization.Dialog_TextPrompt_Message;
            BtnCancel.Text = Localization.Button_Cancel;
            BtnOK.Text = Localization.Button_OK; 
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(formManager.Validate())
            {
                Ok?.Invoke(this, new OKEventArgs(elInput.Text));
                Close();
            }
        }

        public event EventHandler? Cancelled;
        public event EventHandler<OKEventArgs>? Ok;
    }
}
