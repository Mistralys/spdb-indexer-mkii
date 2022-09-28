
namespace SPDB_MKII.Classes.FormHandling
{
    internal abstract class BaseFormElement
    {
        protected FormManager formManager;
        protected Control control;
        private readonly List<BaseValidator> validators = new();

        public Control Control { get { return control; } }

        public BaseFormElement(FormManager form, Control control)
        {
            formManager = form;
            this.control = control; 
        }

        protected void RegisterValidator(BaseValidator validator)
        {
            validators.Add(validator);
        }

        public bool Validate()
        {
            bool valid = true;

            foreach (BaseValidator validator in validators)
            {
                if (!validator.Validate())
                {
                    valid = false;
                }
            }

            return valid;
        }

        public void ResetError()
        {
            formManager.ErrorProvider.SetError(control, "");
        }

        public void ResetElement()
        {
            FormManager.ResetControl(control);
        }

        public bool SetError(Control control, string? message = null)
        {
            if (message != null)
            {
                formManager.ErrorProvider.SetError(control, message);
                return false;
            }

            ResetError();
            return true;
        }
    }
}
