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
    public partial class PrintLendBook : Form
    {
        public static SqlConnection conn;
        public static string id;
        
        public PrintLendBook()
        {
            InitializeComponent();
        }

        private void PrintLendBook_Load(object sender, EventArgs e)
        {
            comStatement.SelectedItem = "All";
           
        }

        private void comStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comStatement.SelectedItem == "All")
            {
                txtMemberId.Enabled = false;
                btnGenerate.Enabled = false;
            }
            else if (comStatement.SelectedItem == "Custom")
            {
                txtMemberId.Enabled = true;
                btnGenerate.Enabled = true;
                memberIds();
            }
        }



        public void memberIds()
        {
            conn = myConnections.GetConnections();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            txtMemberId.DataSource = d_table.Tables[0];
            txtMemberId.DisplayMember = "id";
            txtMemberId.ValueMember = "id";

            conn.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AllReports cr = new AllReports();
            id = txtMemberId.Text;
            cr.lendBYID();
            //cr.openFrom(lendBYID());
           // cr.lendDetails();   
           
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

    }
}
