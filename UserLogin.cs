using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DatabaseConnection
{
    public partial class UserLogin : Form
    {
        public static SqlConnection connection;
        public static string username;
        public static Image img;
        public static string type;
        public UserLogin()
        {
            InitializeComponent();
            if(Properties.Settings.Default.username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
                checkRember.Checked = true;
            }
            
               
        }

        private void show_Click(object sender, EventArgs e)
        {
            iconHide.Visible = true;
            txtPassword.PasswordChar = '\0';
            iconShow.Visible = false;
        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            iconShow.Visible = true;
            txtPassword.PasswordChar = '*';
            iconHide.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //SpalashScreen sb = new SpalashScreen();
            //sb.Show();

            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isBlank())
            {

                if (check_User())
                {
                    successLogin();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password. Please try again.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    makeEmpty();
                }
                  

            }
        }


        private bool check_User()
        {
            connection = myConnections.GetConnections();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select utype, username , photo from users where  username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "' ", connection);
            var reader =cmd.ExecuteReader();
            while (reader.Read())
            {
              
            if (reader.HasRows)
            {
                type = reader[0].ToString();
                username = reader[1].ToString();
                img = userInfo.getImage(reader[2]);
                return true;
            }
           
            }
            return false;
        }


        private void successLogin()
        {
            myDash dash = new myDash(username,type,img);
            dash.Show();
            this.Hide();
        }

        private bool isBlank()
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields Are Required.!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makeEmpty();
                return false;
            }
            else
            {

                return true;
            }
        }


        private void makeEmpty()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.ShowDialog();
            //this.Close();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void checkRember_CheckedChanged(object sender, EventArgs e)
        {
            
        }



        private Image getImage(object reader)
        {

            var ms = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void checkRember_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkRember.Checked)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
