using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.SqlClient;

using System.IO;

namespace DatabaseConnection
{
    public partial class RegisterUsers : Form
    {
        public static SqlConnection conn;
        public static string ImageName;
        public RegisterUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool PhoneNumber()
        {
            try
                {
                    conn = myConnections.GetConnections();
                    SqlCommand cmd = new SqlCommand("select phone from users where phone = '" + txtUserPhoneNo.Text + "' ", conn);
                    SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                    DataTable dtb = new DataTable();
                    sdt.Fill(dtb);
                    if (dtb.Rows.Count > 0)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("This '"+txtUserPhoneNo.Text+"' Is All Alredy Taked","User Phone",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtUserPhoneNo.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRPR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            return true;
        }
        //UPDATE
        private void btnCencel_Click(object sender, EventArgs e)
        {
            string phone = txtUserPhoneNo.Text;


            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtName.Text.Trim().StartsWith("@") || (txtName.Text.Trim().StartsWith(",")
              || (txtName.Text.Trim().StartsWith(">")) || (txtName.Text.Trim().StartsWith("/")) ||
              (txtName.Text.Trim().StartsWith(".")) || (txtName.Text.Trim().StartsWith("?")) ||
              (txtName.Text.Trim().StartsWith("`")) || (txtName.Text.Trim().StartsWith("_")) ||
              (txtName.Text.Trim().StartsWith("-")) || (txtName.Text.Trim().StartsWith("=")) ||
              (txtName.Text.Trim().StartsWith("#")) || (txtName.Text.Trim().StartsWith("$")) ||
              (txtName.Text.Trim().StartsWith("!")) || (txtName.Text.Trim().StartsWith("%")) ||
              (txtName.Text.Trim().StartsWith("^")) || (txtName.Text.Trim().StartsWith("&")) ||
              (txtName.Text.Trim().StartsWith("(")) || (txtName.Text.Trim().StartsWith(")")) ||
              (txtName.Text.Trim().StartsWith("+")) || (txtName.Text.Trim().StartsWith("0")) ||
              (txtName.Text.Trim().StartsWith("1")) || (txtName.Text.Trim().StartsWith("2")) ||
              (txtName.Text.Trim().StartsWith("3")) || (txtName.Text.Trim().StartsWith("4")) ||
              (txtName.Text.Trim().StartsWith("5")) || (txtName.Text.Trim().StartsWith("6")) ||
              (txtName.Text.Trim().StartsWith("7")) || (txtName.Text.Trim().StartsWith("8")) ||
              (txtName.Text.Trim().StartsWith("9"))
              ))
            {
                MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (comBoxSex.SelectedItem == "Select")
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Trim().StartsWith("@") || (txtUsername.Text.Trim().StartsWith(",")
              || (txtUsername.Text.Trim().StartsWith(">")) || (txtUsername.Text.Trim().StartsWith("/")) ||
              (txtUsername.Text.Trim().StartsWith(".")) || (txtUsername.Text.Trim().StartsWith("?")) ||
              (txtUsername.Text.Trim().StartsWith("`")) || (txtUsername.Text.Trim().StartsWith("_")) ||
              (txtUsername.Text.Trim().StartsWith("-")) || (txtUsername.Text.Trim().StartsWith("=")) ||
              (txtUsername.Text.Trim().StartsWith("#")) || (txtUsername.Text.Trim().StartsWith("$")) ||
              (txtUsername.Text.Trim().StartsWith("!")) || (txtUsername.Text.Trim().StartsWith("%")) ||
              (txtUsername.Text.Trim().StartsWith("^")) || (txtUsername.Text.Trim().StartsWith("&")) ||
              (txtUsername.Text.Trim().StartsWith("(")) || (txtUsername.Text.Trim().StartsWith(")")) ||
              (txtUsername.Text.Trim().StartsWith("+")) || (txtUsername.Text.Trim().StartsWith("0")) ||
              (txtUsername.Text.Trim().StartsWith("1")) || (txtUsername.Text.Trim().StartsWith("2")) ||
              (txtUsername.Text.Trim().StartsWith("3")) || (txtUsername.Text.Trim().StartsWith("4")) ||
              (txtUsername.Text.Trim().StartsWith("5")) || (txtUsername.Text.Trim().StartsWith("6")) ||
              (txtUsername.Text.Trim().StartsWith("7")) || (txtUsername.Text.Trim().StartsWith("8")) ||
              (txtUsername.Text.Trim().StartsWith("9"))
              ))
            {
                MessageBox.Show("Username  never start with any digit .", "Username Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Psssword Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (comUserType.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Type Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUserType.Focus();
            }
            else if (comUserType.SelectedItem == "Select")
            {
                MessageBox.Show("User Type Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUserType.Focus();
            }
            else if (txtUserPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Phone No Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!(txtUserPhoneNo.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Your Phone number is must Start with 6.", "User Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (txtUserPhoneNo.Text.Length < 9)
            {
                MessageBox.Show("User Phone Is Invalid Number", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
         
            




            else
            {
                int updateId = (int)userView.SelectedRows[0].Cells[0].Value;


                conn = myConnections.GetConnections();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("update users set  name=@name, sex=@sex,username=@username,password=@password,utype=@utype,phone=@phone,photo=@photo where id = '" + updateId + "'", conn);
                    // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@sex", comBoxSex.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@utype", comUserType.Text);
                    cmd.Parameters.AddWithValue("@phone", txtUserPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@photo",userInfo.ImageToStreem(userPicture.Image).ToArray());

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Updated Successfully User ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userInfo user = new userInfo();
                        user.GetAllUsersInfo(userView, myDash.user);
                        MakeEmptyUser();
                    }
                   

                }
                catch (Exception err)
                {
                    
                    MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                   
                }
                conn.Close();
               
                   

            }
        }

        //ADD
        private void btnSave_Click(object sender, EventArgs e)
        {
            string phone = txtUserPhoneNo.Text;
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtName.Text.Trim().StartsWith("@") || (txtName.Text.Trim().StartsWith(",")
              || (txtName.Text.Trim().StartsWith(">")) || (txtName.Text.Trim().StartsWith("/")) ||
              (txtName.Text.Trim().StartsWith(".")) || (txtName.Text.Trim().StartsWith("?")) ||
              (txtName.Text.Trim().StartsWith("`")) || (txtName.Text.Trim().StartsWith("_")) ||
              (txtName.Text.Trim().StartsWith("-")) || (txtName.Text.Trim().StartsWith("=")) ||
              (txtName.Text.Trim().StartsWith("#")) || (txtName.Text.Trim().StartsWith("$")) ||
              (txtName.Text.Trim().StartsWith("!")) || (txtName.Text.Trim().StartsWith("%")) ||
              (txtName.Text.Trim().StartsWith("^")) || (txtName.Text.Trim().StartsWith("&")) ||
              (txtName.Text.Trim().StartsWith("(")) || (txtName.Text.Trim().StartsWith(")")) ||
              (txtName.Text.Trim().StartsWith("+")) || (txtName.Text.Trim().StartsWith("0")) ||
              (txtName.Text.Trim().StartsWith("1")) || (txtName.Text.Trim().StartsWith("2")) ||
              (txtName.Text.Trim().StartsWith("3")) || (txtName.Text.Trim().StartsWith("4")) ||
              (txtName.Text.Trim().StartsWith("5")) || (txtName.Text.Trim().StartsWith("6")) ||
              (txtName.Text.Trim().StartsWith("7")) || (txtName.Text.Trim().StartsWith("8")) ||
              (txtName.Text.Trim().StartsWith("9")) 
              ))
            {
                MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (comBoxSex.SelectedItem == "Select")
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Trim().StartsWith("@") || (txtUsername.Text.Trim().StartsWith(",")
              || (txtUsername.Text.Trim().StartsWith(">")) || (txtUsername.Text.Trim().StartsWith("/")) ||
              (txtUsername.Text.Trim().StartsWith(".")) || (txtUsername.Text.Trim().StartsWith("?")) ||
              (txtUsername.Text.Trim().StartsWith("`")) || (txtUsername.Text.Trim().StartsWith("_")) ||
              (txtUsername.Text.Trim().StartsWith("-")) || (txtUsername.Text.Trim().StartsWith("=")) ||
              (txtUsername.Text.Trim().StartsWith("#")) || (txtUsername.Text.Trim().StartsWith("$")) ||
              (txtUsername.Text.Trim().StartsWith("!")) || (txtUsername.Text.Trim().StartsWith("%")) ||
              (txtUsername.Text.Trim().StartsWith("^")) || (txtUsername.Text.Trim().StartsWith("&")) ||
              (txtUsername.Text.Trim().StartsWith("(")) || (txtUsername.Text.Trim().StartsWith(")")) ||
              (txtUsername.Text.Trim().StartsWith("+")) || (txtUsername.Text.Trim().StartsWith("0")) ||
              (txtUsername.Text.Trim().StartsWith("1")) || (txtUsername.Text.Trim().StartsWith("2")) ||
              (txtUsername.Text.Trim().StartsWith("3")) || (txtUsername.Text.Trim().StartsWith("4")) ||
              (txtUsername.Text.Trim().StartsWith("5")) || (txtUsername.Text.Trim().StartsWith("6")) ||
              (txtUsername.Text.Trim().StartsWith("7")) || (txtUsername.Text.Trim().StartsWith("8")) ||
              (txtUsername.Text.Trim().StartsWith("9")) 
              ))
            {
                MessageBox.Show("Username  never start with any digit .", "Username Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Psssword Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (comUserType.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Type Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUserType.Focus();
            }
            else if (comUserType.SelectedItem == "Select")
            {
                MessageBox.Show("User Type Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUserType.Focus();
            }
            else if (txtUserPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Phone No Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!(txtUserPhoneNo.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Your Phone number is must Start with 6.", "User Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(txtUserPhoneNo.Text[0]))
            {
                MessageBox.Show("Phono Number Must Be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (txtUserPhoneNo.Text.Length < 9)
            {
                MessageBox.Show("User Phone Is Invalid Number", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("User Phone must be Digit", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }

           
            

            else
            {

                conn = myConnections.GetConnections();
                SqlDataAdapter sdt = new SqlDataAdapter("select username from users where username = '" + txtUsername.Text + "' ", conn);
                DataTable dtb = new DataTable();
                sdt.Fill(dtb);
                SqlDataAdapter sdt2 = new SqlDataAdapter("select phone from users where phone = '" + txtUserPhoneNo.Text + "' ", conn);
                DataTable dtb2 = new DataTable();
                sdt2.Fill(dtb2);
                if (dtb.Rows.Count > 0)
                {
                    MessageBox.Show("This Username '" + txtUsername.Text + "' Is Alredy Exists", "UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }

                else if (dtb2.Rows.Count > 0)
                {

                    MessageBox.Show("This Phone '" + txtUserPhoneNo.Text + "' Is Alredy Teken", "User Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPhoneNo.Focus();


                }
                else
                {
                  

                    userInfo usr = new userInfo();
                    usr.registerUsers(txtName.Text, comBoxSex.Text, txtUsername.Text,txtPassword.Text,comUserType.Text,txtUserPhoneNo.Text,userPicture.Image);
                    MakeEmptyUser();
                    usr.GetAllUsersInfo(userView, myDash.user);

                }
               
               

            }


           

            
            

           
            
        }

        private void MakeEmptyUser()
        {
           
            txtName.Text = "";
            txtPassword.Text = "";
            txtUserPhoneNo.Text = "";
            comUserType.SelectedItem = "Select";
            comBoxSex.SelectedItem = "Select";
            txtUsername.Text = "";
          
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void RegisterUsers_Load(object sender, EventArgs e)
        {
            userInfo usr = new userInfo();
            usr.GetAllUsersInfo(userView,myDash.user);
            comBoxSex.SelectedItem = "Select";
            comUserType.SelectedItem = "Select";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            
        }





        public GunaDataGridView UsersData { get; set; }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myDash.role != "ADMIN")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

          //  btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            int user_id = (int)userView.SelectedRows[0].Cells[0].Value;
            txtName.Text = (string)userView.SelectedRows[0].Cells[1].Value;
            comBoxSex.Text = (string)userView.SelectedRows[0].Cells[2].Value;
            txtUsername.Text = (string)userView.SelectedRows[0].Cells[3].Value;
            txtPassword.Text = (string)userView.SelectedRows[0].Cells[4].Value;
            comUserType.Text = (string)userView.SelectedRows[0].Cells[5].Value;
            txtUserPhoneNo.Text = (string)userView.SelectedRows[0].Cells[6].Value;
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            userPicture.Image = getUserImage(user_id);
      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Name Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gender Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtUsername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Username Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Psssword Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (comUserType.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Type Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comUserType.Focus();
            }
            else if (txtUserPhoneNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("User Phone No Is Empty Please Try And Check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPhoneNo.Focus();
            }


            else
            {

                int deleteId = (int)userView.SelectedRows[0].Cells[0].Value;


                DialogResult confim = MessageBox.Show("Are You Sure To Delete " + txtUsername.Text + "?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (confim.HasFlag(DialogResult.No))
                {
                    return;
                }
                else
                {
                    userInfo user = new userInfo();
                    user.deleteUser(deleteId);
                    user.GetAllUsersInfo(userView, myDash.user);
                    MakeEmptyUser();
                }
                

            }

        }

        private void gunaTextBox_TextChanged(object sender, EventArgs e)
        {


            if (txtSearch.Text != "")
            {
                searchText();
            }
            else
            {
                lbl_display.Visible = false;
                userView.Visible = true;
                userInfo usr = new userInfo();
                usr.GetAllUsersInfo(userView, myDash.user);
            }
        }


        public void searchText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select id 'ID', name 'Full-Name',sex 'Sex', username 'Username', password 'Password',utype 'Role',phone 'Phone', date 'Date' from Users WHERE Username LIKE '%" + txtSearch.Text + "%' and username != '" + myDash.user + "'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    userView.DataSource = dTable;
                    userView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    userView.Visible = false;
                    lbl_display.Visible = true;
                }



                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void userView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }


        }

     
        private void btnBrowser(object sender, EventArgs e)
        {
            

        }

        private void butBrowsers_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
             fd.Filter = "Image File(*.jpg;*.jpeg;*.bmo;*.gif;*.png;*.jfif;) | *.jpg;*.jpeg;*.bmo;*.gif;*.png*.jfif;";
            try
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    ImageName = fd.FileName;
                    Bitmap newImg = new Bitmap(ImageName);
                    userPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    userPicture.Image = (Image)newImg;
                }
                fd = null;
            }
            catch (System.ArgumentException ae)
            {
                ImageName = " ";
                MessageBox.Show(ae.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private Image getUserImage(int id)
        {
            var conn = myConnections.GetConnections();
            conn.Open();
            var command = new SqlCommand("searchuserimage", conn);
            command.Parameters.AddWithValue("@id", id);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            reader.Read();
            var img = userInfo.getImage(reader[0]);
            return img;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
