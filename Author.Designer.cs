namespace DatabaseConnection
{
    partial class Author
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.AuthorView = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.txtAuthorPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorExperience = new Guna.UI.WinForms.GunaTextBox();
            this.txtAuthorAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtAuthorName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.comBoxSex = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_display = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // AuthorView
            // 
            this.AuthorView.AllowUserToAddRows = false;
            this.AuthorView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.AuthorView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AuthorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuthorView.BackgroundColor = System.Drawing.Color.White;
            this.AuthorView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AuthorView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AuthorView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.AuthorView.ColumnHeadersHeight = 24;
            this.AuthorView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AuthorView.DefaultCellStyle = dataGridViewCellStyle12;
            this.AuthorView.EnableHeadersVisualStyles = false;
            this.AuthorView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AuthorView.Location = new System.Drawing.Point(1, 312);
            this.AuthorView.Name = "AuthorView";
            this.AuthorView.ReadOnly = true;
            this.AuthorView.RowHeadersVisible = false;
            this.AuthorView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthorView.Size = new System.Drawing.Size(1150, 346);
            this.AuthorView.TabIndex = 64;
            this.AuthorView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.AuthorView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AuthorView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AuthorView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AuthorView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AuthorView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AuthorView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AuthorView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AuthorView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AuthorView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AuthorView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AuthorView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AuthorView.ThemeStyle.HeaderStyle.Height = 24;
            this.AuthorView.ThemeStyle.ReadOnly = true;
            this.AuthorView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AuthorView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AuthorView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AuthorView.ThemeStyle.RowsStyle.Height = 22;
            this.AuthorView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AuthorView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AuthorView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickAuthor);
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
            this.btnAdd.Location = new System.Drawing.Point(307, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAuthorPhone
            // 
            this.txtAuthorPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthorPhone.BaseColor = System.Drawing.Color.White;
            this.txtAuthorPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtAuthorPhone.BorderSize = 1;
            this.txtAuthorPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAuthorPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAuthorPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorPhone.Location = new System.Drawing.Point(262, 125);
            this.txtAuthorPhone.MaxLength = 9;
            this.txtAuthorPhone.Name = "txtAuthorPhone";
            this.txtAuthorPhone.PasswordChar = '\0';
            this.txtAuthorPhone.Radius = 5;
            this.txtAuthorPhone.SelectedText = "";
            this.txtAuthorPhone.Size = new System.Drawing.Size(210, 39);
            this.txtAuthorPhone.TabIndex = 4;
            this.txtAuthorPhone.TextOffsetX = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Author Phone";
            // 
            // txtAuthorExperience
            // 
            this.txtAuthorExperience.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthorExperience.BaseColor = System.Drawing.Color.White;
            this.txtAuthorExperience.BorderColor = System.Drawing.Color.Silver;
            this.txtAuthorExperience.BorderSize = 1;
            this.txtAuthorExperience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorExperience.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAuthorExperience.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAuthorExperience.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorExperience.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorExperience.Location = new System.Drawing.Point(18, 124);
            this.txtAuthorExperience.Name = "txtAuthorExperience";
            this.txtAuthorExperience.PasswordChar = '\0';
            this.txtAuthorExperience.Radius = 5;
            this.txtAuthorExperience.SelectedText = "";
            this.txtAuthorExperience.Size = new System.Drawing.Size(210, 39);
            this.txtAuthorExperience.TabIndex = 3;
            this.txtAuthorExperience.TextOffsetX = 5;
            // 
            // txtAuthorAddress
            // 
            this.txtAuthorAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthorAddress.BaseColor = System.Drawing.Color.White;
            this.txtAuthorAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAuthorAddress.BorderSize = 1;
            this.txtAuthorAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAuthorAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAuthorAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorAddress.Location = new System.Drawing.Point(258, 36);
            this.txtAuthorAddress.Name = "txtAuthorAddress";
            this.txtAuthorAddress.PasswordChar = '\0';
            this.txtAuthorAddress.Radius = 5;
            this.txtAuthorAddress.SelectedText = "";
            this.txtAuthorAddress.Size = new System.Drawing.Size(210, 39);
            this.txtAuthorAddress.TabIndex = 1;
            this.txtAuthorAddress.TextOffsetX = 5;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthorName.BaseColor = System.Drawing.Color.White;
            this.txtAuthorName.BorderColor = System.Drawing.Color.Silver;
            this.txtAuthorName.BorderSize = 1;
            this.txtAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthorName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAuthorName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAuthorName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(18, 36);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.PasswordChar = '\0';
            this.txtAuthorName.Radius = 5;
            this.txtAuthorName.SelectedText = "";
            this.txtAuthorName.Size = new System.Drawing.Size(210, 39);
            this.txtAuthorName.TabIndex = 0;
            this.txtAuthorName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Experience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Author Name";
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
            this.btnDelete.Location = new System.Drawing.Point(626, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 7;
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
            this.btnUpdate.Location = new System.Drawing.Point(462, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Sex";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DatabaseConnection.Properties.Resources.Mobile_login_bro;
            this.gunaPictureBox1.Location = new System.Drawing.Point(928, 10);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(196, 208);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 95;
            this.gunaPictureBox1.TabStop = false;
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
            "Select",
            "Male",
            "Female"});
            this.comBoxSex.Location = new System.Drawing.Point(495, 36);
            this.comBoxSex.Name = "comBoxSex";
            this.comBoxSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxSex.Radius = 5;
            this.comBoxSex.Size = new System.Drawing.Size(210, 36);
            this.comBoxSex.TabIndex = 2;
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
            this.txtSearch.Location = new System.Drawing.Point(950, 250);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 15;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(174, 43);
            this.txtSearch.TabIndex = 97;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lbl_display
            // 
            this.lbl_display.Image = global::DatabaseConnection.Properties.Resources.images;
            this.lbl_display.Location = new System.Drawing.Point(258, 349);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(645, 242);
            this.lbl_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_display.TabIndex = 103;
            this.lbl_display.TabStop = false;
            this.lbl_display.Visible = false;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comBoxSex);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.AuthorView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAuthorPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthorExperience);
            this.Controls.Add(this.txtAuthorAddress);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Author";
            this.Text = "Author";
            this.Load += new System.EventHandler(this.Author_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaDataGridView AuthorView;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox txtAuthorPhone;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtAuthorExperience;
        private Guna.UI.WinForms.GunaTextBox txtAuthorAddress;
        private Guna.UI.WinForms.GunaTextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox comBoxSex;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.PictureBox lbl_display;
    }
}