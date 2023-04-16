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
    public class AuthorInfo
    {
        public static SqlConnection conn;


        //READING ALL DATA IN CATEGORY TABLE
        public static void loadAllAuthor(GunaDataGridView authorView)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readallauthor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable dTable = new DataTable();
            reader.Fill(dTable);
            authorView.DataSource = dTable;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // END RAEDING METHOD


        public static void registerAuthor(string name, string address, string sex, string experience, string phone)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("resgisterauthor", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@sex", sex);
                insertCommand.Parameters.AddWithValue("@experience", experience);
                insertCommand.Parameters.AddWithValue("@phone", phone);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Registered Author ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("sorry you have an error. \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //UPDATE 
        public static void updateAuthor(String name, string address, string sex, string experience, string phone,int updateid)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand insertCommand = new SqlCommand("updateauthor", conn);
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@sex", sex);
                insertCommand.Parameters.AddWithValue("@experience", experience);
                insertCommand.Parameters.AddWithValue("@phone", phone);
                insertCommand.Parameters.AddWithValue("@updateid", updateid);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated Author ✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Author Name Or Authur Phone Is Alredy Teken \nplease try again.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //DELETE AUTHOR

        public static void deleteAuthor(int id)
        {
            try
            {
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("deleteauthor", conn);
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deteled Author.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry You Have An Error. \nPlease Try Again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //COUNT

        public static void CountAuthor(Label count)
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand countCommand = new SqlCommand("countauthor", conn);
            countCommand.CommandType = CommandType.StoredProcedure;
            int countText = (int)countCommand.ExecuteScalar();
            count.Text = countText.ToString();

            conn.Close();
        }



    }
}
