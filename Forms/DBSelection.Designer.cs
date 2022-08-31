namespace SPDB_MKII.Forms
{
    partial class DBSelection
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
            this.ErrorDisplay = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ColPort = new System.Windows.Forms.ColumnHeader();
            this.ColUserName = new System.Windows.Forms.ColumnHeader();
            this.ColHost = new System.Windows.Forms.ColumnHeader();
            this.ColDatabaseName = new System.Windows.Forms.ColumnHeader();
            this.ListDatabases = new System.Windows.Forms.ListView();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabelPort = new System.Windows.Forms.Label();
            this.FieldUserName = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.FieldDatabaseName = new System.Windows.Forms.TextBox();
            this.LabelDatabase = new System.Windows.Forms.Label();
            this.TitleAddEdit = new System.Windows.Forms.Label();
            this.LabelHost = new System.Windows.Forms.Label();
            this.FieldHost = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.FieldPassword = new System.Windows.Forms.TextBox();
            this.TableForm = new System.Windows.Forms.TableLayoutPanel();
            this.FieldPort = new System.Windows.Forms.TextBox();
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDisplay)).BeginInit();
            this.ListContextMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.TableForm.SuspendLayout();
            this.TableMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorDisplay
            // 
            this.ErrorDisplay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDisplay.ContainerControl = this;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // ContextEdit
            // 
            this.ContextEdit.Name = "ContextEdit";
            this.ContextEdit.Size = new System.Drawing.Size(122, 24);
            this.ContextEdit.Text = "&Edit";
            this.ContextEdit.Click += new System.EventHandler(this.ContextEdit_Click);
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextEdit,
            this.toolStripSeparator1,
            this.ContextDelete});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(123, 58);
            // 
            // ContextDelete
            // 
            this.ContextDelete.Name = "ContextDelete";
            this.ContextDelete.Size = new System.Drawing.Size(122, 24);
            this.ContextDelete.Text = "&Delete";
            this.ContextDelete.Click += new System.EventHandler(this.ContextDelete_Click);
            // 
            // ColPort
            // 
            this.ColPort.Text = "{Port}";
            // 
            // ColUserName
            // 
            this.ColUserName.Text = "{User name}";
            this.ColUserName.Width = 120;
            // 
            // ColHost
            // 
            this.ColHost.Text = "{Host}";
            this.ColHost.Width = 120;
            // 
            // ColDatabaseName
            // 
            this.ColDatabaseName.Text = "{Database name}";
            this.ColDatabaseName.Width = 180;
            // 
            // ListDatabases
            // 
            this.ListDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDatabases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDatabaseName,
            this.ColHost,
            this.ColUserName,
            this.ColPort});
            this.ListDatabases.ContextMenuStrip = this.ListContextMenu;
            this.ListDatabases.FullRowSelect = true;
            this.ListDatabases.GridLines = true;
            this.ListDatabases.Location = new System.Drawing.Point(3, 31);
            this.ListDatabases.Name = "ListDatabases";
            this.ListDatabases.ShowGroups = false;
            this.ListDatabases.Size = new System.Drawing.Size(613, 174);
            this.ListDatabases.TabIndex = 3;
            this.ListDatabases.UseCompatibleStateImageBehavior = false;
            this.ListDatabases.View = System.Windows.Forms.View.Details;
            this.ListDatabases.DoubleClick += new System.EventHandler(this.ListDatabases_DoubleClick);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(88, 20);
            this.LabelStatus.Text = "{Status text}";
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 521);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(619, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableForm.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.BtnAdd);
            this.flowLayoutPanel1.Controls.Add(this.BtnClear);
            this.flowLayoutPanel1.Controls.Add(this.BtnApply);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 243);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(599, 36);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd.Location = new System.Drawing.Point(539, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAdd.Size = new System.Drawing.Size(57, 30);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Tag = "Style:Primary";
            this.BtnAdd.Text = "{Add}";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClear.Location = new System.Drawing.Point(470, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClear.Size = new System.Drawing.Size(63, 30);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "{Clear}";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.AutoSize = true;
            this.BtnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnApply.Location = new System.Drawing.Point(396, 3);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnApply.Size = new System.Drawing.Size(68, 30);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Tag = "Style:Primary";
            this.BtnApply.Text = "{Apply}";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Location = new System.Drawing.Point(317, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCancel.Size = new System.Drawing.Size(73, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "{Cancel}";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LabelPort
            // 
            this.LabelPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(81, 203);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(45, 20);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "{Port}";
            // 
            // FieldUserName
            // 
            this.FieldUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldUserName.Location = new System.Drawing.Point(132, 122);
            this.FieldUserName.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldUserName.Name = "FieldUserName";
            this.FieldUserName.Size = new System.Drawing.Size(437, 27);
            this.FieldUserName.TabIndex = 6;
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(37, 125);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(89, 20);
            this.LabelUserName.TabIndex = 5;
            this.LabelUserName.Text = "{User name}";
            // 
            // FieldDatabaseName
            // 
            this.FieldDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldDatabaseName.Location = new System.Drawing.Point(132, 83);
            this.FieldDatabaseName.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldDatabaseName.Name = "FieldDatabaseName";
            this.FieldDatabaseName.Size = new System.Drawing.Size(437, 27);
            this.FieldDatabaseName.TabIndex = 4;
            // 
            // LabelDatabase
            // 
            this.LabelDatabase.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelDatabase.AutoSize = true;
            this.LabelDatabase.Location = new System.Drawing.Point(3, 86);
            this.LabelDatabase.Name = "LabelDatabase";
            this.LabelDatabase.Size = new System.Drawing.Size(123, 20);
            this.LabelDatabase.TabIndex = 3;
            this.LabelDatabase.Text = "{Database name}";
            // 
            // TitleAddEdit
            // 
            this.TitleAddEdit.AutoSize = true;
            this.TableForm.SetColumnSpan(this.TitleAddEdit, 2);
            this.TitleAddEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleAddEdit.Location = new System.Drawing.Point(0, 0);
            this.TitleAddEdit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TitleAddEdit.Name = "TitleAddEdit";
            this.TitleAddEdit.Size = new System.Drawing.Size(110, 28);
            this.TitleAddEdit.TabIndex = 0;
            this.TitleAddEdit.Text = "{Add/Edit}";
            // 
            // LabelHost
            // 
            this.LabelHost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(76, 47);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(50, 20);
            this.LabelHost.TabIndex = 1;
            this.LabelHost.Text = "{Host}";
            // 
            // FieldHost
            // 
            this.FieldHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldHost.Location = new System.Drawing.Point(132, 44);
            this.FieldHost.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldHost.Name = "FieldHost";
            this.FieldHost.Size = new System.Drawing.Size(437, 27);
            this.FieldHost.TabIndex = 2;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(46, 164);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(80, 20);
            this.LabelPassword.TabIndex = 7;
            this.LabelPassword.Text = "{Password}";
            // 
            // FieldPassword
            // 
            this.FieldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldPassword.Location = new System.Drawing.Point(132, 161);
            this.FieldPassword.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldPassword.Name = "FieldPassword";
            this.FieldPassword.Size = new System.Drawing.Size(437, 27);
            this.FieldPassword.TabIndex = 8;
            // 
            // TableForm
            // 
            this.TableForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableForm.AutoSize = true;
            this.TableForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableForm.ColumnCount = 2;
            this.TableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableForm.Controls.Add(this.FieldUserName, 1, 3);
            this.TableForm.Controls.Add(this.LabelUserName, 0, 3);
            this.TableForm.Controls.Add(this.FieldDatabaseName, 1, 2);
            this.TableForm.Controls.Add(this.LabelDatabase, 0, 2);
            this.TableForm.Controls.Add(this.TitleAddEdit, 0, 0);
            this.TableForm.Controls.Add(this.LabelHost, 0, 1);
            this.TableForm.Controls.Add(this.FieldHost, 1, 1);
            this.TableForm.Controls.Add(this.LabelPassword, 0, 4);
            this.TableForm.Controls.Add(this.FieldPassword, 1, 4);
            this.TableForm.Controls.Add(this.LabelPort, 0, 5);
            this.TableForm.Controls.Add(this.FieldPort, 1, 5);
            this.TableForm.Controls.Add(this.flowLayoutPanel1, 0, 6);
            this.TableForm.Location = new System.Drawing.Point(10, 218);
            this.TableForm.Margin = new System.Windows.Forms.Padding(10);
            this.TableForm.Name = "TableForm";
            this.TableForm.RowCount = 7;
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.Size = new System.Drawing.Size(599, 279);
            this.TableForm.TabIndex = 1;
            // 
            // FieldPort
            // 
            this.FieldPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FieldPort.Location = new System.Drawing.Point(132, 200);
            this.FieldPort.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldPort.Name = "FieldPort";
            this.FieldPort.Size = new System.Drawing.Size(98, 27);
            this.FieldPort.TabIndex = 10;
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.TableForm, 0, 2);
            this.TableMain.Controls.Add(this.menuStrip1, 0, 0);
            this.TableMain.Controls.Add(this.StatusBar, 0, 3);
            this.TableMain.Controls.Add(this.ListDatabases, 0, 1);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 4;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableMain.Size = new System.Drawing.Size(619, 547);
            this.TableMain.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(46, 16);
            this.MenuFile.Text = "File";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(224, 26);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // DBSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 547);
            this.Controls.Add(this.TableMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBSelection";
            this.Text = "DBSelection";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDisplay)).EndInit();
            this.ListContextMenu.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TableForm.ResumeLayout(false);
            this.TableForm.PerformLayout();
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider ErrorDisplay;
        private TableLayoutPanel TableMain;
        private TableLayoutPanel TableForm;
        private TextBox FieldUserName;
        private Label LabelUserName;
        private TextBox FieldDatabaseName;
        private Label LabelDatabase;
        private Label TitleAddEdit;
        private Label LabelHost;
        private TextBox FieldHost;
        private Label LabelPassword;
        private TextBox FieldPassword;
        private Label LabelPort;
        private TextBox FieldPort;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnAdd;
        private Button BtnClear;
        private Button BtnApply;
        private Button BtnCancel;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel LabelStatus;
        private ListView ListDatabases;
        private ColumnHeader ColDatabaseName;
        private ColumnHeader ColHost;
        private ColumnHeader ColUserName;
        private ColumnHeader ColPort;
        private ContextMenuStrip ListContextMenu;
        private ToolStripMenuItem ContextEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ContextDelete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuExit;
    }
}