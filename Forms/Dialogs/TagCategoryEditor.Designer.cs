namespace SPDB_MKII.Forms.Dialogs
{
    partial class TagCategoryEditor
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
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.TableForm = new System.Windows.Forms.TableLayoutPanel();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.FieldLabel = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Abstract = new SPDB_MKII.UserControls.DialogAbstract();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TableMain.SuspendLayout();
            this.TableForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.TableForm, 0, 1);
            this.TableMain.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.TableMain.Controls.Add(this.Abstract, 0, 0);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 3;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.Size = new System.Drawing.Size(498, 181);
            this.TableMain.TabIndex = 0;
            // 
            // TableForm
            // 
            this.TableForm.ColumnCount = 2;
            this.TableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableForm.Controls.Add(this.LabelLabel, 0, 0);
            this.TableForm.Controls.Add(this.FieldLabel, 1, 0);
            this.TableForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableForm.Location = new System.Drawing.Point(20, 73);
            this.TableForm.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.TableForm.Name = "TableForm";
            this.TableForm.RowCount = 2;
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableForm.Size = new System.Drawing.Size(458, 42);
            this.TableForm.TabIndex = 0;
            // 
            // LabelLabel
            // 
            this.LabelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(3, 9);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(55, 20);
            this.LabelLabel.TabIndex = 0;
            this.LabelLabel.Text = "{Label}";
            // 
            // FieldLabel
            // 
            this.FieldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldLabel.Location = new System.Drawing.Point(64, 6);
            this.FieldLabel.Margin = new System.Windows.Forms.Padding(3, 6, 30, 6);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(364, 27);
            this.FieldLabel.TabIndex = 1;
            this.FieldLabel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FieldLabel_KeyUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.BtnOK);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 135);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnOK
            // 
            this.BtnOK.AutoSize = true;
            this.BtnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOK.Location = new System.Drawing.Point(406, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(49, 30);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Tag = "Style:Primary";
            this.BtnOK.Text = "{OK}";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.Handle_BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Location = new System.Drawing.Point(327, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(73, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "{Cancel}";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.Handle_BtnCancel_Click);
            // 
            // Abstract
            // 
            this.Abstract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abstract.AutoSize = true;
            this.Abstract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Abstract.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Abstract.Location = new System.Drawing.Point(0, 0);
            this.Abstract.Margin = new System.Windows.Forms.Padding(0);
            this.Abstract.Name = "Abstract";
            this.Abstract.Size = new System.Drawing.Size(498, 73);
            this.Abstract.TabIndex = 2;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // CategoryEditor
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(498, 181);
            this.Controls.Add(this.TableMain);
            this.Name = "CategoryEditor";
            this.Text = "{Tag category}";
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.TableForm.ResumeLayout(false);
            this.TableForm.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableMain;
        private TableLayoutPanel TableForm;
        private Label LabelLabel;
        private TextBox FieldLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnOK;
        private UserControls.DialogAbstract Abstract;
        private Button BtnCancel;
        private ErrorProvider ErrorProvider;
    }
}