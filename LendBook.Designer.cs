namespace DatabaseConnection
{
    partial class LendBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtReturnDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtIssueDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.comBoxName = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LendBookView = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberAddress = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comBoxMemberId = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.LendBookView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.txtReturnDate.BaseColor = System.Drawing.Color.White;
            this.txtReturnDate.BorderColor = System.Drawing.Color.Silver;
            this.txtReturnDate.BorderSize = 1;
            this.txtReturnDate.CustomFormat = null;
            this.txtReturnDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtReturnDate.FocusedColor = System.Drawing.Color.Red;
            this.txtReturnDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txtReturnDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtReturnDate.Location = new System.Drawing.Point(291, 200);
            this.txtReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtReturnDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReturnDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReturnDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtReturnDate.Radius = 5;
            this.txtReturnDate.Size = new System.Drawing.Size(225, 39);
            this.txtReturnDate.TabIndex = 7;
            this.txtReturnDate.Text = "1/1/2023";
            this.txtReturnDate.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.txtIssueDate.BaseColor = System.Drawing.Color.White;
            this.txtIssueDate.BorderColor = System.Drawing.Color.Silver;
            this.txtIssueDate.BorderSize = 1;
            this.txtIssueDate.CustomFormat = null;
            this.txtIssueDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtIssueDate.FocusedColor = System.Drawing.Color.Red;
            this.txtIssueDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txtIssueDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtIssueDate.Location = new System.Drawing.Point(18, 200);
            this.txtIssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtIssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtIssueDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIssueDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIssueDate.OnPressedColor = System.Drawing.Color.Black;
            this.txtIssueDate.Radius = 5;
            this.txtIssueDate.Size = new System.Drawing.Size(225, 39);
            this.txtIssueDate.TabIndex = 6;
            this.txtIssueDate.Text = "1/1/2023";
            this.txtIssueDate.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // comBoxName
            // 
            this.comBoxName.BackColor = System.Drawing.Color.Transparent;
            this.comBoxName.BaseColor = System.Drawing.Color.White;
            this.comBoxName.BorderColor = System.Drawing.Color.Silver;
            this.comBoxName.BorderSize = 1;
            this.comBoxName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxName.FocusedColor = System.Drawing.Color.Red;
            this.comBoxName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxName.FormattingEnabled = true;
            this.comBoxName.Items.AddRange(new object[] {
            "dgh"});
            this.comBoxName.Location = new System.Drawing.Point(562, 115);
            this.comBoxName.Name = "comBoxName";
            this.comBoxName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxName.Radius = 5;
            this.comBoxName.Size = new System.Drawing.Size(225, 36);
            this.comBoxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Book Name";
            // 
            // LendBookView
            // 
            this.LendBookView.AllowUserToAddRows = false;
            this.LendBookView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LendBookView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LendBookView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LendBookView.BackgroundColor = System.Drawing.Color.White;
            this.LendBookView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LendBookView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LendBookView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LendBookView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LendBookView.ColumnHeadersHeight = 24;
            this.LendBookView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LendBookView.DefaultCellStyle = dataGridViewCellStyle3;
            this.LendBookView.EnableHeadersVisualStyles = false;
            this.LendBookView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LendBookView.Location = new System.Drawing.Point(0, 392);
            this.LendBookView.Name = "LendBookView";
            this.LendBookView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LendBookView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LendBookView.RowHeadersVisible = false;
            this.LendBookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LendBookView.Size = new System.Drawing.Size(1149, 265);
            this.LendBookView.TabIndex = 54;
            this.LendBookView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LendBookView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LendBookView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LendBookView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LendBookView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LendBookView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LendBookView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LendBookView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LendBookView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LendBookView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LendBookView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendBookView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LendBookView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LendBookView.ThemeStyle.HeaderStyle.Height = 24;
            this.LendBookView.ThemeStyle.ReadOnly = true;
            this.LendBookView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LendBookView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LendBookView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendBookView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LendBookView.ThemeStyle.RowsStyle.Height = 22;
            this.LendBookView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LendBookView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LendBookView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LendBookCellClick);
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
            this.btnAdd.Location = new System.Drawing.Point(216, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Return Date";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberName.BaseColor = System.Drawing.Color.White;
            this.txtMemberName.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberName.BorderSize = 1;
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberName.Enabled = false;
            this.txtMemberName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMemberName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(289, 36);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PasswordChar = '\0';
            this.txtMemberName.Radius = 5;
            this.txtMemberName.SelectedText = "";
            this.txtMemberName.Size = new System.Drawing.Size(225, 39);
            this.txtMemberName.TabIndex = 1;
            this.txtMemberName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Issue Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Member Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Member ID";
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberAddress.BaseColor = System.Drawing.Color.White;
            this.txtMemberAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberAddress.BorderSize = 1;
            this.txtMemberAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberAddress.Enabled = false;
            this.txtMemberAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberAddress.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMemberAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberAddress.Location = new System.Drawing.Point(562, 38);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.PasswordChar = '\0';
            this.txtMemberAddress.Radius = 5;
            this.txtMemberAddress.SelectedText = "";
            this.txtMemberAddress.Size = new System.Drawing.Size(225, 39);
            this.txtMemberAddress.TabIndex = 2;
            this.txtMemberAddress.TextOffsetX = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Member Address";
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberPhone.BaseColor = System.Drawing.Color.White;
            this.txtMemberPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberPhone.BorderSize = 1;
            this.txtMemberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberPhone.Enabled = false;
            this.txtMemberPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberPhone.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMemberPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPhone.Location = new System.Drawing.Point(22, 115);
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.PasswordChar = '\0';
            this.txtMemberPhone.Radius = 5;
            this.txtMemberPhone.SelectedText = "";
            this.txtMemberPhone.Size = new System.Drawing.Size(225, 39);
            this.txtMemberPhone.TabIndex = 3;
            this.txtMemberPhone.TextOffsetX = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Member Phone";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtMemberEmail.BaseColor = System.Drawing.Color.White;
            this.txtMemberEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtMemberEmail.BorderSize = 1;
            this.txtMemberEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberEmail.Enabled = false;
            this.txtMemberEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMemberEmail.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtMemberEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMemberEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberEmail.Location = new System.Drawing.Point(291, 115);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.PasswordChar = '\0';
            this.txtMemberEmail.Radius = 5;
            this.txtMemberEmail.SelectedText = "";
            this.txtMemberEmail.Size = new System.Drawing.Size(225, 39);
            this.txtMemberEmail.TabIndex = 4;
            this.txtMemberEmail.TextOffsetX = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Member Email";
            // 
            // comBoxMemberId
            // 
            this.comBoxMemberId.BackColor = System.Drawing.Color.Transparent;
            this.comBoxMemberId.BaseColor = System.Drawing.Color.White;
            this.comBoxMemberId.BorderColor = System.Drawing.Color.Silver;
            this.comBoxMemberId.BorderSize = 1;
            this.comBoxMemberId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comBoxMemberId.FocusedBaseColor = System.Drawing.Color.White;
            this.comBoxMemberId.FocusedBorderColor = System.Drawing.Color.Red;
            this.comBoxMemberId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMemberId.Location = new System.Drawing.Point(22, 36);
            this.comBoxMemberId.Name = "comBoxMemberId";
            this.comBoxMemberId.PasswordChar = '\0';
            this.comBoxMemberId.Radius = 5;
            this.comBoxMemberId.SelectedText = "";
            this.comBoxMemberId.Size = new System.Drawing.Size(225, 39);
            this.comBoxMemberId.TabIndex = 1;
            this.comBoxMemberId.TextOffsetX = 5;
            this.comBoxMemberId.TextChanged += new System.EventHandler(this.TxtChangedID);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DatabaseConnection.Properties.Resources.life_3d;
            this.gunaPictureBox1.Location = new System.Drawing.Point(871, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(268, 255);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 55;
            this.gunaPictureBox1.TabStop = false;
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
            this.btnDelete.Location = new System.Drawing.Point(544, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 10;
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
            this.btnUpdate.Location = new System.Drawing.Point(384, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMemberPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMemberAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.comBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.LendBookView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxMemberId);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LendBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.LendBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LendBookView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDateTimePicker txtReturnDate;
        private Guna.UI.WinForms.GunaDateTimePicker txtIssueDate;
        private Guna.UI.WinForms.GunaComboBox comBoxName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView LendBookView;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaTextBox txtMemberAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtMemberEmail;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtMemberPhone;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox comBoxMemberId;

    }
}