namespace DatabaseConnection
{
    partial class AllReports
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.btbBooks = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Navy;
            this.panelTop.Controls.Add(this.btnMembers);
            this.panelTop.Controls.Add(this.btnLendBook);
            this.panelTop.Controls.Add(this.btbBooks);
            this.panelTop.Controls.Add(this.btnAuthor);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1151, 34);
            this.panelTop.TabIndex = 0;
            // 
            // btnMembers
            // 
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(759, 0);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(247, 34);
            this.btnMembers.TabIndex = 11;
            this.btnMembers.Text = "           Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Visible = false;
            // 
            // btnLendBook
            // 
            this.btnLendBook.FlatAppearance.BorderSize = 0;
            this.btnLendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLendBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLendBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendBook.Location = new System.Drawing.Point(280, 0);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLendBook.Size = new System.Drawing.Size(247, 34);
            this.btnLendBook.TabIndex = 11;
            this.btnLendBook.Text = "           Lend Books";
            this.btnLendBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLendBook.UseVisualStyleBackColor = true;
            this.btnLendBook.Click += new System.EventHandler(this.btnLendBook_Click);
            // 
            // btbBooks
            // 
            this.btbBooks.FlatAppearance.BorderSize = 0;
            this.btbBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btbBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbBooks.Location = new System.Drawing.Point(572, 0);
            this.btbBooks.Name = "btbBooks";
            this.btbBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btbBooks.Size = new System.Drawing.Size(247, 34);
            this.btbBooks.TabIndex = 10;
            this.btbBooks.Text = "           Books";
            this.btbBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbBooks.UseVisualStyleBackColor = true;
            this.btbBooks.Visible = false;
            // 
            // btnAuthor
            // 
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(-8, 0);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAuthor.Size = new System.Drawing.Size(247, 34);
            this.btnAuthor.TabIndex = 9;
            this.btnAuthor.Text = "           Author";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(2, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1149, 622);
            this.panelContainer.TabIndex = 1;
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 656);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllReports";
            this.Load += new System.EventHandler(this.AllReports_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btbBooks;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Panel panelContainer;
    }
}