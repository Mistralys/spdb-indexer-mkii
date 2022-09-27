using SPDB_MKII.Classes.MovieInfos;
using SPDB_MKII.Classes.TagInfos.UIRendererEvents;
using SPDB_MKII.Classes.UI;
using SPDB_MKII.Properties;

namespace SPDB_MKII.Classes.TagInfos
{
    internal class UIRenderer
    {
        private readonly TabControl tabControl;
        private readonly Dictionary<long, TabPage> tabs = new();
        private readonly Dictionary<long, TreeView> tagTrees = new();
        private readonly Dictionary<long, TreeNode> tagNodes = new();
        private readonly StatusBarManager statusBar;
        private bool rendered = false;
        private MovieRecord? movie = null;

        public MovieRecord? Movie
        {
            get
            {
                return movie;
            }

            set
            {
                movie = value;

                if(value == null) 
                { 
                    MovieRemoved?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MovieSet?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler? MovieSet;
        public event EventHandler? MovieRemoved;

        public UIRenderer(TabControl tabControl, StatusBarManager statusBar)
        {
            this.tabControl = tabControl;
            this.statusBar = statusBar;

            TagCollection.CategoryAdded += Handle_TagCollection_CategoryAdded;
            TagCollection.CategoryDeleted += Handle_TagCollection_CategoryDeleted;
            TagCollection.TagDeleted += Handle_TagCollection_TagDeleted;
            TagCollection.TagCategorySwitched += Handle_TagCollection_TagCategorySwitched;
        }

        private void Handle_TagCollection_TagCategorySwitched(object? sender, TagEvents.TagCategorySwitchedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Handle_TagCollection_TagDeleted(object? sender, TagEvents.TagDeletedEventArgs e)
        {
            if (tagNodes.ContainsKey(e.ID))
            {
                tagNodes[e.ID].Remove();
                tagNodes.Remove(e.ID);
            }
        }

        private void Handle_TagCollection_CategoryDeleted(object? sender, TagEvents.CategoryDeletedEventArgs e)
        {
            if (tabs.ContainsKey(e.ID))
            {
                tabControl.TabPages.Remove(tabs[e.ID]);
                tabs.Remove(e.ID);
            }

            if(tagTrees.ContainsKey(e.ID))
            {
                tagTrees.Remove(e.ID);
            }
        }

        private void Handle_TagCollection_CategoryAdded(object? sender, TagEvents.CategoryAddedEventArgs e)
        {
            Program.Log.Debug(
                "UIRenderer | Category [{0}] | Newly added; rendering it.", 
                e.Category.Name
            );

            RenderCategory(e.Category);

            statusBar.ShowText(string.Format(
                Localization.Status_TagCategory_X_Added,
                e.Category.Name
            ));
        }

        public void Render()
        {
            if (rendered) {
                return;
            }

            Program.Log.Debug(
                "UIRenderer | Initial categories rendering for [{0}] categories.",
                TagCollection.Categories.Count
            );

            tabControl.SuspendLayout();

            foreach(TagCategoryRecord category in TagCollection.Categories)
            {
                RenderCategory(category);
            }

            tabControl.ResumeLayout();

            rendered = true;

            Program.Log.Debug("UIRenderer | Render done.");
        }

        private void RenderCategory(TagCategoryRecord category)
        {
            Program.Log.Debug(
                "UIRenderer | Category [{0}] | Creating the tab page.", 
                category.Name
            );

            TabPage tabPage = new()
            {
                Tag = category, 
                Text = category.Name
            };

            tabControl.TabPages.Add(tabPage);

            TreeView listBox = new()
            {
                Dock = DockStyle.Fill,
                CheckBoxes = true,
                Tag = category,
            };

            listBox.AfterCheck += Handle_TreeView_AfterCheck;

            listBox.SuspendLayout();

            tabPage.Controls.Add(listBox);

            tabs[category.ID] = tabPage;
            tagTrees[category.ID] = listBox;

            
            RenderTags(category);

            listBox.ExpandAll();
        }

        private void Handle_TreeView_AfterCheck(object? sender, TreeViewEventArgs e)
        {
            if(sender is TreeView treeView)
            {
                if (e.Node != null && e.Node.Tag is TagRecord tag) 
                {
                    if (e.Node.Checked)
                    {
                        TagChecked?.Invoke(this, new TagCheckedEventArgs(tag));
                    }
                    else
                    {
                        TagUnchecked?.Invoke(this, new TagUncheckedEventArgs(tag));
                    }
                }
            }
        }

        private void RenderTags(TagCategoryRecord category)
        {
            Program.Log.Debug(
                "UIRenderer | Category [{0}] | Building the tags tree for [{1}] tags.", 
                category.Name, 
                category.Tags.Count
            );

            PopulateTagsRecursive(GetCategoryTagsTree(category), category.Tags);
        }

        private void PopulateTagsRecursive(TreeView tree, List<TagRecord> tags)
        {
            Program.Log.Debug(
                "UIRenderer  | Populating [{0}] root tags.",
                tags.Count
            );

            foreach (TagRecord tag in tags)
            {
                TreeNode node = new()
                {
                    Text = tag.Name,
                    Tag = tag
                };

                tree.Nodes.Add(node);

                tagNodes[tag.ID] = node;

                if (tag.ChildTags.Count > 0)
                {
                    PopulateTagsRecursive(node, tag.ChildTags);
                }
            }
        }

        private void PopulateTagsRecursive(TreeNode parentNode, List<TagRecord> tags)
        {
            foreach (TagRecord tag in tags)
            {
                TreeNode node = new()
                {
                    Text = tag.Name,
                    Tag = tag
                };

                parentNode.Nodes.Add(node);

                tagNodes[tag.ID] = node;

                if (tag.ChildTags.Count > 0)
                {
                    PopulateTagsRecursive(node, tag.ChildTags);
                }
            }
        }

        private TreeNode GetTagNode(TagRecord tag)
        {
            if(tagNodes.ContainsKey(tag.ID))
            {
                return tagNodes[tag.ID];
            }

            throw new Exception("No matching tree node found.");
        }

        private TreeView GetCategoryTagsTree(TagCategoryRecord category)
        {
            if (tagTrees.ContainsKey(category.ID))
            {
                return tagTrees[category.ID];
            }

            throw new Exception(string.Format("No matching checkbox list for category {0}.", category.ID));
        }

        private TabPage GetCategoryPage(TagCategoryRecord category)
        {
            if(tabs.ContainsKey(category.ID))
            {
                return tabs[category.ID];
            }

            throw new Exception(string.Format("No matching tab page for category {0}.", category.ID));
        }

        public event EventHandler<TagCheckedEventArgs>? TagChecked;
        public event EventHandler<TagUncheckedEventArgs>? TagUnchecked;
    }
}
