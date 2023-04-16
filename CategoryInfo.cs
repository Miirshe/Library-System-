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
    public class CategoryInfo
    {
        public static SqlConnection conn;


        //READING ALL DATA IN CATEGORY TABLE
        public static void loadAllCategory(GunaDataGridView catageoryView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readallcategory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            catageoryView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // END RAEDING METHOD


        //Rgister new Category 
        public static void registerCategory(String name, string status, DateTime date)
        {
           try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("registercategory", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@status", status);
                insertCommand.Parameters.AddWithValue("@date", date);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Category ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
           }
            catch
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //END Register Category



        // MAKE UPDATE CATEGIDY METHOD
        public static void updateCategory(String name, string status, DateTime date, int updatedId)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand updateCommand = new SqlCommand("updatecategory", conn);
                updateCommand.CommandType = CommandType.StoredProcedure;

                updateCommand.Parameters.AddWithValue("@name", name);
                updateCommand.Parameters.AddWithValue("@status", status);
                updateCommand.Parameters.AddWithValue("@date", date);
                updateCommand.Parameters.AddWithValue("@updateid", updatedId);

                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated Category. ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry This Category Name Is Alredy Exists  \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        // END UPDATE CATAEGORY


        // DELETE CATEGORY
        public static void deleteCategory(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deletecategory", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Category.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // END DELETE CATEGORY


        public static void CountCategory(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countcategory", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }



      
    }
}
