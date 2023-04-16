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
    public class LendBookInfo
    {
        public static SqlConnection conn;

        public static void loadAllLendBook(GunaDataGridView memberView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readalllendbook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            memberView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }





        public static void registerLendBook(int mid, string mname, string madd, string mphone, string memail,  string bname, DateTime issuedate, DateTime rdate)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registerlendbook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@mid", mid);
                insertCommand.Parameters.AddWithValue("@mname", mname);
                insertCommand.Parameters.AddWithValue("@madd", madd);
                insertCommand.Parameters.AddWithValue("@mphone", mphone);
                insertCommand.Parameters.AddWithValue("@memail", memail);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@issuedate", issuedate);
                insertCommand.Parameters.AddWithValue("@rdate", rdate);
                


                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Lended Book ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static void updateLendBook(int mid, string mname, string madd, string mphone, string memail,  string bname, DateTime issuedate, DateTime rdate, int updateid)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updatelendbook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@mid", mid);
                insertCommand.Parameters.AddWithValue("@mname", mname);
                insertCommand.Parameters.AddWithValue("@madd", madd);
                insertCommand.Parameters.AddWithValue("@mphone", mphone);
                insertCommand.Parameters.AddWithValue("@memail", memail);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@issuedate", issuedate);
                insertCommand.Parameters.AddWithValue("@rdate", rdate);
                insertCommand.Parameters.AddWithValue("@updateid", updateid);


                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated Lended Book ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



         public static void deleteLendBook(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deletelendbook", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Lended Book.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static void CountLendBook(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countlendbook", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }




    }
}
