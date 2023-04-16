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
    public partial class AllReports : Form
    {
        public static SqlConnection conn;
        public AllReports()
        {
            InitializeComponent();
        }



        public void openFrom(object Form)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            this.panelContainer.Controls.Add(frm);
            frm.Dock = DockStyle.None;
            this.panelContainer.Tag = frm;
            frm.Show();

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            authorReport();
        }

        private void btnLendBook_Click(object sender, EventArgs e)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("reportLendBookALL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id", int.Parse(comBoxMemberId.Text));
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            reader.Fill(d_table);
            CrLendBookReport cr = new CrLendBookReport();
            cr.SetDataSource(d_table);
            PrintLendBook prl = new PrintLendBook();
            prl.crViewerLendBook.ReportSource = cr;
            openFrom(prl);

            conn.Close();
        }

        public  void lendBYID()
        {
            conn = myConnections.GetConnections();
             //PrintLendBook prl = new PrintLendBook();
            conn.Open();
            SqlCommand cmd = new SqlCommand("reportLendBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", PrintLendBook.id);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            reader.Fill(d_table);
            CrLendBookReport cr = new CrLendBookReport();
            cr.SetDataSource(d_table);
            PrintLendBook prl = new PrintLendBook();
            prl.crViewerLendBook.ReportSource = cr;
            prl.comStatement.Enabled = false;
            prl.pictureBoxClose.Visible = true;
            prl.ShowDialog();
            //openFrom(prl);
            conn.Close();
        }


        public void authorReport()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readAllAthorReports", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id", int.Parse(comBoxMemberId.Text));
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            reader.Fill(d_table);
            CrAuthorlReport cr = new CrAuthorlReport();
            cr.SetDataSource(d_table);
            PrintAuthorReport prl = new PrintAuthorReport();
            prl.crAuthorReports.ReportSource = cr;
            openFrom(prl);

            conn.Close();
        }

        public void authorRP()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("readAuthorReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", PrintAuthorReport.authorName);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            reader.Fill(d_table);
            CrAuthorlReport cr = new CrAuthorlReport();
            cr.SetDataSource(d_table);
            PrintAuthorReport prl = new PrintAuthorReport();
            prl.comStatement.Enabled = false;
            prl.pictureBoxClose.Visible = true;
            prl.Show();
            prl.crAuthorReports.ReportSource = cr;
           // openFrom(prl);

            conn.Close();
        }

        private void AllReports_Load(object sender, EventArgs e)
        {
            authorReport();
        }

        public void lendDetails()
        {
            PrintLendBook prl = new PrintLendBook();
            if (prl.txtMemberId.SelectedItem == "All")
            {
                prl.txtMemberId.Enabled = false;            
                prl.btnGenerate.Enabled = false;
            }
            else if (prl.txtMemberId.SelectedItem == "Custom")
            {
                prl.txtMemberId.Enabled = true;
                prl.btnGenerate.Enabled = true;
                lendBYID();

            }
           
        }

        
    }
}
