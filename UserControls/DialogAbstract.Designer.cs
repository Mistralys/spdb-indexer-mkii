namespace SPDB_MKII.UserControls
{
    partial class DialogAbstract
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.LabelAbstract = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTable.AutoSize = true;
            this.MainTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Controls.Add(this.LabelAbstract, 0, 0);
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(506, 70);
            this.MainTable.TabIndex = 0;
            // 
            // LabelAbstract
            // 
            this.LabelAbstract.AutoSize = true;
            this.LabelAbstract.Location = new System.Drawing.Point(20, 20);
            this.LabelAbstract.Margin = new System.Windows.Forms.Padding(20, 20, 20, 30);
            this.LabelAbstract.Name = "LabelAbstract";
            this.LabelAbstract.Size = new System.Drawing.Size(103, 20);
            this.LabelAbstract.TabIndex = 0;
            this.LabelAbstract.Text = "{Abstract text}";
            // 
            // DialogAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.MainTable);
            this.Name = "DialogAbstract";
            this.Size = new System.Drawing.Size(506, 150);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel MainTable;
        private Label LabelAbstract;
    }
}
