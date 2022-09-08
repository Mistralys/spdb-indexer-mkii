using SPDB_MKII.Classes.TagInfos;
using SPDB_MKII.Forms.Dialogs;

namespace SPDB_MKII.Forms
{
    public partial class TagsEditor : Form
    {
        public TagsEditor()
        {
            InitializeComponent();

            UIRenderer renderer = new(TabsCategories);
            renderer.Render();
        }

        private void Handle_MenuAddCategory_Click(object sender, EventArgs e)
        {
            TagCategoryEditor dialog = new();
            dialog.Show();
        }
    }
}
