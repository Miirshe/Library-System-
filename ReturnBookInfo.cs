using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Guna.UI.WinForms;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public class ReturnBookInfo
    {
        public static SqlConnection conn;

        public static void loadAllReturnBook(GunaDataGridView bookView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readallreturnbook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            bookView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void registerReturnBook(int mid, string mname, string madd, string mphone, string memail, string bname, string rdate, int elap, double fine)
        {
            //try
            //{
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registerreturnbook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@mid", mid);
                insertCommand.Parameters.AddWithValue("@mname", mname);
                insertCommand.Parameters.AddWithValue("@madd", madd);
                insertCommand.Parameters.AddWithValue("@mphone", mphone);
                insertCommand.Parameters.AddWithValue("@memail", memail);
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@rdate", rdate);
                insertCommand.Parameters.AddWithValue("@elap", elap);
                insertCommand.Parameters.AddWithValue("@fine", fine);



                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Returned Book ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }



        public static void updateReturnBook(string bname,  int id)
        {
            //try
            //{
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updatereturnbook", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                
                insertCommand.Parameters.AddWithValue("@bname", bname);
                insertCommand.Parameters.AddWithValue("@id", id);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("'"+bname+" 'Successfulyy Returned ✔", "Returned Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }



        public static void deleteReturnBook(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deletereturnbook", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Returned Book.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static void CountReturnBook(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countreturnbook", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }

    }
}
