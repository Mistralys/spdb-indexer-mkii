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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.TabsCategories = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TabsCategories, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 662);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.MenuAddCategory.Size = new System.Drawing.Size(224, 26);
            this.MenuAddCategory.Text = "{Add category}";
            this.MenuAddCategory.Click += new System.EventHandler(this.Handle_MenuAddCategory_Click);
            // 
            // TabsCategories
            // 
            this.TabsCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsCategories.Location = new System.Drawing.Point(3, 31);
            this.TabsCategories.Name = "TabsCategories";
            this.TabsCategories.SelectedIndex = 0;
            this.TabsCategories.Size = new System.Drawing.Size(713, 628);
            this.TabsCategories.TabIndex = 1;
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TagsEditor";
            this.Text = "{Tags editor}";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem MenuCategories;
        private ToolStripMenuItem MenuAddCategory;
        private TabControl TabsCategories;
    }
}