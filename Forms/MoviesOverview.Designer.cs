namespace SPDB_MKII.Forms
{
    partial class MoviesOverview
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
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitPanels = new System.Windows.Forms.SplitContainer();
            this.ListMovies = new System.Windows.Forms.ListView();
            this.ColName = new System.Windows.Forms.ColumnHeader();
            this.ColActors = new System.Windows.Forms.ColumnHeader();
            this.ColStudio = new System.Windows.Forms.ColumnHeader();
            this.TableMain.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanels)).BeginInit();
            this.SplitPanels.Panel1.SuspendLayout();
            this.SplitPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.MainMenu, 0, 0);
            this.TableMain.Controls.Add(this.StatusBar, 0, 2);
            this.TableMain.Controls.Add(this.SplitPanels, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 3;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.Size = new System.Drawing.Size(1170, 717);
            this.TableMain.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuLibrary});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1170, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
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
            // MenuLibrary
            // 
            this.MenuLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFolders});
            this.MenuLibrary.Name = "MenuLibrary";
            this.MenuLibrary.Size = new System.Drawing.Size(78, 24);
            this.MenuLibrary.Text = "{Library}";
            // 
            // MenuFolders
            // 
            this.MenuFolders.Name = "MenuFolders";
            this.MenuFolders.Size = new System.Drawing.Size(224, 26);
            this.MenuFolders.Text = "{Manage folders}";
            this.MenuFolders.Click += new System.EventHandler(this.MenuFolders_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 691);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1170, 26);
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
            // SplitPanels
            // 
            this.SplitPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPanels.Location = new System.Drawing.Point(0, 28);
            this.SplitPanels.Margin = new System.Windows.Forms.Padding(0);
            this.SplitPanels.Name = "SplitPanels";
            // 
            // SplitPanels.Panel1
            // 
            this.SplitPanels.Panel1.Controls.Add(this.ListMovies);
            this.SplitPanels.Size = new System.Drawing.Size(1170, 663);
            this.SplitPanels.SplitterDistance = 849;
            this.SplitPanels.SplitterWidth = 10;
            this.SplitPanels.TabIndex = 2;
            // 
            // ListMovies
            // 
            this.ListMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColActors,
            this.ColStudio});
            this.ListMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListMovies.FullRowSelect = true;
            this.ListMovies.GridLines = true;
            this.ListMovies.Location = new System.Drawing.Point(0, 0);
            this.ListMovies.Name = "ListMovies";
            this.ListMovies.ShowGroups = false;
            this.ListMovies.Size = new System.Drawing.Size(849, 663);
            this.ListMovies.TabIndex = 0;
            this.ListMovies.UseCompatibleStateImageBehavior = false;
            this.ListMovies.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "{Name}";
            // 
            // ColActors
            // 
            this.ColActors.Text = "{Actors}";
            // 
            // ColStudio
            // 
            this.ColStudio.Text = "{Studio}";
            // 
            // MoviesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 717);
            this.Controls.Add(this.TableMain);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MoviesOverview";
            this.Text = "MoviesOverview";
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.SplitPanels.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanels)).EndInit();
            this.SplitPanels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableMain;
        private MenuStrip MainMenu;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuExit;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel LabelStatus;
        private SplitContainer SplitPanels;
        private ListView ListMovies;
        private ColumnHeader ColName;
        private ColumnHeader ColActors;
        private ColumnHeader ColStudio;
        private ToolStripMenuItem MenuLibrary;
        private ToolStripMenuItem MenuFolders;
    }
}