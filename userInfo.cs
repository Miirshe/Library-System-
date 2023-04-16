using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Guna.UI.WinForms;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace DatabaseConnection

{
    public class userInfo
    {
        public SqlConnection conn;

        public void GetAllUsersInfo(GunaDataGridView Dashboard, string username)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand cmd = new SqlCommand("readusersepical", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable showTable = new DataTable();
            reader.Fill(showTable);
            Dashboard.DataSource = showTable;
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }
        public static MemoryStream ImageToStreem(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms;
        
        }

        public static Image getImage(object reader)
        {
            
            var ms = new MemoryStream((byte[]) reader);
            Image img = Image.FromStream(ms);
            return img;
        }


        public void registerUsers(string name, string sex, string username, string passWord, string utype, string phone, Image photo)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registeruser", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@sex", sex);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", passWord);
                insertCommand.Parameters.AddWithValue("@utype", utype);
                insertCommand.Parameters.AddWithValue("@phone", phone);
                insertCommand.Parameters.AddWithValue("@photo", ImageToStreem(photo).ToArray());

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered User ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void updateUsers(string name, string sex, string username, string passWord, string utype, string phone, Image photo,int updateId)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updateuser", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@sex", sex);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", passWord);
                insertCommand.Parameters.AddWithValue("@utype", utype);
                insertCommand.Parameters.AddWithValue("@phone", phone);
                insertCommand.Parameters.AddWithValue("@photo", photo);
                insertCommand.Parameters.AddWithValue("@updateId", updateId);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated User ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Eaither username or Phone Number Is Alredy Teken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteUser(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deleteuser", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void searchUser(int id, GunaDataGridView users)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand searchCommand = new SqlCommand("searchuser", conn);
                searchCommand.CommandType = CommandType.StoredProcedure;
                searchCommand.Parameters.AddWithValue("@id", id);

                SqlDataAdapter reader = new SqlDataAdapter(searchCommand);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    users.DataSource = dTable;
                    searchCommand.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Invalid ID.\nPlease try again..", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error.\nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        public void CountUser(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countUser",conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }


    }
}
