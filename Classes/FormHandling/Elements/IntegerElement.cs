using SPDB_MKII.Classes.FormHandling.Validations;

namespace SPDB_MKII.Classes.FormHandling.Elements
{
    internal class IntegerElement : TextBoxElement
    {
        public IntegerElement(FormManager form, TextBox control) : base(form, control)
        {
            RegisterValidator(new IntegerValidator(this));
        }

        public int Value { 
            get
            {
                if(int.TryParse(Text, out int value)) { 
                    return value; 
                }

                return 0;
            }

            set
            {
                Text = value.ToString();
            }
        }
    }
}
