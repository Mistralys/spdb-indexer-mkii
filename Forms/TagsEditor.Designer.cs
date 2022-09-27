namespace SPDB_MKII.Forms
{
    partial class TagsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.TabsCategories = new System.Windows.Forms.TabControl();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TableMain.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.MainMenu, 0, 0);
            this.TableMain.Controls.Add(this.TabsCategories, 0, 1);
            this.TableMain.Controls.Add(this.StatusBar, 0, 2);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 3;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.Size = new System.Drawing.Size(719, 602);
            this.TableMain.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategories});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(719, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuCategories
            // 
            this.MenuCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddCategory});
            this.MenuCategories.Name = "MenuCategories";
            this.MenuCategories.Size = new System.Drawing.Size(104, 24);
            this.MenuCategories.Text = "{Categories}";
            // 
            // MenuAddCategory
            // 
            this.MenuAddCategory.Name = "MenuAddCategory";
            this.MenuAddCategory.Size = new System.Drawing.Size(192, 26);
            this.MenuAddCategory.Text = "{Add category}";
            this.MenuAddCategory.Click += new System.EventHandler(this.Handle_MenuAddCategory_Click);
            // 
            // TabsCategories
            // 
            this.TabsCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsCategories.Location = new System.Drawing.Point(0, 28);
            this.TabsCategories.Margin = new System.Windows.Forms.Padding(0);
            this.TabsCategories.Name = "TabsCategories";
            this.TabsCategories.SelectedIndex = 0;
            this.TabsCategories.Size = new System.Drawing.Size(719, 548);
            this.TabsCategories.TabIndex = 1;
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 576);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(719, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(88, 20);
            this.LabelStatus.Text = "{Status text}";
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 602);
            this.Controls.Add(this.TableMain);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TagsEditor";
            this.Text = "{Tags editor}";
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableMain;
        private MenuStrip MainMenu;
        private ToolStripMenuItem MenuCategories;
        private ToolStripMenuItem MenuAddCategory;
        private TabControl TabsCategories;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel LabelStatus;
    }
}