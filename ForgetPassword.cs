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

namespace DatabaseConnection
{
    public partial class ForgetPassword : Form
    {
        public static SqlConnection conn;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserLogin usr = new UserLogin();
            usr.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (isValid())
            {
                try
                {
                    conn = myConnections.GetConnections();
                    SqlDataAdapter sdt = new SqlDataAdapter("select username from users where username = '" + txtUserame.Text + "' ", conn);
                    DataTable dtb = new DataTable();
                    sdt.Fill(dtb);
                    if (dtb.Rows.Count > 0)
                    {
                        if (isConfirmation())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE users set password = '" + txtPassword.Text + "' where username = '" + txtUserame.Text + "'", conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Changed Your Password.", "CHANGED PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //UserLogin usr = new UserLogin();
                            //usr.Show();
                            this.Hide();

                        }
                        else { }
                    }
                    else
                    {
                        MessageBox.Show("This username doen'n exist! please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserame.Focus();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRPR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private bool isValid()
        {
            if (txtUserame.Text.Trim().Equals(""))
            {
                MessageBox.Show("UserName TextBox is Empty. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserame.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {

                MessageBox.Show("New Password TextBox is Empty. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (txtConfirmPassword.Text.Trim().Equals(""))
            {

                MessageBox.Show("Confirm Password TextBox is Empty. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }
            else { return true; }
        }

        private bool isConfirmation()
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Confirm Password does'n match your password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtConfirmPassword.Focus();
                return false;
            }
            else { return true; }
        }

        public bool getEmpty()
        {
            txtUserame.Text = "";
            pass.Text = "";
            txtConfirmPassword.Text = "";
            txtUserame.Focus();
            return true;
        }





        private void iconHide_Click(object sender, EventArgs e)
        {
            iconShow.Visible = true;
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            iconHide.Visible = false;
        }

        private void iconShow_Click(object sender, EventArgs e)
        {
            iconHide.Visible = true;
            txtPassword.PasswordChar = '\0';
            txtConfirmPassword.PasswordChar = '\0';
            iconShow.Visible = false;
        }


    }
}
