namespace SPDB_MKII.Classes.FormHandling
{
    internal abstract class BaseValidator
    {
        protected BaseFormElement element;

        public Control Control { get { return element.Control; } }

        public BaseValidator(BaseFormElement formElement)
        {
            element = formElement;
        }

        abstract public bool Validate();   
    }
}
