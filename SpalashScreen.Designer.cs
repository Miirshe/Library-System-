namespace DatabaseConnection
{
    partial class SpalashScreen
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
            this.gunnaCircleRight = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.gunnaLeftCircle = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaProgressBarCenter = new Guna.UI.WinForms.GunaProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunnaCircleRight
            // 
            this.gunnaCircleRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunnaCircleRight.Location = new System.Drawing.Point(0, 23);
            this.gunnaCircleRight.Name = "gunnaCircleRight";
            this.gunnaCircleRight.ProgressColor = System.Drawing.Color.Orange;
            this.gunnaCircleRight.Size = new System.Drawing.Size(145, 138);
            this.gunnaCircleRight.TabIndex = 2;
            // 
            // gunnaLeftCircle
            // 
            this.gunnaLeftCircle.AnimationSpeed = 0.6F;
            this.gunnaLeftCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunnaLeftCircle.BaseColor = System.Drawing.Color.White;
            this.gunnaLeftCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunnaLeftCircle.ForeColor = System.Drawing.Color.Navy;
            this.gunnaLeftCircle.IdleColor = System.Drawing.Color.Orange;
            this.gunnaLeftCircle.IdleOffset = 20;
            this.gunnaLeftCircle.Image = null;
            this.gunnaLeftCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.gunnaLeftCircle.Location = new System.Drawing.Point(748, 23);
            this.gunnaLeftCircle.Name = "gunnaLeftCircle";
            this.gunnaLeftCircle.ProgressMaxColor = System.Drawing.Color.Orange;
            this.gunnaLeftCircle.ProgressMinColor = System.Drawing.Color.Orange;
            this.gunnaLeftCircle.ProgressOffset = 20;
            this.gunnaLeftCircle.Size = new System.Drawing.Size(151, 153);
            this.gunnaLeftCircle.TabIndex = 3;
            this.gunnaLeftCircle.UseProgressPercentText = true;
            this.gunnaLeftCircle.Value = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaProgressBarCenter
            // 
            this.gunaProgressBarCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaProgressBarCenter.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.gunaProgressBarCenter.IdleColor = System.Drawing.Color.Empty;
            this.gunaProgressBarCenter.Location = new System.Drawing.Point(193, 535);
            this.gunaProgressBarCenter.Name = "gunaProgressBarCenter";
            this.gunaProgressBarCenter.ProgressMaxColor = System.Drawing.Color.Orange;
            this.gunaProgressBarCenter.ProgressMinColor = System.Drawing.Color.Orange;
            this.gunaProgressBarCenter.Size = new System.Drawing.Size(526, 22);
            this.gunaProgressBarCenter.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseConnection.Properties.Resources.Library_pana;
            this.pictureBox1.Location = new System.Drawing.Point(-75, -89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 731);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Orange;
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Enabled = false;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(181, 525);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(549, 42);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::DatabaseConnection.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(897, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // SpalashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 636);
            this.Controls.Add(this.gunnaCircleRight);
            this.Controls.Add(this.gunnaLeftCircle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gunaProgressBarCenter);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpalashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpalashScreen";
            this.Load += new System.EventHandler(this.SpalashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCircleProgressBar gunnaLeftCircle;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunnaCircleRight;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBarCenter;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}