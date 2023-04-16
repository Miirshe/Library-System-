using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace DatabaseConnection
{
    public class MemberInfo
    {
        public static SqlConnection conn;



        public static void loadAllMembers(GunaDataGridView memberView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readallmember", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            memberView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }




        public static void registerMembers(string name, string address,string email, string bname, string bphone, string mphone)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registermember", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@bphone", bphone);
                insertCommand.Parameters.AddWithValue("@mphone", mphone);
               

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Member ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateMembers(string name, string address,string email, string bname, string bphone, string mphone, int updateid)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updatemember", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@bphone", bphone);
                insertCommand.Parameters.AddWithValue("@mphone", mphone);
                insertCommand.Parameters.AddWithValue("@updateid", updateid);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated Member ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Bailed Phone Or Member Phone Is Alredy Teken", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public static void deleteMembers(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deletemember", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Member.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static void CountMember(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countmember", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }



    }
}
