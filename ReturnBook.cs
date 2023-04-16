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
    public partial class ReturnBook : Form
    {
        public static SqlConnection conn;
        public ReturnBook()
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
            

            else
            {
                int mid = int.Parse(comBoxMemberId.Text);
                string mname = txtMemberName.Text;
                string madd = txtMemberAddress.Text;
                string mphone = txtMemberPhone.Text;
                string memail = txtMemberEmail.Text;
                string bookName = txtBookName.Text;
                int elp = int.Parse(txtDayEpalsed.Text);
                double fine = double.Parse(txtFine.Text);
                string returnDate = txtReturnDate.Text;

                ReturnBookInfo.registerReturnBook(mid, mname, madd, mphone, memail, bookName, returnDate, elp, fine);
                ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                MakeEmptyRuturnBooks();


            }
        }

        private void MakeEmptyRuturnBooks()
        {
            comBoxMemberId.Text = "";
            txtBookName.Text = "";
            txtReturnDate.Text = "";
            txtDayEpalsed.Text = "";
            txtFine.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            ReturnBookInfo.loadAllReturnBook(ReturnBookView);
        }
     

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }

           

            else
            {
                int mid = int.Parse(comBoxMemberId.Text);
                string mname = txtMemberName.Text;
                string madd = txtMemberAddress.Text;
                string mphone = txtMemberPhone.Text;
                string memail = txtMemberEmail.Text;
                string bookName = txtBookName.Text;
                int elp = int.Parse(txtDayEpalsed.Text);
                double fine = double.Parse(txtFine.Text);
                string returnDate = txtReturnDate.Text;
                int deleteId = (int)ReturnBookView.SelectedRows[0].Cells[0].Value;

                int book_qtty = 0;
                int qtty = 0;
                conn = myConnections.GetConnections();
                conn.Open();
                var cmd = new SqlCommand("Select * from book where name = '" + bookName + "' ", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                var dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    qtty = int.Parse(dr2["qtty"].ToString());
                    book_qtty = int.Parse(dr2["aqtty"].ToString());
                }
                if (book_qtty != qtty)
                {
                    ReturnBookInfo.updateReturnBook(bookName,int.Parse(comBoxMemberId.Text));
                    ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                    MakeEmptyRuturnBooks();
                }
                else
                {
                    DialogResult con = MessageBox.Show("Sorry You Cannot Return! This Book Is Alradey Returned.\nAre You Want To Delete?", "RETURN BOOK", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (con.HasFlag(DialogResult.No)) { return; }
                    else
                    {
                        ReturnBookInfo.deleteReturnBook(deleteId);
                        ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                        MakeEmptyRuturnBooks();

                    }
                   
                }


               

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comBoxMemberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }

            

            else
            {
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete Lended Book?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    int deletedId = (int)ReturnBookView.SelectedRows[0].Cells[0].Value;
                    ReturnBookInfo.deleteReturnBook(deletedId);
                    ReturnBookInfo.loadAllReturnBook(ReturnBookView);
                  
                    MakeEmptyRuturnBooks();
                    
                   
                }
                
            }

        }

        private void ReturnBookCellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (myDash.role != "ADMIN")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            int id = (int)ReturnBookView.SelectedRows[0].Cells[0].Value;
            txtMemberName.Text = (string)ReturnBookView.SelectedRows[0].Cells[1].Value;
            txtMemberAddress.Text = (string)ReturnBookView.SelectedRows[0].Cells[2].Value;
            txtMemberPhone.Text = (string)ReturnBookView.SelectedRows[0].Cells[3].Value;
            txtMemberEmail.Text = (string)ReturnBookView.SelectedRows[0].Cells[4].Value;
            txtBookName.Text = (string)ReturnBookView.SelectedRows[0].Cells[5].Value.ToString();
            txtReturnDate.Text= (string)ReturnBookView.SelectedRows[0].Cells[6].Value;
            int elap = (int)ReturnBookView.SelectedRows[0].Cells[7].Value;
            double fine = (double)ReturnBookView.SelectedRows[0].Cells[8].Value;

            comBoxMemberId.Text = id.ToString();
            txtDayEpalsed.Text = elap.ToString();
            txtFine.Text = fine.ToString();
           // txtReturnDate.Text = rdate.ToString();
           // txtFine.Text = fine.ToString();
        }

        private void ComBoxTextChanged(object sender, EventArgs e)
        {
         
        }

        private void comBoxCliked(object sender, EventArgs e)
        {
            //memberIds();
        }

        private void comBoxCliked_DED(object sender, EventArgs e)
        {
          //  memberIds();
        }

        private void txtReturn(object sender, EventArgs e)
        {
            int mid;
            if (comBoxMemberId.Text == "")
            {
                txtMemberName.Clear();
                txtMemberAddress.Clear();
                txtMemberEmail.Clear();
                txtMemberPhone.Clear();
                txtReturnDate.Text = "";
                txtFine.Text = "";
                txtDayEpalsed.Text = "";
                txtBookName.Text = "";
                return;
            }



            else if (int.TryParse(comBoxMemberId.Text, out mid))
            {
                mid = int.Parse(comBoxMemberId.Text);
                conn = myConnections.GetConnections();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select mname, madd, mphone,memail, bname, rdate, DATEDIFF(dd,rdate,GETDATE()) 'Elapsed' from lendbook WHERE mid = '" + mid + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMemberName.Text = reader["mname"].ToString();
                    txtMemberAddress.Text = reader["madd"].ToString();
                    txtMemberPhone.Text = reader["mphone"].ToString();
                    txtMemberEmail.Text = reader["memail"].ToString();
                    txtBookName.Text = reader["bname"].ToString();
                    txtReturnDate.Text = reader["rdate"].ToString();
                    string elap = reader["Elapsed"].ToString();

                    int elapp = int.Parse(elap);
                    if (elapp > 0)
                    {
                        txtDayEpalsed.Text = elap;
                        double fine = (double)elapp / 100;
                        txtFine.Text = fine.ToString();
                    }
                    else
                    {
                        txtDayEpalsed.Text = "0";
                        txtFine.Text = "0";
                    }

                }
                else
                {
                    MessageBox.Show("Sorry This Member ID Not Found...!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comBoxMemberId.Text = "";
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid Member Id.", "MEMEBER ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxMemberId.Focus();
            }
        }

       
    }
}
