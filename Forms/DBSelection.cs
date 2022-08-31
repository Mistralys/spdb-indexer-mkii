using SPDB_MKII.Classes.DatabaseInfos;
using SPDB_MKII.Classes.FormHandling.Elements;
using SPDB_MKII.Classes.FormHandling;
using SPDB_MKII.Properties;
using SPDB_MKII.Classes;

namespace SPDB_MKII.Forms
{
    public partial class DBSelection : Form
    {
        private DatabaseDefinition? editDef = null;
        private readonly FormManager formManager;
        private readonly IntegerElement elPort;
        private readonly TextBoxElement elDatabaseName;
        private readonly TextBoxElement elHost;
        private readonly TextBoxElement elPassword;
        private readonly TextBoxElement elUserName;

        public DBSelection()
        {
            InitializeComponent();

            // -----------------------------------------------------
            // CONFIGURE FORM
            // -----------------------------------------------------

            formManager = new FormManager(ErrorDisplay);

            elHost = formManager.RegisterTextBox(FieldHost)
                .ValidateNotEmpty();

            elDatabaseName = formManager.RegisterTextBox(FieldDatabaseName)
                .ValidateNotEmpty();

            elUserName = formManager.RegisterTextBox(FieldUserName)
                .ValidateNotEmpty();

            elPassword = formManager.RegisterTextBox(FieldPassword)
                .ValidateNotEmpty();

            elPort = formManager.RegisterInteger(FieldPort);

            // -----------------------------------------------------
            // SET UP UI
            // -----------------------------------------------------

            LabelStatus.Text = "";

            RefreshList();
            RefreshForm();
        }

        private void RefreshList()
        {
            Program.Log.Debug("DB Editor | Refreshing the databases list.");

            ListDatabases.Items.Clear();

            foreach (DatabaseDefinition database in DatabaseCollection.Databases)
            {
                string[] row = {
                    database.DatabaseName,
                    database.Host,
                    database.UserName,
                    database.Port.ToString()
                };

                ListViewItem item = new(row);

                item.Tag = database;

                ListDatabases.Items.Add(item);
            }
        }

        private void RefreshForm()
        {
            bool editing = editDef != null;

            BtnAdd.Visible = !editing;
            BtnClear.Visible = !editing;
            BtnCancel.Visible = editing;
            BtnApply.Visible = editing;

            if (editDef == null)
            {
                TitleAddEdit.Text = Localization.Title_Add_Database;
                return;
            }

            TitleAddEdit.Text = Localization.Title_Edit_Database;

            elDatabaseName.Text = editDef.DatabaseName;
            elPassword.Text = editDef.Password;
            elHost.Text = editDef.Host;
            elUserName.Text = editDef.UserName;
            elPassword.Text = editDef.Password;
            elPort.Value = editDef.Port;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!formManager.Validate())
            {
                return;
            }

            DatabaseDefinition def = DatabaseCollection.AddDefinition(
                elHost.Text,
                elUserName.Text,
                elPassword.Text,
                elDatabaseName.Text,
                elPort.Value
            );

            DatabaseCollection.Save();

            RefreshList();

            formManager.ResetElementValues();

            LabelStatus.Text = string.Format(Localization.Status_Database_X_Added, def.DatabaseName);
        }

        private void ClearForm()
        {
            Program.Log.Debug("DB Editor | Clearing the form.");

            formManager.ResetElementValues();
            formManager.ResetErrors();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ContextEdit_Click(object sender, EventArgs e)
        {
            if (ListDatabases.SelectedItems.Count == 0)
            {
                return;
            }

            if (ListDatabases.SelectedItems[0].Tag is DatabaseDefinition def)
            {
                editDef = def;
                RefreshForm();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            editDef = null;

            ClearForm();
            RefreshForm();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (editDef == null)
            {
                return;
            }

            editDef.DatabaseName = elDatabaseName.Text;
            editDef.Port = elPort.Value;
            editDef.Host = elHost.Text;
            editDef.UserName = elUserName.Text;
            editDef.Password = elPassword.Text;

            DatabaseCollection.Save();

            LabelStatus.Text = string.Format(Localization.Status_Database_X_Saved, editDef.DatabaseName);

            editDef = null;

            ClearForm();
            RefreshForm();
            RefreshList();
        }

        private void ContextDelete_Click(object sender, EventArgs e)
        {
            if (ListDatabases.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (ListViewItem item in ListDatabases.SelectedItems)
            {
                if (item.Tag is DatabaseDefinition def)
                {
                    DatabaseCollection.DeleteDefinition(def);
                }
            }

            DatabaseCollection.Save();

            RefreshList();
        }

        private void ListDatabases_DoubleClick(object sender, EventArgs e)
        {
            if (ListDatabases.SelectedItems.Count == 0)
            {
                return;
            }

            if (ListDatabases.SelectedItems[0].Tag is DatabaseDefinition def)
            {
                Connect(def);
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Connect(DatabaseDefinition def)
        {
            Program.Log.Information("DB Editor | Database selected: [{0}@{1}].", def.DatabaseName, def.Host);

            DatabaseCollection.ActiveDatabase = def;

            try
            {
                var service = Program.ServiceProvider.GetService(typeof(DatabaseContext));

                if (service is DatabaseContext databaseContext)
                {
                    Program.Log.Information("DB Editor | Connection successful.");

                    MoviesOverview screen = new()
                    {
                        Location = Location,
                        StartPosition = FormStartPosition.Manual
                    };

                    screen.FormClosing += delegate { Close(); };
                    screen.Show();

                    Hide();
                }
            }
            catch (Exception ex)
            {
                Program.Log.Information("DB Editor | Connection failed.");
                Program.Log.Information("DB Editor | Exception message: [{0}]", ex.Message);

                MessageBox.Show(Localization.Message_Database_Connection_Failed);
            }
        }
    }
}
