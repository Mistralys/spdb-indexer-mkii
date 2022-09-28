using SPDB_MKII.Classes.TagInfos;
using SPDB_MKII.Classes.UI;
using SPDB_MKII.Forms.Dialogs;

namespace SPDB_MKII.Forms
{
    public partial class TagsEditor : Form
    {
        public TagsEditor()
        {
            InitializeComponent();

            UIRenderer renderer = new(TabsCategories, new StatusBarManager(LabelStatus));
            renderer.TagChecked += Handle_Renderer_TagChecked;
            renderer.TagUnchecked += Handle_Renderer_TagUnchecked;
            renderer.Render();
        }

        private void Handle_Renderer_TagUnchecked(object? sender, Classes.TagInfos.UIRendererEvents.TagUncheckedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Handle_Renderer_TagChecked(object? sender, Classes.TagInfos.UIRendererEvents.TagCheckedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Handle_MenuAddCategory_Click(object sender, EventArgs e)
        {
            TagCategoryEditor dialog = new();
            dialog.Show();
        }
    }
}
