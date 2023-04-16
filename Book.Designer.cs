namespace DatabaseConnection
{
    partial class Book
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookName = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxCategory = new Guna.UI.WinForms.GunaComboBox();
            this.comBoxAthorName = new Guna.UI.WinForms.GunaComboBox();
            this.comBoxBookType = new Guna.UI.WinForms.GunaComboBox();
            this.BookView = new Guna.UI.WinForms.GunaDataGridView();
            this.txtBookPages = new Guna.UI.WinForms.GunaNumeric();
            this.txtBookEdition = new Guna.UI.WinForms.GunaComboBox();
            this.txtPublisherName = new Guna.UI.WinForms.GunaTextBox();
            this.txtQtty = new Guna.UI.WinForms.GunaNumeric();
            this.label6 = new System.Windows.Forms.Label();
            this.butBrowsers = new Guna.UI.WinForms.GunaButton();
            this.bookPicture = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_display = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.BookView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Edition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Book Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book Type";
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
            this.btnAdd.Location = new System.Drawing.Point(290, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.registerBook);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Author Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BaseColor = System.Drawing.Color.White;
            this.txtBookName.BorderColor = System.Drawing.Color.Silver;
            this.txtBookName.BorderSize = 1;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtBookName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(153, 19);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.Radius = 5;
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(250, 39);
            this.txtBookName.TabIndex = 0;
            this.txtBookName.TextOffsetX = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Publisher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Book Name";
            // 
            // comBoxCategory
            // 
            this.comBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comBoxCategory.BaseColor = System.Drawing.Color.White;
            this.comBoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.comBoxCategory.BorderSize = 1;
            this.comBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCategory.FocusedColor = System.Drawing.Color.Red;
            this.comBoxCategory.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxCategory.FormattingEnabled = true;
            this.comBoxCategory.Items.AddRange(new object[] {
            "Select"});
            this.comBoxCategory.Location = new System.Drawing.Point(153, 76);
            this.comBoxCategory.Name = "comBoxCategory";
            this.comBoxCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxCategory.Radius = 5;
            this.comBoxCategory.Size = new System.Drawing.Size(250, 36);
            this.comBoxCategory.TabIndex = 1;
            // 
            // comBoxAthorName
            // 
            this.comBoxAthorName.BackColor = System.Drawing.Color.Transparent;
            this.comBoxAthorName.BaseColor = System.Drawing.Color.White;
            this.comBoxAthorName.BorderColor = System.Drawing.Color.Silver;
            this.comBoxAthorName.BorderSize = 1;
            this.comBoxAthorName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxAthorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxAthorName.FocusedColor = System.Drawing.Color.Red;
            this.comBoxAthorName.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxAthorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxAthorName.FormattingEnabled = true;
            this.comBoxAthorName.Items.AddRange(new object[] {
            "Select"});
            this.comBoxAthorName.Location = new System.Drawing.Point(153, 143);
            this.comBoxAthorName.Name = "comBoxAthorName";
            this.comBoxAthorName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxAthorName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxAthorName.Radius = 5;
            this.comBoxAthorName.Size = new System.Drawing.Size(250, 36);
            this.comBoxAthorName.TabIndex = 2;
            // 
            // comBoxBookType
            // 
            this.comBoxBookType.BackColor = System.Drawing.Color.Transparent;
            this.comBoxBookType.BaseColor = System.Drawing.Color.White;
            this.comBoxBookType.BorderColor = System.Drawing.Color.Silver;
            this.comBoxBookType.BorderSize = 1;
            this.comBoxBookType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBookType.FocusedColor = System.Drawing.Color.Red;
            this.comBoxBookType.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.comBoxBookType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comBoxBookType.FormattingEnabled = true;
            this.comBoxBookType.Items.AddRange(new object[] {
            "Select",
            "Basic",
            "intermediate",
            "Advanced",
            "Essential "});
            this.comBoxBookType.Location = new System.Drawing.Point(153, 264);
            this.comBoxBookType.Name = "comBoxBookType";
            this.comBoxBookType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBoxBookType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBoxBookType.Radius = 5;
            this.comBoxBookType.Size = new System.Drawing.Size(250, 36);
            this.comBoxBookType.TabIndex = 4;
            // 
            // BookView
            // 
            this.BookView.AllowUserToAddRows = false;
            this.BookView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BookView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookView.BackgroundColor = System.Drawing.Color.White;
            this.BookView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookView.ColumnHeadersHeight = 24;
            this.BookView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookView.EnableHeadersVisualStyles = false;
            this.BookView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.Location = new System.Drawing.Point(0, 401);
            this.BookView.Name = "BookView";
            this.BookView.ReadOnly = true;
            this.BookView.RowHeadersVisible = false;
            this.BookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookView.Size = new System.Drawing.Size(1149, 251);
            this.BookView.TabIndex = 48;
            this.BookView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BookView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookView.ThemeStyle.HeaderStyle.Height = 24;
            this.BookView.ThemeStyle.ReadOnly = true;
            this.BookView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookView.ThemeStyle.RowsStyle.Height = 22;
            this.BookView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.BookView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookView_CellContentClick);
            // 
            // txtBookPages
            // 
            this.txtBookPages.BackColor = System.Drawing.Color.Transparent;
            this.txtBookPages.BaseColor = System.Drawing.Color.White;
            this.txtBookPages.BorderColor = System.Drawing.Color.Silver;
            this.txtBookPages.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookPages.ButtonForeColor = System.Drawing.Color.White;
            this.txtBookPages.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPages.ForeColor = System.Drawing.Color.Black;
            this.txtBookPages.Location = new System.Drawing.Point(576, 28);
            this.txtBookPages.Maximum = ((long)(9999999));
            this.txtBookPages.Minimum = ((long)(0));
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Radius = 3;
            this.txtBookPages.Size = new System.Drawing.Size(250, 30);
            this.txtBookPages.TabIndex = 5;
            this.txtBookPages.Value = ((long)(30));
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.BackColor = System.Drawing.Color.Transparent;
            this.txtBookEdition.BaseColor = System.Drawing.Color.White;
            this.txtBookEdition.BorderColor = System.Drawing.Color.Silver;
            this.txtBookEdition.BorderSize = 1;
            this.txtBookEdition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBookEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBookEdition.FocusedColor = System.Drawing.Color.Red;
            this.txtBookEdition.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtBookEdition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookEdition.FormattingEnabled = true;
            this.txtBookEdition.Items.AddRange(new object[] {
            "Select",
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.txtBookEdition.Location = new System.Drawing.Point(576, 143);
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookEdition.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtBookEdition.Radius = 5;
            this.txtBookEdition.Size = new System.Drawing.Size(250, 36);
            this.txtBookEdition.TabIndex = 7;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.BackColor = System.Drawing.Color.Transparent;
            this.txtPublisherName.BaseColor = System.Drawing.Color.White;
            this.txtPublisherName.BorderColor = System.Drawing.Color.Silver;
            this.txtPublisherName.BorderSize = 1;
            this.txtPublisherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublisherName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPublisherName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtPublisherName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPublisherName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherName.Location = new System.Drawing.Point(153, 201);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.PasswordChar = '\0';
            this.txtPublisherName.Radius = 5;
            this.txtPublisherName.SelectedText = "";
            this.txtPublisherName.Size = new System.Drawing.Size(250, 39);
            this.txtPublisherName.TabIndex = 3;
            this.txtPublisherName.TextOffsetX = 5;
            // 
            // txtQtty
            // 
            this.txtQtty.BackColor = System.Drawing.Color.Transparent;
            this.txtQtty.BaseColor = System.Drawing.Color.White;
            this.txtQtty.BorderColor = System.Drawing.Color.Silver;
            this.txtQtty.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQtty.ButtonForeColor = System.Drawing.Color.White;
            this.txtQtty.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtty.ForeColor = System.Drawing.Color.Black;
            this.txtQtty.Location = new System.Drawing.Point(576, 86);
            this.txtQtty.Maximum = ((long)(9999999));
            this.txtQtty.Minimum = ((long)(0));
            this.txtQtty.Name = "txtQtty";
            this.txtQtty.Radius = 3;
            this.txtQtty.Size = new System.Drawing.Size(250, 30);
            this.txtQtty.TabIndex = 6;
            this.txtQtty.Value = ((long)(0));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity";
            // 
            // butBrowsers
            // 
            this.butBrowsers.AnimationHoverSpeed = 0.07F;
            this.butBrowsers.AnimationSpeed = 0.03F;
            this.butBrowsers.BackColor = System.Drawing.Color.Transparent;
            this.butBrowsers.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.butBrowsers.BorderColor = System.Drawing.Color.Black;
            this.butBrowsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butBrowsers.FocusedColor = System.Drawing.Color.Empty;
            this.butBrowsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.butBrowsers.ForeColor = System.Drawing.Color.White;
            this.butBrowsers.Image = null;
            this.butBrowsers.ImageSize = new System.Drawing.Size(20, 20);
            this.butBrowsers.Location = new System.Drawing.Point(933, 198);
            this.butBrowsers.Name = "butBrowsers";
            this.butBrowsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(76)))));
            this.butBrowsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butBrowsers.OnHoverForeColor = System.Drawing.Color.White;
            this.butBrowsers.OnHoverImage = null;
            this.butBrowsers.OnPressedColor = System.Drawing.Color.Black;
            this.butBrowsers.Radius = 2;
            this.butBrowsers.Size = new System.Drawing.Size(159, 47);
            this.butBrowsers.TabIndex = 8;
            this.butBrowsers.Text = "Browser";
            this.butBrowsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.butBrowsers.Click += new System.EventHandler(this.butBrowsers_Click);
            // 
            // bookPicture
            // 
            this.bookPicture.BaseColor = System.Drawing.Color.White;
            this.bookPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookPicture.ErrorImage = null;
            this.bookPicture.InitialImage = null;
            this.bookPicture.Location = new System.Drawing.Point(933, 28);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(159, 164);
            this.bookPicture.TabIndex = 54;
            this.bookPicture.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(918, 326);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 15;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(174, 43);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lbl_display
            // 
            this.lbl_display.Image = global::DatabaseConnection.Properties.Resources.images;
            this.lbl_display.Location = new System.Drawing.Point(258, 402);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(645, 242);
            this.lbl_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl_display.TabIndex = 57;
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
            this.btnDelete.Location = new System.Drawing.Point(616, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 47);
            this.btnDelete.TabIndex = 9;
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
            this.btnUpdate.Location = new System.Drawing.Point(452, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(139, 47);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextOffsetX = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.butBrowsers);
            this.Controls.Add(this.bookPicture);
            this.Controls.Add(this.txtQtty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBookPages);
            this.Controls.Add(this.BookView);
            this.Controls.Add(this.txtBookEdition);
            this.Controls.Add(this.comBoxBookType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comBoxAthorName);
            this.Controls.Add(this.comBoxCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox comBoxCategory;
        private Guna.UI.WinForms.GunaComboBox comBoxAthorName;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaComboBox comBoxBookType;
        private Guna.UI.WinForms.GunaDataGridView BookView;
        public Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaNumeric txtBookPages;
        private Guna.UI.WinForms.GunaComboBox txtBookEdition;
        private Guna.UI.WinForms.GunaTextBox txtPublisherName;
        private Guna.UI.WinForms.GunaNumeric txtQtty;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton butBrowsers;
        private Guna.UI.WinForms.GunaPictureBox bookPicture;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.PictureBox lbl_display;
    }
}