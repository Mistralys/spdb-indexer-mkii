namespace SPDB_MKII.Forms.Dialogs
{
    partial class TextPrompt
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
            this.FieldInput = new System.Windows.Forms.TextBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ErrorDisplay = new System.Windows.Forms.ErrorProvider(this.components);
            this.TableMain.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.LabelMessage, 0, 0);
            this.TableMain.Controls.Add(this.FieldInput, 0, 1);
            this.TableMain.Controls.Add(this.ButtonsPanel, 0, 2);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 3;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Size = new System.Drawing.Size(800, 182);
            this.TableMain.TabIndex = 0;
            // 
            // FieldInput
            // 
            this.FieldInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldInput.Location = new System.Drawing.Point(30, 80);
            this.FieldInput.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.FieldInput.Name = "FieldInput";
            this.FieldInput.Size = new System.Drawing.Size(740, 27);
            this.FieldInput.TabIndex = 1;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(30, 20);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(30, 20, 30, 30);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(106, 20);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "{Message text}";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonsPanel.Controls.Add(this.BtnOK);
            this.ButtonsPanel.Controls.Add(this.BtnCancel);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 143);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonsPanel.Size = new System.Drawing.Size(794, 36);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.AutoSize = true;
            this.BtnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOK.Location = new System.Drawing.Point(742, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(49, 30);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Tag = "Style:Primary";
            this.BtnOK.Text = "{OK}";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Location = new System.Drawing.Point(663, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(73, 30);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "{Cancel}";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ErrorDisplay
            // 
            this.ErrorDisplay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDisplay.ContainerControl = this;
            // 
            // TextPrompt
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(800, 182);
            this.Controls.Add(this.TableMain);
            this.Name = "TextPrompt";
            this.Text = "{Text input}";
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableMain;
        private Label LabelMessage;
        private TextBox FieldInput;
        private FlowLayoutPanel ButtonsPanel;
        private Button BtnOK;
        private Button BtnCancel;
        private ErrorProvider ErrorDisplay;
    }
}