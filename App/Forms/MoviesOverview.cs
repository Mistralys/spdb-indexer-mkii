using SPDB_MKII.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDB_MKII.Forms
{
    public partial class MoviesOverview : Form
    {
        public MoviesOverview()
        {
            InitializeComponent();

            LabelStatus.Text = "";
        }

        private void Handle_MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Handle_MenuFolders_Click(object sender, EventArgs e)
        {
            Folders dialog = new();
            dialog.Show();
        }

        private void Handle_MenuManageTags_Click(object sender, EventArgs e)
        {
            TagsEditor dialog = new();
            dialog.Show();
        }
    }
}
