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
    public partial class Publisher : Form
    {
        public static SqlConnection conn;
        public Publisher()
        {
            InitializeComponent();
        }

        private void Publisher_Load(object sender, EventArgs e)
        {
            PublisherInfo.loadAllPublisher(PublisherView);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phone = txtPublisherPhone.Text;
            if (txtPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }
                else if (txtPublisherName.Text.Trim().StartsWith("@") || (txtPublisherName.Text.Trim().StartsWith(",")
             || (txtPublisherName.Text.Trim().StartsWith(">")) || (txtPublisherName.Text.Trim().StartsWith("/")) ||
             (txtPublisherName.Text.Trim().StartsWith(".")) || (txtPublisherName.Text.Trim().StartsWith("?")) ||
             (txtPublisherName.Text.Trim().StartsWith("`")) || (txtPublisherName.Text.Trim().StartsWith("_")) ||
             (txtPublisherName.Text.Trim().StartsWith("-")) || (txtPublisherName.Text.Trim().StartsWith("=")) ||
             (txtPublisherName.Text.Trim().StartsWith("#")) || (txtPublisherName.Text.Trim().StartsWith("$")) ||
             (txtPublisherName.Text.Trim().StartsWith("!")) || (txtPublisherName.Text.Trim().StartsWith("%")) ||
             (txtPublisherName.Text.Trim().StartsWith("^")) || (txtPublisherName.Text.Trim().StartsWith("&")) ||
             (txtPublisherName.Text.Trim().StartsWith("(")) || (txtPublisherName.Text.Trim().StartsWith(")")) ||
             (txtPublisherName.Text.Trim().StartsWith("+")) || (txtPublisherName.Text.Trim().StartsWith("0")) ||
             (txtPublisherName.Text.Trim().StartsWith("1")) || (txtPublisherName.Text.Trim().StartsWith("2")) ||
             (txtPublisherName.Text.Trim().StartsWith("3")) || (txtPublisherName.Text.Trim().StartsWith("4")) ||
             (txtPublisherName.Text.Trim().StartsWith("5")) || (txtPublisherName.Text.Trim().StartsWith("6")) ||
             (txtPublisherName.Text.Trim().StartsWith("7")) || (txtPublisherName.Text.Trim().StartsWith("8")) ||
             (txtPublisherName.Text.Trim().StartsWith("9")) 
             ))
            {
                MessageBox.Show("Publisher Name  never start with any digit .", "Publisher Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }

            else if (txtPublisherAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherAddress.Focus();
            }
            else if (txtPublisherAddress.Text.Trim().StartsWith("@") || (txtPublisherAddress.Text.Trim().StartsWith(",")
                 || (txtPublisherAddress.Text.Trim().StartsWith(">")) || (txtPublisherAddress.Text.Trim().StartsWith("/")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith(".")) || (txtPublisherAddress.Text.Trim().StartsWith("?")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("`")) || (txtPublisherAddress.Text.Trim().StartsWith("_")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("-")) || (txtPublisherAddress.Text.Trim().StartsWith("=")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("#")) || (txtPublisherAddress.Text.Trim().StartsWith("$")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("!")) || (txtPublisherAddress.Text.Trim().StartsWith("%")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("^")) || (txtPublisherAddress.Text.Trim().StartsWith("&")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("(")) || (txtPublisherAddress.Text.Trim().StartsWith(")")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("+")) || (txtPublisherAddress.Text.Trim().StartsWith("0")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("1")) || (txtPublisherAddress.Text.Trim().StartsWith("2")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("3")) || (txtPublisherAddress.Text.Trim().StartsWith("4")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("5")) || (txtPublisherAddress.Text.Trim().StartsWith("6")) || 
                 (txtPublisherAddress.Text.Trim().StartsWith("7")) || (txtPublisherAddress.Text.Trim().StartsWith("8")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("9")) 
                 ))
            {
                MessageBox.Show("Publisher Address never start with any digit .", "Publisher Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherAddress.Focus();
            }

            else if (txtPublisherPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Puplisher Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!(txtPublisherPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Publisher Phone  is must Start with 6.", "Publisher Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (txtPublisherPhone.Text.Length < 9)
            {
                MessageBox.Show("Publisher Phone Is Invalid Number", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }

            else
            {
                conn = myConnections.GetConnections();
                SqlDataAdapter sdt = new SqlDataAdapter("select name from publisher where name = '" + txtPublisherName.Text + "' ", conn);
                DataTable dtb = new DataTable();
                sdt.Fill(dtb);
                SqlDataAdapter sdt2 = new SqlDataAdapter("select phone from publisher where phone = '" + txtPublisherPhone.Text + "' ", conn);
                DataTable dtb2 = new DataTable();
                sdt2.Fill(dtb2);
                if (dtb.Rows.Count > 0)
                {
                    MessageBox.Show("This publisher Name Is Alredy Exists", "Publisher Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPublisherName.Focus();
                }

                else if (dtb2.Rows.Count > 0)
                {

                    MessageBox.Show("This Phone Is Alredy Teken", "Publiher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPublisherName.Focus();


                }
                else
                {
                    PublisherInfo.registerPublisher(txtPublisherName.Text, txtPublisherAddress.Text, txtPublisherPhone.Text);
                    PublisherInfo.loadAllPublisher(PublisherView);
                    MakeEmptyPublisher();


                }


                
            }
        }

        private void MakeEmptyPublisher()
        {
            txtPublisherName.Text = "";
            txtPublisherAddress.Text = "";
            txtPublisherPhone.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void CellClickPublisher(object sender, DataGridViewCellEventArgs e)
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

            int id = (int)PublisherView.SelectedRows[0].Cells[0].Value;
            txtPublisherName.Text = (string)PublisherView.SelectedRows[0].Cells[1].Value;
            txtPublisherAddress.Text = (string)PublisherView.SelectedRows[0].Cells[2].Value;
            txtPublisherPhone.Text = (string)PublisherView.SelectedRows[0].Cells[3].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phone = txtPublisherPhone.Text;
            int updateId = (int)PublisherView.SelectedRows[0].Cells[0].Value;
            if (txtPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }
            else if (txtPublisherName.Text.Trim().StartsWith("@") || (txtPublisherName.Text.Trim().StartsWith(",")
         || (txtPublisherName.Text.Trim().StartsWith(">")) || (txtPublisherName.Text.Trim().StartsWith("/")) ||
         (txtPublisherName.Text.Trim().StartsWith(".")) || (txtPublisherName.Text.Trim().StartsWith("?")) ||
         (txtPublisherName.Text.Trim().StartsWith("`")) || (txtPublisherName.Text.Trim().StartsWith("_")) ||
         (txtPublisherName.Text.Trim().StartsWith("-")) || (txtPublisherName.Text.Trim().StartsWith("=")) ||
         (txtPublisherName.Text.Trim().StartsWith("#")) || (txtPublisherName.Text.Trim().StartsWith("$")) ||
         (txtPublisherName.Text.Trim().StartsWith("!")) || (txtPublisherName.Text.Trim().StartsWith("%")) ||
         (txtPublisherName.Text.Trim().StartsWith("^")) || (txtPublisherName.Text.Trim().StartsWith("&")) ||
         (txtPublisherName.Text.Trim().StartsWith("(")) || (txtPublisherName.Text.Trim().StartsWith(")")) ||
         (txtPublisherName.Text.Trim().StartsWith("+")) || (txtPublisherName.Text.Trim().StartsWith("0")) ||
         (txtPublisherName.Text.Trim().StartsWith("1")) || (txtPublisherName.Text.Trim().StartsWith("2")) ||
         (txtPublisherName.Text.Trim().StartsWith("3")) || (txtPublisherName.Text.Trim().StartsWith("4")) ||
         (txtPublisherName.Text.Trim().StartsWith("5")) || (txtPublisherName.Text.Trim().StartsWith("6")) ||
         (txtPublisherName.Text.Trim().StartsWith("7")) || (txtPublisherName.Text.Trim().StartsWith("8")) ||
         (txtPublisherName.Text.Trim().StartsWith("9")) 
         ))
            {
                MessageBox.Show("Publisher Name  never start with any digit .", "Publisher Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }

            else if (txtPublisherAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherAddress.Focus();
            }
            else if (txtPublisherAddress.Text.Trim().StartsWith("@") || (txtPublisherAddress.Text.Trim().StartsWith(",")
                 || (txtPublisherAddress.Text.Trim().StartsWith(">")) || (txtPublisherAddress.Text.Trim().StartsWith("/")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith(".")) || (txtPublisherAddress.Text.Trim().StartsWith("?")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("`")) || (txtPublisherAddress.Text.Trim().StartsWith("_")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("-")) || (txtPublisherAddress.Text.Trim().StartsWith("=")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("#")) || (txtPublisherAddress.Text.Trim().StartsWith("$")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("!")) || (txtPublisherAddress.Text.Trim().StartsWith("%")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("^")) || (txtPublisherAddress.Text.Trim().StartsWith("&")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("(")) || (txtPublisherAddress.Text.Trim().StartsWith(")")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("+")) || (txtPublisherAddress.Text.Trim().StartsWith("0")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("1")) || (txtPublisherAddress.Text.Trim().StartsWith("2")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("3")) || (txtPublisherAddress.Text.Trim().StartsWith("4")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("5")) || (txtPublisherAddress.Text.Trim().StartsWith("6")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("7")) || (txtPublisherAddress.Text.Trim().StartsWith("8")) ||
                 (txtPublisherAddress.Text.Trim().StartsWith("9")) 
                 ))
            {
                MessageBox.Show("Publisher Address never start with any digit .", "Publisher Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherAddress.Focus();
            }

            else if (txtPublisherPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Puplisher Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!(txtPublisherPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Publisher Phone  is must Start with 6.", "Publisher Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (txtPublisherPhone.Text.Length < 9)
            {
                MessageBox.Show("Publisher Phone Is Invalid Number", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }

            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("Publisher Phone must be Digit", "Publisher Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }
            else
            {
                PublisherInfo.UpdatePublisher(txtPublisherName.Text, txtPublisherAddress.Text, txtPublisherPhone.Text, updateId);
                PublisherInfo.loadAllPublisher(PublisherView);
                MakeEmptyPublisher();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)PublisherView.SelectedRows[0].Cells[0].Value;
            if (txtPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }

            else if (txtPublisherAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherAddress.Focus();
            }

            else if (txtPublisherPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Puplisher Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherPhone.Focus();
            }

            else
            {
                string name = txtPublisherName.Text = (string)PublisherView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Info?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    PublisherInfo.deletePublisher(deletedId);
                    PublisherInfo.loadAllPublisher(PublisherView);
                    MakeEmptyPublisher();
                }
               

            }
        }


        public void serachText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select id 'ID', name 'Publiser Name', address 'Address', phone 'Publisher Phone', date 'Date' from publisher WHERE name LIKE '" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    PublisherView.DataSource = dTable;
                    PublisherView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    PublisherView.Visible = false;
                    lbl_display.Visible = true;
                }
               

                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void PublisherTextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                serachText();
            }
            else
            {
                PublisherView.Visible = true;
                lbl_display.Visible = false;
                PublisherInfo.loadAllPublisher(PublisherView);
            }
        }

      



    }
}
