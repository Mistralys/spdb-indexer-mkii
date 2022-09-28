using SPDB_MKII.Classes.FormHandling.Elements;

namespace SPDB_MKII.Classes.FormHandling
{
    internal class FormManager
    {
        private readonly ErrorProvider errorProvider;
        private readonly List<BaseFormElement> formElements = new();
        
        public ErrorProvider ErrorProvider { get { return errorProvider; } }

        public FormManager(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
        }

        private void RegisterElement(BaseFormElement element)
        {
            formElements.Add(element);
        }

        public IntegerElement RegisterInteger(TextBox textBox)
        {
            IntegerElement element = new(this, textBox);

            RegisterElement(element);

            return element;
        }

        public TextBoxElement RegisterTextBox(TextBox textBox)
        {
            TextBoxElement element = new(this, textBox);
            
            RegisterElement(element);

            return element;
        }

        public bool Validate()
        {
            bool valid = true;

            foreach(BaseFormElement element in formElements)
            {
                if (!element.Validate()) {
                    valid = false;
                }
            }

            return valid;
        }

        public void ResetErrors()
        {
            foreach (BaseFormElement element in formElements)
            {
                element.ResetError();
            }
        }

        public void ResetElementValues()
        {
            foreach (BaseFormElement element in formElements)
            {
                element.ResetElement();
            }
        }

        public static void ResetControl(Control control)
        {
            if (control is TextBoxBase textBox)
            {
                textBox.Clear();
            }

            if (control is ComboBox comboBox && comboBox.Items.Count > 0)
            { 
                comboBox.SelectedIndex = 0;
            }

            if (control is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }

            if (control is ListBox listBox)
            {
                listBox.ClearSelected();
            }
        }
    }
}
