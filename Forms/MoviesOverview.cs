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

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
