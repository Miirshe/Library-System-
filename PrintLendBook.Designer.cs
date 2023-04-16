namespace DatabaseConnection
{
    partial class PrintLendBook
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.crViewerLendBook = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberId = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comStatement = new Guna.UI.WinForms.GunaComboBox();
            this.btnGenerate = new Guna.UI.WinForms.GunaButton();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // crViewerLendBook
            // 
            this.crViewerLendBook.ActiveViewIndex = -1;
            this.crViewerLendBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerLendBook.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crViewerLendBook.DisplayStatusBar = false;
            this.crViewerLendBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crViewerLendBook.Location = new System.Drawing.Point(0, 148);
            this.crViewerLendBook.Name = "crViewerLendBook";
            this.crViewerLendBook.ShowCloseButton = false;
            this.crViewerLendBook.ShowCopyButton = false;
            this.crViewerLendBook.ShowGroupTreeButton = false;
            this.crViewerLendBook.ShowLogo = false;
            this.crViewerLendBook.Size = new System.Drawing.Size(1151, 508);
            this.crViewerLendBook.TabIndex = 0;
            this.crViewerLendBook.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crViewerLendBook.ToolPanelWidth = 400;
            this.crViewerLendBook.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get More Informtion About Lended Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Browed Books Details";
            // 
            // txtMemberId
            // 
            this.txtMemberId.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberId.BaseColor = System.Drawing.Color.White;
            this.txtMemberId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMemberId.BorderSize = 1;
            this.txtMemberId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMemberId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMemberId.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtMemberId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberId.FormattingEnabled = true;
            this.txtMemberId.Items.AddRange(new object[] {
            "dgh"});
            this.txtMemberId.Location = new System.Drawing.Point(602, 52);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMemberId.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtMemberId.Radius = 5;
            this.txtMemberId.Size = new System.Drawing.Size(200, 36);
            this.txtMemberId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(604, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Member ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(26, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select Report Statement";
            // 
            // comStatement
            // 
            this.comStatement.BackColor = System.Drawing.Color.Transparent;
            this.comStatement.BaseColor = System.Drawing.Color.White;
            this.comStatement.BorderColor = System.Drawing.Color.DarkGray;
            this.comStatement.BorderSize = 1;
            this.comStatement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comStatement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStatement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comStatement.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comStatement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comStatement.FormattingEnabled = true;
            this.comStatement.Items.AddRange(new object[] {
            "All",
            "Custom"});
            this.comStatement.Location = new System.Drawing.Point(28, 107);
            this.comStatement.Name = "comStatement";
            this.comStatement.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comStatement.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comStatement.Radius = 5;
            this.comStatement.Size = new System.Drawing.Size(175, 31);
            this.comStatement.TabIndex = 59;
            this.comStatement.SelectedIndexChanged += new System.EventHandler(this.comStatement_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AnimationHoverSpeed = 0.07F;
            this.btnGenerate.AnimationSpeed = 0.03F;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BaseColor = System.Drawing.Color.Purple;
            this.btnGenerate.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerate.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = global::DatabaseConnection.Properties.Resources.stumbleupon_32px;
            this.btnGenerate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGenerate.Location = new System.Drawing.Point(915, 52);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Radius = 5;
            this.btnGenerate.Size = new System.Drawing.Size(138, 39);
            this.btnGenerate.TabIndex = 58;
            this.btnGenerate.Text = "  Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGenerate.TextOffsetX = 5;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::DatabaseConnection.Properties.Resources.delete_30px;
            this.pictureBoxClose.Location = new System.Drawing.Point(1113, 13);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 73;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Visible = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // PrintLendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.comStatement);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crViewerLendBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintLendBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintLendBook";
            this.Load += new System.EventHandler(this.PrintLendBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerLendBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaButton btnGenerate;
        private System.Windows.Forms.Label label6;
        public Guna.UI.WinForms.GunaComboBox txtMemberId;
        public System.Windows.Forms.PictureBox pictureBoxClose;
        public Guna.UI.WinForms.GunaComboBox comStatement;
    }
}