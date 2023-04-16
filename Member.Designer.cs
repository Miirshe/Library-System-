namespace DatabaseConnection
{
    partial class Member
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.MemberView = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBailedphone = new Guna.UI.WinForms.GunaTextBox();
            this.txtMemberAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtMemberName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBailedName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.txtMemberEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberPhone = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_display = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // MemberView
            // 
            this.MemberView.AllowUserToAddRows = false;
            this.MemberView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MemberView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberView.BackgroundColor = System.Drawing.Color.White;
            this.MemberView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MemberView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MemberView.ColumnHeadersHeight = 24;
            this.MemberView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberView.EnableHeadersVisualStyles = false;
            this.MemberView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberView.Location = new System.Drawing.Point(1, 376);
            this.MemberView.Name = "MemberView";
            this.MemberView.ReadOnly = true;
            this.MemberView.RowHeadersVisible = false;
            this.MemberView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberView.Size = new System.Drawing.Size(1149, 282);
            this.MemberView.TabIndex = 20;
            this.MemberView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.MemberView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MemberView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MemberView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MemberView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MemberView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MemberView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MemberView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MemberView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MemberView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MemberView.ThemeStyle.HeaderStyle.Height = 24;
            this.MemberView.ThemeStyle.ReadOnly = true;
            this.MemberView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MemberView.ThemeStyle.RowsStyle.Height = 22;
            this.MemberView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MemberView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberCellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(205, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Member Phone";
            // 
            // txtBailedphone
            // 
            this.txtBailedphone.BackColor = System.Drawing.Color.Transparent;
            this.txtBailedphone.BaseColor = System.Drawing.Color.White;
            this.txtBailedphone.BorderColor = System.Drawing.Color.Silver;
            this.txtBailedphone.BorderSize = 1;
            this.txtBailedphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBailedphone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBailedphone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBailedphone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBailedphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBailedphone.Location = new System.Drawing.Point(296, 117);
            this.txtBailedphone.MaxLength = 9;
            this.txtBailedphone.Name = "txtBailedphone";
            this.txtBailedphone.PasswordChar = '\0';
            this.txtBailedphone.Radius = 5;
            this.txtBailedphone.SelectedText = "";
            this.txtBailedphone.Size = new System.Drawing.Size(245, 39);
            this.txtBailedphone.TabIndex = 4;
            this.txtBailedphone.TextOffsetX = 5;
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberAddress.BaseColor = System.Drawing.Color.White;
            this.txtMemberAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberAddress.BorderSize = 1;
            this.txtMemberAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMemberAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberAddress.Location = new System.Drawing.Point(296, 39);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.PasswordChar = '\0';
            this.txtMemberAddress.Radius = 5;
            this.txtMemberAddress.SelectedText = "";
            this.txtMemberAddress.Size = new System.Drawing.Size(245, 39);
            this.txtMemberAddress.TabIndex = 1;
            this.txtMemberAddress.TextOffsetX = 5;
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberName.BaseColor = System.Drawing.Color.White;
            this.txtMemberName.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberName.BorderSize = 1;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMemberName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(18, 39);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PasswordChar = '\0';
            this.txtMemberName.Radius = 5;
            this.txtMemberName.SelectedText = "";
            this.txtMemberName.Size = new System.Drawing.Size(245, 39);
            this.txtMemberName.TabIndex = 0;
            this.txtMemberName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bailed Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Member Name";
            // 
            // txtBailedName
            // 
            this.txtBailedName.BackColor = System.Drawing.Color.Transparent;
            this.txtBailedName.BaseColor = System.Drawing.Color.White;
            this.txtBailedName.BorderColor = System.Drawing.Color.Silver;
            this.txtBailedName.BorderSize = 1;
            this.txtBailedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBailedName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBailedName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBailedName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBailedName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBailedName.Location = new System.Drawing.Point(18, 117);
            this.txtBailedName.Name = "txtBailedName";
            this.txtBailedName.PasswordChar = '\0';
            this.txtBailedName.Radius = 5;
            this.txtBailedName.SelectedText = "";
            this.txtBailedName.Size = new System.Drawing.Size(245, 39);
            this.txtBailedName.TabIndex = 3;
            this.txtBailedName.TextOffsetX = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bailed Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(864, 260);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 15;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(202, 43);
            this.txtSearch.TabIndex = 99;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 15;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberEmail.BaseColor = System.Drawing.Color.White;
            this.txtMemberEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberEmail.BorderSize = 1;
            this.txtMemberEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMemberEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberEmail.Location = new System.Drawing.Point(573, 39);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.PasswordChar = '\0';
            this.txtMemberEmail.Radius = 5;
            this.txtMemberEmail.SelectedText = "";
            this.txtMemberEmail.Size = new System.Drawing.Size(245, 39);
            this.txtMemberEmail.TabIndex = 2;
            this.txtMemberEmail.TextOffsetX = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 101;
            this.label6.Text = "Member Email";
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberPhone.BaseColor = System.Drawing.Color.White;
            this.txtMemberPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberPhone.BorderSize = 1;
            this.txtMemberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMemberPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPhone.Location = new System.Drawing.Point(573, 117);
            this.txtMemberPhone.MaxLength = 9;
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.PasswordChar = '\0';
            this.txtMemberPhone.Radius = 5;
            this.txtMemberPhone.SelectedText = "";
            this.txtMemberPhone.Size = new System.Drawing.Size(245, 39);
            this.txtMemberPhone.TabIndex = 5;
            this.txtMemberPhone.TextOffsetX = 5;
            // 
            // lbl_display
            // 
            this.lbl_display.Image = global::DatabaseConnection.Properties.Resources.images;
            this.lbl_display.Location = new System.Drawing.Point(252, 388);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(645, 242);
            this.lbl_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_display.TabIndex = 102;
            this.lbl_display.TabStop = false;
            this.lbl_display.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(524, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextOffsetX = 5;
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
            this.btnUpdate.Location = new System.Drawing.Point(360, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DatabaseConnection.Properties.Resources.Std;
            this.gunaPictureBox1.Location = new System.Drawing.Point(814, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(287, 278);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 21;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.txtMemberPhone);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBailedName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.MemberView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBailedphone);
            this.Controls.Add(this.txtMemberAddress);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView MemberView;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtBailedphone;
        private Guna.UI.WinForms.GunaTextBox txtMemberAddress;
        private Guna.UI.WinForms.GunaTextBox txtMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtBailedName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaTextBox txtMemberPhone;
        private Guna.UI.WinForms.GunaTextBox txtMemberEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.PictureBox lbl_display;
    }
}