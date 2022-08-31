using SPDB_MKII.Classes.FolderInfos;
using SPDB_MKII.Classes.UI;
using SPDB_MKII.Forms.Dialogs;
using SPDB_MKII.Properties;

namespace SPDB_MKII.Forms
{
    public partial class Folders : Form
    {
        private readonly StatusBarManager statusBar;
        private string path = "";

        public Folders()
        {
            InitializeComponent();

            statusBar = new StatusBarManager(LabelStatus);

            TranslateUI();
            RefreshList();
        }

        private void TranslateUI()
        {
            Text = Localization.Dialog_Title_Folders;
            FolderBrowserDialog.Description = Localization.Dialog_Folders_Browse_Description;
        }

        private void RefreshList()
        {
            ListFolders.Items.Clear();

            foreach(FolderDefinition def in FolderCollection.Folders)
            {
                string[] values = { 
                    def.Label,
                    def.ExistsPretty,
                    def.Path
                };

                ListViewItem item = new(values);
                item.Tag = def;

                ListFolders.Items.Add(item);
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuAddFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserDialog.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                return;
            }

            path = FolderBrowserDialog.SelectedPath;

            TextPrompt dialog = new();

            dialog.Message = Localization.Dialog_Folders_Message_EnterLabel;
            dialog.Title = Localization.Dialog_Folders_Title_AddFolder;
            dialog.Cancelled += Dialog_Cancelled;
            dialog.Ok += Dialog_Ok;

            dialog.ShowDialog();
        }

        private void Dialog_Ok(object? sender, Dialogs.TextPromptEvents.OKEventArgs e)
        {
            FolderCollection.AddFolderDefinition(path, e.Text);
            FolderCollection.Save();

            statusBar.ShowText(Localization.Dialog_Folders_Message_Added_Folder);

            RefreshList();
        }

        private void Dialog_Cancelled(object? sender, EventArgs e)
        {
            statusBar.ShowText(Localization.Dialog_Folders_Status_CancelledAdding);
        }

        private void ContextDelete_Click(object sender, EventArgs e)
        {
            if (ListFolders.SelectedItems.Count == 0) {
                return;
            }

            foreach(ListViewItem item in ListFolders.SelectedItems)
            {
                if(item.Tag is FolderDefinition def)
                {
                    FolderCollection.DeleteFolderDefinition(def);
                }
            }

            FolderCollection.Save();

            RefreshList();

            statusBar.ShowText(Localization.Dialog_Folders_Status_FoldersDeleted);
        }
    }
}
