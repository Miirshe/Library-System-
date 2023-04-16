namespace DatabaseConnection
{
    partial class UserProfile
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserPhoneNo = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxSex = new Guna.UI.WinForms.GunaComboBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.butBrowsers = new Guna.UI.WinForms.GunaButton();
            this.userPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseConnection.Properties.Resources.multiply_26px;
            this.pictureBox1.Location = new System.Drawing.Point(364, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUserPhoneNo
            // 
            this.txtUserPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.txtUserPhoneNo.BaseColor = System.Drawing.Color.White;
            this.txtUserPhoneNo.BorderColor = System.Drawing.Color.Silver;
            this.txtUserPhoneNo.BorderSize = 1;
            this.txtUserPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPhoneNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserPhoneNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUserPhoneNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhoneNo.Location = new System.Drawing.Point(12, 420);
            this.txtUserPhoneNo.MaxLength = 9;
            this.txtUserPhoneNo.Name = "txtUserPhoneNo";
            this.txtUserPhoneNo.PasswordChar = '\0';
            this.txtUserPhoneNo.Radius = 10;
            this.txtUserPhoneNo.SelectedText = "";
            this.txtUserPhoneNo.Size = new System.Drawing.Size(374, 39);
            this.txtUserPhoneNo.TabIndex = 3;
            this.txtUserPhoneNo.TextOffsetX = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone No";
            // 
            // comBoxSex
            // 
            this.comBoxSex.BackColor = System.Drawing.Color.Transparent;
            this.comBoxSex.BaseColor = System.Drawing.Color.White;
            this.comBoxSex.BorderColor = System.Drawing.Color.Silver;
            this.comBoxSex.BorderSize = 1;
            this.comBoxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSex.FocusedColor = System.Drawing.Color.Red;
            this.comBoxSex.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxSex.FormattingEnabled = true;
            this.comBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comBoxSex.Location = new System.Drawing.Point(12, 323);
            this.comBoxSex.Name = "comBoxSex";
            this.comBoxSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxSex.Radius = 10;
            this.comBoxSex.Size = new System.Drawing.Size(374, 36);
            this.comBoxSex.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 236);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(374, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextOffsetX = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Purple;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DatabaseConnection.Properties.Resources.icons8_delete_25px;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(227, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(159, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::DatabaseConnection.Properties.Resources.icons8_update_user_25px;
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(16, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(156, 47);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // butBrowsers
            // 
            this.butBrowsers.AnimationHoverSpeed = 0.07F;
            this.butBrowsers.AnimationSpeed = 0.03F;
            this.butBrowsers.BackColor = System.Drawing.Color.Transparent;
            this.butBrowsers.BaseColor = System.Drawing.Color.Orange;
            this.butBrowsers.BorderColor = System.Drawing.Color.Black;
            this.butBrowsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butBrowsers.FocusedColor = System.Drawing.Color.Empty;
            this.butBrowsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.butBrowsers.ForeColor = System.Drawing.Color.White;
            this.butBrowsers.Image = null;
            this.butBrowsers.ImageSize = new System.Drawing.Size(20, 20);
            this.butBrowsers.Location = new System.Drawing.Point(126, 172);
            this.butBrowsers.Name = "butBrowsers";
            this.butBrowsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.butBrowsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butBrowsers.OnHoverForeColor = System.Drawing.Color.White;
            this.butBrowsers.OnHoverImage = null;
            this.butBrowsers.OnPressedColor = System.Drawing.Color.Black;
            this.butBrowsers.Radius = 2;
            this.butBrowsers.Size = new System.Drawing.Size(159, 47);
            this.butBrowsers.TabIndex = 0;
            this.butBrowsers.Text = "Browser";
            this.butBrowsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.butBrowsers.Click += new System.EventHandler(this.butBrowsers_Click);
            // 
            // userPicture
            // 
            this.userPicture.BaseColor = System.Drawing.Color.White;
            this.userPicture.ErrorImage = null;
            this.userPicture.InitialImage = null;
            this.userPicture.Location = new System.Drawing.Point(126, 8);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(155, 158);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 28;
            this.userPicture.TabStop = false;
            this.userPicture.UseTransfarantBackground = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(410, 598);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.butBrowsers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUserPhoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comBoxSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtUserPhoneNo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox comBoxSex;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaCirclePictureBox userPicture;
        private Guna.UI.WinForms.GunaButton butBrowsers;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}