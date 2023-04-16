using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class myDash : Form
    {
        public static string role;
        public static string user; 
        
        public myDash()
        {
            InitializeComponent();
        }

        public myDash(string username , string type,Image img)
        {
            InitializeComponent();
            label_user.Text = username.ToUpper();
            lblType.Text = type.ToUpper();
            user = label_user.Text;
            role = lblType.Text;
            userProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfile.Image = img;
           
        }
        public myDash(string userName)
        {
            InitializeComponent();
            label_user.Text = userName.ToUpper();
           // lblType.Text = type.ToUpper();
            user = label_user.Text;
            role = lblType.Text;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
   
           

        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            UserLogin usr = new UserLogin();
            usr.Show();
            this.Hide();
            //Application.Exit();
        }

       
      

       

        private void brnUsers_Click_1(object sender, EventArgs e)
        {
            openFrom(new RegisterUsers());
            btnProfile.Visible = false;
            loadUsers();
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            btnProfile.Visible = false;
            RegisterUsers register = new RegisterUsers();
            register.ShowDialog();

        }

        private void myDash_Load(object sender, EventArgs e)
        {
          
            if (lblType.Text != "ADMIN")
            {
                btnUsers.Visible = false;
                btnLendBook.Visible = false;
                btnPublisher.Visible = false;
                btnCategory.Visible = false;
                btnProfile.Visible = false;

                openFrom(new UserDash());

            }
            else
            {
                openFrom(new Dash());
                btnProfile.Visible = false;
            }
            btnPublisher.Visible = false;
        }

        public void loadUsers()
        {
            panel3.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Text = "             User Manager".ToUpper();
           
            //userInfo usrs = new userInfo();
            
        }

        public void loadDash()
        {
            panel3.BackColor = Color.LightSeaGreen;
            label1.ForeColor = Color.White;
            label1.Text = "JAMHURIYA UNIVERSITY | LIBRARY SYSTEM".ToUpper();

            //userInfo usrs = new userInfo();

        }
        
         public void openFrom(object Form){
             if(this.panelContainer.Controls.Count > 0)
                 this.panelContainer.Controls.RemoveAt(0);
             Form frm = Form as Form;
             frm.TopLevel = false;
             this.panelContainer.Controls.Add(frm);
             frm.Dock = DockStyle.None;
             this.panelContainer.Tag = frm; 
             frm.Show();

        }

         private void btnDashboard_Click(object sender, EventArgs e)
         {

             if (myDash.role != "ADMIN")
             {
                 loadDash();
                 openFrom(new UserDash());
                 btnProfile.Visible = true;
             }
             else
             {
                 loadDash();
                 openFrom(new Dash());
                 btnProfile.Visible = true;
             }

            
         }

         private void panel3_Paint(object sender, PaintEventArgs e)
         {

         }

         private void btnBook_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             loadBook();
             openFrom(new Book());
         }

         private void loadBook()
         {
             panel3.BackColor = Color.Brown;
             label1.ForeColor = Color.White;
             label1.Text = "             Book Manager".ToUpper();
         }

         private void btnMember_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             openFrom(new Member());
             LoadMember();
         }

         private void LoadMember()
         {
             panel3.BackColor = Color.Navy;
             label1.ForeColor = Color.White;
             label1.Text = "             Member Manager".ToUpper();
         }

         private void btnLendBook_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             loadLendBook();
             openFrom(new LendBook());
         }

         private void loadLendBook()
         {
             panel3.BackColor = Color.SaddleBrown;
             label1.ForeColor = Color.White;
             label1.Text = "        Lend Book  Manager".ToUpper();
         }

         private void btnReturnBook_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             loadReturnBook();
             openFrom(new ReturnBook());
         }

         private void loadReturnBook()
         {
             panel3.BackColor = Color.RosyBrown;
             label1.ForeColor = Color.White;
             label1.Text = "        Return Book  Manager".ToUpper();
         }

         private void btnLogout_Click(object sender, EventArgs e)
         {
             openFrom(new AllReports());
           
             label1.Text = "JAMHURIYA UNIVERSITY | LIBRARY SYSTEM".ToUpper();
             panel3.BackColor = Color.DarkBlue;
             
         }

         private void btnAuthor_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             openFrom(new Author());
             loadAuthor();
         }

         private void loadAuthor()
         {
             panel3.BackColor = Color.Maroon;
             label1.ForeColor = Color.White;
             label1.Text = "        Author Manager".ToUpper();
         }

         private void btnPublisher_Click(object sender, EventArgs e)
         {
             btnProfile.Visible = false;
             loadPublisher();
             openFrom(new Publisher());
         }

         private void loadPublisher()
         {
             panel3.BackColor = Color.DarkOliveGreen;
             label1.ForeColor = Color.White;
             label1.Text = "        Publisher Manager".ToUpper();
             
         }

         private void btnCategory_Click(object sender, EventArgs e)
         {
             openFrom(new Category());
             btnProfile.Visible = false;
             loadCategoty();
         }

         private void loadCategoty()
         {
             panel3.BackColor = Color.DarkBlue;
             label1.ForeColor = Color.White;
             label1.Text = "        Category Manager".ToUpper();
         }

         private void btnProfile_Click(object sender, EventArgs e)
         {
             //UserProfile usr = new UserProfile();
             //usr.ShowDialog();

         }

         private void userProfile_Click(object sender, EventArgs e)
         {
            
         }

         private void editToolStripMenuItem_Click(object sender, EventArgs e)
         {
             UserProfile usr = new UserProfile();
             usr.ShowDialog();

         }

         private void changeToolStripMenuItem_Click(object sender, EventArgs e)
         {
             ForgetPassword fg = new ForgetPassword();
             fg.ShowDialog();
         }

         private void panelContainer_Paint(object sender, PaintEventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
             UserLogin userLogin = new UserLogin();
             userLogin.Show();
             this.Hide();
         }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
