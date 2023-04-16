namespace DatabaseConnection
{
    partial class PrintAuthorReport
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
            this.comStatement = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorName = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
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
            this.comStatement.Location = new System.Drawing.Point(-13, 103);
            this.comStatement.Name = "comStatement";
            this.comStatement.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comStatement.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comStatement.Radius = 5;
            this.comStatement.Size = new System.Drawing.Size(175, 31);
            this.comStatement.TabIndex = 70;
            this.comStatement.TextChanged += new System.EventHandler(this.comStatement_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(646, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Author Name";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthorName.BaseColor = System.Drawing.Color.White;
            this.txtAuthorName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAuthorName.BorderSize = 1;
            this.txtAuthorName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAuthorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAuthorName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAuthorName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtAuthorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorName.FormattingEnabled = true;
            this.txtAuthorName.Items.AddRange(new object[] {
            "dgh"});
            this.txtAuthorName.Location = new System.Drawing.Point(644, 45);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAuthorName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtAuthorName.Radius = 5;
            this.txtAuthorName.Size = new System.Drawing.Size(249, 36);
            this.txtAuthorName.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(-15, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Select Report Statement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Author\'s Books Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "Get More Informtion About Lended Authors";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::DatabaseConnection.Properties.Resources.delete_30px;
            this.pictureBoxClose.Location = new System.Drawing.Point(1110, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 72;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Visible = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
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
            this.btnGenerate.Location = new System.Drawing.Point(963, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Radius = 5;
            this.btnGenerate.Size = new System.Drawing.Size(138, 39);
            this.btnGenerate.TabIndex = 69;
            this.btnGenerate.Text = "  Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGenerate.TextOffsetX = 5;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // PrintAuthorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 620);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.comStatement);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintAuthorReport";
            this.Text = "PrintAuthorReport";
            this.Load += new System.EventHandler(this.PrintAuthorReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaButton btnGenerate;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaComboBox txtAuthorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //public CrystalDecisions.Windows.Forms.CrystalReportViewer crAuthorReports;
        public Guna.UI.WinForms.GunaComboBox comStatement;
        public System.Windows.Forms.PictureBox pictureBoxClose;

    }
}