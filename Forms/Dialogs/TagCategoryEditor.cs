using SPDB_MKII.Classes.DatabaseHandling;
using SPDB_MKII.Classes.FormHandling;
using SPDB_MKII.Classes.FormHandling.Elements;
using SPDB_MKII.Classes.TagInfos;
using SPDB_MKII.Properties;
using System.Diagnostics.CodeAnalysis;

namespace SPDB_MKII.Forms.Dialogs
{
    internal partial class TagCategoryEditor : Form
    {
        private readonly TagCategoryRecord? category;
        private FormManager form;
        private TextBoxElement elLabel;

        public TagCategoryEditor()
        {
            Init(); 
        }

        public TagCategoryEditor(TagCategoryRecord category)
        {
            this.category = category;

            Init();
        }

        [MemberNotNull(nameof(form))]
        [MemberNotNull(nameof(elLabel))]
        private void Init()
        {
            InitializeComponent();

            form = new(ErrorProvider);

            elLabel = form.RegisterTextBox(FieldLabel)
                .ValidateNotEmpty();

            if(category != null)
            {
                FieldLabel.Text = category.Name;
            }

            TranslateUI();
        }

        private void TranslateUI()
        {
            if (category != null) 
            {
                Text = string.Format(Localization.Dialog_CategoryEditor_Title_EditX, category.Name);
            }
            else
            {
                Text = Localization.Dialog_CategoryEditor_Title_Add;
                BtnOK.Text = Localization.Button_AddNow;
            }

            Abstract.Abstract = Localization.Dialog_CategoryEditor_Abstract;
        }

        public bool EditMode => category != null;

        private void FieldLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SubmitForm();
            }
        }

        private void SubmitForm()
        {
            if(!form.Validate())
            {
                return;
            }

            DBHelper.Instance.StartTransaction();

            if (category == null)
            {
                TagCollection.AddCategory(elLabel.Text);
            }
            else
            {
                category.Name = elLabel.Text;
                category.Save();
            }

            DBHelper.Instance.CommitTransaction();
        }

        private void Handle_BtnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void Handle_BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
