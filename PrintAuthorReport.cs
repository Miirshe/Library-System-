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
    public partial class PrintAuthorReport : Form
    {
        public static SqlConnection conn;
        public static string authorName;
        public PrintAuthorReport()
        {
            InitializeComponent();
        }

        private void PrintAuthorReport_Load(object sender, EventArgs e)
        {
            comStatement.SelectedItem = "All";
        }

        private void comStatement_TextChanged(object sender, EventArgs e)
        {
            if (comStatement.SelectedItem == "All")
            {
                txtAuthorName.Enabled = false;
                btnGenerate.Enabled = false;
               
            }
            else if (comStatement.SelectedItem == "Custom")
            {
                txtAuthorName.Enabled = true;
                btnGenerate.Enabled = true;
                AuthorName();
                
               
            }
        }

        public void AuthorName()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM author", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            txtAuthorName.DataSource = d_table.Tables[0];
            txtAuthorName.DisplayMember = "name";
            txtAuthorName.ValueMember = "id";

            conn.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AllReports cr = new AllReports();
            authorName = txtAuthorName.Text;
            cr.authorRP();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
