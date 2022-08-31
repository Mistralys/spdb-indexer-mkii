using SPDB_MKII.Classes.FormHandling.Validations;

namespace SPDB_MKII.Classes.FormHandling.Elements
{
    internal class TextBoxElement : BaseFormElement
    {
        TextBox textBox;

        public TextBox TextBox { get { return textBox; } }

        public TextBoxElement(FormManager form, TextBox control) : base(form, control)
        {
            textBox = control;
        }

        public string Text { 
            get { return textBox.Text; } 
            set { textBox.Text = value; }
        }

        public TextBoxElement ValidateNotEmpty()
        {
            TextBoxNotEmptyValidator validator = new(this);
            RegisterValidator(validator);
            return this;
        }
    }
}
