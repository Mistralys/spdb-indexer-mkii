namespace SPDB_MKII.Forms
{
    partial class Folders
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListFolders = new System.Windows.Forms.ListView();
            this.ColLabel = new System.Windows.Forms.ColumnHeader();
            this.ColExists = new System.Windows.Forms.ColumnHeader();
            this.ColPath = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.ContextMenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MenuBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatusBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListFolders, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(895, 28);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(56, 24);
            this.MenuFile.Text = "{File}";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(126, 26);
            this.MenuExit.Text = "{Exit}";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddFolder});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(59, 24);
            this.MenuEdit.Text = "{Edit}";
            // 
            // MenuAddFolder
            // 
            this.MenuAddFolder.Name = "MenuAddFolder";
            this.MenuAddFolder.Size = new System.Drawing.Size(224, 26);
            this.MenuAddFolder.Text = "{Add folder}";
            this.MenuAddFolder.Click += new System.EventHandler(this.MenuAddFolder_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 304);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(895, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(88, 20);
            this.LabelStatus.Text = "{Status text}";
            // 
            // ListFolders
            // 
            this.ListFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColLabel,
            this.ColExists,
            this.ColPath});
            this.ListFolders.ContextMenuStrip = this.ContextMenuList;
            this.ListFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFolders.FullRowSelect = true;
            this.ListFolders.GridLines = true;
            this.ListFolders.Location = new System.Drawing.Point(3, 31);
            this.ListFolders.Name = "ListFolders";
            this.ListFolders.ShowGroups = false;
            this.ListFolders.Size = new System.Drawing.Size(889, 270);
            this.ListFolders.TabIndex = 2;
            this.ListFolders.UseCompatibleStateImageBehavior = false;
            this.ListFolders.View = System.Windows.Forms.View.Details;
            // 
            // ColLabel
            // 
            this.ColLabel.Text = "{Label}";
            this.ColLabel.Width = 240;
            // 
            // ColExists
            // 
            this.ColExists.Text = "{Exists?}";
            this.ColExists.Width = 80;
            // 
            // ColPath
            // 
            this.ColPath.Text = "{Path}";
            this.ColPath.Width = 560;
            // 
            // ContextMenuList
            // 
            this.ContextMenuList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextDelete});
            this.ContextMenuList.Name = "ContextMenuList";
            this.ContextMenuList.Size = new System.Drawing.Size(133, 28);
            // 
            // ContextDelete
            // 
            this.ContextDelete.Name = "ContextDelete";
            this.ContextDelete.Size = new System.Drawing.Size(132, 24);
            this.ContextDelete.Tag = "Style:Dangerous";
            this.ContextDelete.Text = "{Delete}";
            this.ContextDelete.Click += new System.EventHandler(this.ContextDelete_Click);
            // 
            // Folders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Folders";
            this.Text = "{Manage folders}";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ContextMenuList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip MenuBar;
        private StatusStrip StatusBar;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuExit;
        private ToolStripStatusLabel LabelStatus;
        private ListView ListFolders;
        private ToolStripMenuItem MenuEdit;
        private ToolStripMenuItem MenuAddFolder;
        private FolderBrowserDialog FolderBrowserDialog;
        private ColumnHeader ColPath;
        private ColumnHeader ColExists;
        private ColumnHeader ColLabel;
        private ContextMenuStrip ContextMenuList;
        private ToolStripMenuItem ContextDelete;
    }
}