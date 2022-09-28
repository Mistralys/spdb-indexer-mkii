using SPDB_MKII.Classes.FormHandling.Elements;

namespace SPDB_MKII.Classes.FormHandling.Validations
{
    internal class TextBoxNotEmptyValidator : BaseValidator
    {
        private readonly TextBoxElement textBoxElement;

        public TextBoxNotEmptyValidator(TextBoxElement element) : base(element)
        {
            textBoxElement = element;
        }

        public override bool Validate()
        {
            string value = textBoxElement.Text.Trim();
            string? message = null;

            if (value == string.Empty)
            {
                message = "{This field may not be empty}";
            }

            return element.SetError(textBoxElement.TextBox, message);
        }
    }
}
