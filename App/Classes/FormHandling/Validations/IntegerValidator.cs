using SPDB_MKII.Classes.FormHandling.Elements;

namespace SPDB_MKII.Classes.FormHandling.Validations
{
    internal class IntegerValidator : BaseValidator
    {
        TextBoxElement textBoxElement;

        public IntegerValidator(TextBoxElement element) : base(element)
        {
            textBoxElement = element;
        }

        public override bool Validate()
        {
            string value = textBoxElement.Text.Trim();
            string? message = null;

            if (value != String.Empty && !int.TryParse(value, out _)) 
            {
                message = "{Must be a valid integer}";
            }

            return element.SetError(textBoxElement.TextBox, message);
        }
    }
}
