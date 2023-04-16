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
using Guna.UI.WinForms;


namespace DatabaseConnection
{
    public partial class LendBook : Form
    {
        public static SqlConnection conn;
        public LendBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
            else if (comBoxMemberId.Text.StartsWith("@") || (comBoxMemberId.Text.StartsWith(",")
             || (comBoxMemberId.Text.StartsWith(">")) || (comBoxMemberId.Text.StartsWith("/")) ||
             (comBoxMemberId.Text.StartsWith(".")) || (comBoxMemberId.Text.StartsWith("?")) ||
             (comBoxMemberId.Text.StartsWith("`")) || (comBoxMemberId.Text.StartsWith("_")) ||
             (comBoxMemberId.Text.StartsWith("-")) || (comBoxMemberId.Text.StartsWith("=")) ||
             (comBoxMemberId.Text.StartsWith("#")) || (comBoxMemberId.Text.StartsWith("$")) ||
             (comBoxMemberId.Text.StartsWith("!")) || (comBoxMemberId.Text.StartsWith("%")) ||
             (comBoxMemberId.Text.StartsWith("^")) || (comBoxMemberId.Text.StartsWith("&")) ||
             (comBoxMemberId.Text.StartsWith("(")) || (comBoxMemberId.Text.StartsWith(")")) ||
             (comBoxMemberId.Text.StartsWith("+")) || (comBoxMemberId.Text.StartsWith("e")) ||
             (comBoxMemberId.Text.StartsWith("a")) || (comBoxMemberId.Text.StartsWith("g")) ||
             (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("h")) ||
             (comBoxMemberId.Text.StartsWith("c")) || (comBoxMemberId.Text.StartsWith("i")) ||
             (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("j")) ||
             (comBoxMemberId.Text.StartsWith("e")) || (comBoxMemberId.Text.StartsWith("k")) ||
             (comBoxMemberId.Text.StartsWith("l")) || (comBoxMemberId.Text.StartsWith("q")) ||
             (comBoxMemberId.Text.StartsWith("m")) || (comBoxMemberId.Text.StartsWith("r")) ||
             (comBoxMemberId.Text.StartsWith("n")) || (comBoxMemberId.Text.StartsWith("s")) ||
             (comBoxMemberId.Text.StartsWith("o")) || (comBoxMemberId.Text.StartsWith("t")) ||
             (comBoxMemberId.Text.StartsWith("p")) || (comBoxMemberId.Text.StartsWith("u")) ||
             (comBoxMemberId.Text.StartsWith("v")) || (comBoxMemberId.Text.StartsWith("A")) ||
             (comBoxMemberId.Text.StartsWith("w")) || (comBoxMemberId.Text.StartsWith("B")) ||
             (comBoxMemberId.Text.StartsWith("x")) || (comBoxMemberId.Text.StartsWith("C")) ||
             (comBoxMemberId.Text.StartsWith("y")) || (comBoxMemberId.Text.StartsWith("D")) ||
             (comBoxMemberId.Text.StartsWith("z")) || (comBoxMemberId.Text.StartsWith("E")) ||
            (comBoxMemberId.Text.StartsWith("F")) || (comBoxMemberId.Text.StartsWith("O")) ||
             (comBoxMemberId.Text.StartsWith("G")) || (comBoxMemberId.Text.StartsWith("P")) ||
             (comBoxMemberId.Text.StartsWith("H")) || (comBoxMemberId.Text.StartsWith("Q")) ||
             (comBoxMemberId.Text.StartsWith("I")) || (comBoxMemberId.Text.StartsWith("R")) ||
             (comBoxMemberId.Text.StartsWith("J")) || (comBoxMemberId.Text.StartsWith("S")) ||
             (comBoxMemberId.Text.StartsWith("K")) || (comBoxMemberId.Text.StartsWith("T")) ||
             (comBoxMemberId.Text.StartsWith("L")) || (comBoxMemberId.Text.StartsWith("U")) ||
             (comBoxMemberId.Text.StartsWith("M")) || (comBoxMemberId.Text.StartsWith("V")) ||
             (comBoxMemberId.Text.StartsWith("N")) || (comBoxMemberId.Text.StartsWith("W")) ||
           (comBoxMemberId.Text.StartsWith("X")) || (comBoxMemberId.Text.StartsWith("Y")) ||
             (comBoxMemberId.Text.StartsWith("Z")) || (comBoxMemberId.Text.StartsWith(" "))
            ))
            {
                MessageBox.Show("Member ID  never start with Any Charecters .", "Member ID Must be digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
            else if (txtMemberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();               
            }

            else if (txtMemberName.Text.StartsWith("@") || (txtMemberName.Text.StartsWith(",")
                  || (txtMemberName.Text.StartsWith(">")) || (txtMemberName.Text.StartsWith("/")) ||
                  (txtMemberName.Text.StartsWith(".")) || (txtMemberName.Text.StartsWith("?")) ||
                  (txtMemberName.Text.StartsWith("`")) || (txtMemberName.Text.StartsWith("_")) ||
                  (txtMemberName.Text.StartsWith("-")) || (txtMemberName.Text.StartsWith("=")) ||
                  (txtMemberName.Text.StartsWith("#")) || (txtMemberName.Text.StartsWith("$")) ||
                  (txtMemberName.Text.StartsWith("!")) || (txtMemberName.Text.StartsWith("%")) ||
                  (txtMemberName.Text.StartsWith("^")) || (txtMemberName.Text.StartsWith("&")) ||
                  (txtMemberName.Text.StartsWith("(")) || (txtMemberName.Text.StartsWith(")")) ||
                  (txtMemberName.Text.StartsWith("+")) || (txtMemberName.Text.StartsWith("0")) ||
                  (txtMemberName.Text.StartsWith("1")) || (txtMemberName.Text.StartsWith("2")) ||
                  (txtMemberName.Text.StartsWith("3")) || (txtMemberName.Text.StartsWith("4")) ||
                  (txtMemberName.Text.StartsWith("5")) || (txtMemberName.Text.StartsWith("6")) ||
                  (txtMemberName.Text.StartsWith("7")) || (txtMemberName.Text.StartsWith("8")) ||
                  (txtMemberName.Text.StartsWith("9")) || (txtMemberName.Text.StartsWith(" "))
                  ))
            {
                MessageBox.Show("Member Name  never start with any digit .", "Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }

            else if (comBoxName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxName.Focus();
            }

            else
            {
                int book_qtty = 0;
                conn = myConnections.GetConnections();
                conn.Open();
                var cmd = new SqlCommand("Select * from book where name = '" + comBoxName.Text + "' ", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                var dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    book_qtty = int.Parse(dr2["aqtty"].ToString());
                }
                if (book_qtty > 0)
                {
                    int memberId = int.Parse(comBoxMemberId.Text);
                    string memberName = txtMemberName.Text;
                    string bookName = comBoxName.Text;
                    DateTime issueDate = DateTime.Parse(txtIssueDate.Text.ToString());
                    DateTime returnDate = DateTime.Parse(txtReturnDate.Text.ToString());

                    LendBookInfo.registerLendBook(memberId, memberName, txtMemberAddress.Text, txtMemberPhone.Text, txtMemberEmail.Text, bookName, issueDate, returnDate);
                    LendBookInfo.loadAllLendBook(LendBookView);
                    MakeEmptLendyBooks();
                    GetInvoice();

                }
                else
                {
                    MessageBox.Show("This Book Is Not Available To Brrow", "NOT AVAILABLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void MakeEmptLendyBooks()
        {
            comBoxMemberId.Text = "";
            txtMemberName.Text = "";
            txtMemberAddress.Text = "";
            txtMemberPhone.Text = "";
            txtMemberEmail.Text ="";
            
            comBoxName.Text = "";
            txtIssueDate.Text = "";
            txtReturnDate.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void bookName()
        {
               conn = myConnections.GetConnections();
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM book", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxName.DataSource = d_table.Tables[0];
            comBoxName.DisplayMember = "name";
            comBoxName.ValueMember = "id";

            conn.Close();

        }
        //public void memberIds()
        //{
        //    conn = myConnections.GetConnections();
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("SELECT * FROM member", conn);
        //    SqlDataAdapter reader = new SqlDataAdapter(cmd);
        //    DataSet d_table = new DataSet();
        //    reader.Fill(d_table);
        //    comBoxMemberId.DataSource = d_table.Tables[0];
        //    comBoxMemberId.DisplayMember = "id";
        //    comBoxMemberId.ValueMember = "id";

        //    conn.Close();
        //}

        private void LendBook_Load(object sender, EventArgs e)
        {
         //   memberIds();
            bookName();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LendBookInfo.loadAllLendBook(LendBookView);
        }


            
        

        private void LendBookCellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  memberIds();
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

            int id= (int)LendBookView.SelectedRows[0].Cells[0].Value;
            int mid = (int)LendBookView.SelectedRows[0].Cells[1].Value;
            txtMemberName.Text = (string)LendBookView.SelectedRows[0].Cells[2].Value;
            txtMemberAddress.Text = (string)LendBookView.SelectedRows[0].Cells[3].Value;
            txtMemberPhone.Text = (string)LendBookView.SelectedRows[0].Cells[4].Value;
            txtMemberEmail.Text = (string)LendBookView.SelectedRows[0].Cells[5].Value;
            comBoxName.Text = (string)LendBookView.SelectedRows[0].Cells[6].Value;
            txtIssueDate.Value = (DateTime)LendBookView.SelectedRows[0].Cells[7].Value;
            txtReturnDate.Value = (DateTime)LendBookView.SelectedRows[0].Cells[8].Value;
            //txtMemberName.Text = (string)LendBookView.SelectedRows[0].Cells[3].Value;
            //txtIssueDate.Text = (GunaDateTimePicker)LendBookView.SelectedRows[0].Cells[4].Value.ToString();
            //txtReturnDate = LendBookView.Rows[e.RowIndex].Cells["rdate"].Value.ToString();
            comBoxMemberId.Text = mid.ToString();
            //txtIssueDate.Text = issudate.ToShortDateString();
            //txtReturnDate.Text = returndate.ToShortDateString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateId = (int)LendBookView.SelectedRows[0].Cells[0].Value;
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
            else if (comBoxMemberId.Text.StartsWith("@") || (comBoxMemberId.Text.StartsWith(",")
             || (comBoxMemberId.Text.StartsWith(">")) || (comBoxMemberId.Text.StartsWith("/")) ||
             (comBoxMemberId.Text.StartsWith(".")) || (comBoxMemberId.Text.StartsWith("?")) ||
             (comBoxMemberId.Text.StartsWith("`")) || (comBoxMemberId.Text.StartsWith("_")) ||
             (comBoxMemberId.Text.StartsWith("-")) || (comBoxMemberId.Text.StartsWith("=")) ||
             (comBoxMemberId.Text.StartsWith("#")) || (comBoxMemberId.Text.StartsWith("$")) ||
             (comBoxMemberId.Text.StartsWith("!")) || (comBoxMemberId.Text.StartsWith("%")) ||
             (comBoxMemberId.Text.StartsWith("^")) || (comBoxMemberId.Text.StartsWith("&")) ||
             (comBoxMemberId.Text.StartsWith("(")) || (comBoxMemberId.Text.StartsWith(")")) ||
             (comBoxMemberId.Text.StartsWith("+")) || (comBoxMemberId.Text.StartsWith("e")) ||
             (comBoxMemberId.Text.StartsWith("a")) || (comBoxMemberId.Text.StartsWith("g")) ||
             (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("h")) ||
             (comBoxMemberId.Text.StartsWith("c")) || (comBoxMemberId.Text.StartsWith("i")) ||
             (comBoxMemberId.Text.StartsWith("b")) || (comBoxMemberId.Text.StartsWith("j")) ||
             (comBoxMemberId.Text.StartsWith("e")) || (comBoxMemberId.Text.StartsWith("k")) ||
             (comBoxMemberId.Text.StartsWith("l")) || (comBoxMemberId.Text.StartsWith("q")) ||
             (comBoxMemberId.Text.StartsWith("m")) || (comBoxMemberId.Text.StartsWith("r")) ||
             (comBoxMemberId.Text.StartsWith("n")) || (comBoxMemberId.Text.StartsWith("s")) ||
             (comBoxMemberId.Text.StartsWith("o")) || (comBoxMemberId.Text.StartsWith("t")) ||
             (comBoxMemberId.Text.StartsWith("p")) || (comBoxMemberId.Text.StartsWith("u")) ||
             (comBoxMemberId.Text.StartsWith("v")) || (comBoxMemberId.Text.StartsWith("A")) ||
             (comBoxMemberId.Text.StartsWith("w")) || (comBoxMemberId.Text.StartsWith("B")) ||
             (comBoxMemberId.Text.StartsWith("x")) || (comBoxMemberId.Text.StartsWith("C")) ||
             (comBoxMemberId.Text.StartsWith("y")) || (comBoxMemberId.Text.StartsWith("D")) ||
             (comBoxMemberId.Text.StartsWith("z")) || (comBoxMemberId.Text.StartsWith("E")) ||
            (comBoxMemberId.Text.StartsWith("F")) || (comBoxMemberId.Text.StartsWith("O")) ||
             (comBoxMemberId.Text.StartsWith("G")) || (comBoxMemberId.Text.StartsWith("P")) ||
             (comBoxMemberId.Text.StartsWith("H")) || (comBoxMemberId.Text.StartsWith("Q")) ||
             (comBoxMemberId.Text.StartsWith("I")) || (comBoxMemberId.Text.StartsWith("R")) ||
             (comBoxMemberId.Text.StartsWith("J")) || (comBoxMemberId.Text.StartsWith("S")) ||
             (comBoxMemberId.Text.StartsWith("K")) || (comBoxMemberId.Text.StartsWith("T")) ||
             (comBoxMemberId.Text.StartsWith("L")) || (comBoxMemberId.Text.StartsWith("U")) ||
             (comBoxMemberId.Text.StartsWith("M")) || (comBoxMemberId.Text.StartsWith("V")) ||
             (comBoxMemberId.Text.StartsWith("N")) || (comBoxMemberId.Text.StartsWith("W")) ||
           (comBoxMemberId.Text.StartsWith("X")) || (comBoxMemberId.Text.StartsWith("Y")) ||
             (comBoxMemberId.Text.StartsWith("Z")) || (comBoxMemberId.Text.StartsWith(" "))
            ))
            {
                MessageBox.Show("Member ID  never start with Any Charecters .", "Member ID Must be digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
            else if (txtMemberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }

            else if (txtMemberName.Text.StartsWith("@") || (txtMemberName.Text.StartsWith(",")
                  || (txtMemberName.Text.StartsWith(">")) || (txtMemberName.Text.StartsWith("/")) ||
                  (txtMemberName.Text.StartsWith(".")) || (txtMemberName.Text.StartsWith("?")) ||
                  (txtMemberName.Text.StartsWith("`")) || (txtMemberName.Text.StartsWith("_")) ||
                  (txtMemberName.Text.StartsWith("-")) || (txtMemberName.Text.StartsWith("=")) ||
                  (txtMemberName.Text.StartsWith("#")) || (txtMemberName.Text.StartsWith("$")) ||
                  (txtMemberName.Text.StartsWith("!")) || (txtMemberName.Text.StartsWith("%")) ||
                  (txtMemberName.Text.StartsWith("^")) || (txtMemberName.Text.StartsWith("&")) ||
                  (txtMemberName.Text.StartsWith("(")) || (txtMemberName.Text.StartsWith(")")) ||
                  (txtMemberName.Text.StartsWith("+")) || (txtMemberName.Text.StartsWith("0")) ||
                  (txtMemberName.Text.StartsWith("1")) || (txtMemberName.Text.StartsWith("2")) ||
                  (txtMemberName.Text.StartsWith("3")) || (txtMemberName.Text.StartsWith("4")) ||
                  (txtMemberName.Text.StartsWith("5")) || (txtMemberName.Text.StartsWith("6")) ||
                  (txtMemberName.Text.StartsWith("7")) || (txtMemberName.Text.StartsWith("8")) ||
                  (txtMemberName.Text.StartsWith("9")) || (txtMemberName.Text.StartsWith(" "))
                  ))
            {
                MessageBox.Show("Member Name  never start with any digit .", "Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }

            else if (comBoxName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxName.Focus();
            }

            else
            {
              
                int memberId = int.Parse(comBoxMemberId.Text);
                string memberName = txtMemberName.Text;
                string bookName = comBoxName.Text;
                DateTime issueDate = DateTime.Parse(txtIssueDate.Text.ToString());
                DateTime returnDate = DateTime.Parse(txtReturnDate.Text.ToString());

                LendBookInfo.updateLendBook(memberId, memberName, txtMemberAddress.Text, txtMemberPhone.Text, txtMemberEmail.Text, bookName, issueDate, returnDate, updateId);
                LendBookInfo.loadAllLendBook(LendBookView);
                MakeEmptLendyBooks();

                
              
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)LendBookView.SelectedRows[0].Cells[0].Value;
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
          

            else
            {
                //string name = txtMemberName.Text = (string)LendBookView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete Lended Book?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    LendBookInfo.deleteLendBook(deletedId);
                    LendBookInfo.loadAllLendBook(LendBookView);
                    MakeEmptLendyBooks();
                }
               

            }
        }

        
        public System.Windows.Forms.DialogResult confirmation { get; set; }
        private void ComBoxTextChaned(object sender, EventArgs e)
        {
            //if (comBoxMemberId.SelectedItem == "")
            //{
            //    txtMemberName.Text = "";
            //    comBoxName.Text = "0";
            //    txtReturnDate.Text = "";
            //    txtIssueDate.Text = "";
            //    return;
            //}

            //else
            //{
            //    conn = myConnections.GetConnections();
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("select * from member where id = '" + comBoxMemberId.Text + "'", conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        txtMemberName.Text = reader["name"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sorry This Member ID Not Found...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtMemberName.Text = "";
            //    }

            //    conn.Close();
            //}
        }

        private void comBoxCliked(object sender, EventArgs e)
        {
            //memberIds();
        }

        private void comBoxMemberId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtChangedID(object sender, EventArgs e)
        {
            int mid;
            if (comBoxMemberId.Text == "")
            {
                txtMemberName.Clear();
                txtMemberAddress.Clear();
                txtMemberPhone.Clear();
                txtMemberEmail.Clear();
            }
            else if (int.TryParse(comBoxMemberId.Text, out mid))
            {
                mid = int.Parse(comBoxMemberId.Text);

                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from member where id = '" + mid + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMemberName.Text = reader["name"].ToString();
                    txtMemberAddress.Text = reader["address"].ToString();
                    txtMemberPhone.Text = reader["phone"].ToString();
                    txtMemberEmail.Text = reader["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Sorry This Member ID Not Found...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberName.Text = "";
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid member Id.", "MEMBER ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }


        public void GetInvoice()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("invoceLendBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id", int.Parse(comBoxMemberId.Text));
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataTable d_table = new DataTable();
            reader.Fill(d_table);
            crInvoice cr = new crInvoice();
            cr.SetDataSource(d_table);
            PrintInvoice prl = new PrintInvoice();
            prl.crpInvoice.ReportSource = cr;
            prl.Show();
            conn.Close();
        }
    }
}
