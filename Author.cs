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
    public partial class Author : Form
    {
        public static SqlConnection conn;
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            AuthorInfo.loadAllAuthor(AuthorView);
            comBoxSex.SelectedItem = "Select";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phone = txtAuthorPhone.Text;
            if (txtAuthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorName.Focus();
            }
            else if (txtAuthorName.Text.Trim().StartsWith("@") || (txtAuthorName.Text.Trim().StartsWith(",")
              || (txtAuthorName.Text.Trim().StartsWith(">")) || (txtAuthorName.Text.Trim().StartsWith("/")) ||
              (txtAuthorName.Text.Trim().StartsWith(".")) || (txtAuthorName.Text.Trim().StartsWith("?")) ||
              (txtAuthorName.Text.Trim().StartsWith("`")) || (txtAuthorName.Text.Trim().StartsWith("_")) ||
              (txtAuthorName.Text.Trim().StartsWith("-")) || (txtAuthorName.Text.Trim().StartsWith("=")) ||
              (txtAuthorName.Text.Trim().StartsWith("#")) || (txtAuthorName.Text.Trim().StartsWith("$")) ||
              (txtAuthorName.Text.Trim().StartsWith("!")) || (txtAuthorName.Text.Trim().StartsWith("%")) ||
              (txtAuthorName.Text.Trim().StartsWith("^")) || (txtAuthorName.Text.Trim().StartsWith("&")) ||
              (txtAuthorName.Text.Trim().StartsWith("(")) || (txtAuthorName.Text.Trim().StartsWith(")")) ||
              (txtAuthorName.Text.Trim().StartsWith("+")) || (txtAuthorName.Text.Trim().StartsWith("0")) ||
              (txtAuthorName.Text.Trim().StartsWith("1")) || (txtAuthorName.Text.Trim().StartsWith("2")) ||
              (txtAuthorName.Text.Trim().StartsWith("3")) || (txtAuthorName.Text.Trim().StartsWith("4")) ||
              (txtAuthorName.Text.Trim().StartsWith("5")) || (txtAuthorName.Text.Trim().StartsWith("6")) ||
              (txtAuthorName.Text.Trim().StartsWith("7")) || (txtAuthorName.Text.Trim().StartsWith("8")) ||
              (txtAuthorName.Text.Trim().StartsWith("9")) 
          ))
            {
                MessageBox.Show("Author Name  never start with any digit .", "Author Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorName.Focus();
            }

            else if (txtAuthorAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorAddress.Focus();
            }
                else if (txtAuthorAddress.Text.Trim().StartsWith("@") || (txtAuthorAddress.Text.Trim().StartsWith(",")
              || (txtAuthorAddress.Text.Trim().StartsWith(">")) || (txtAuthorAddress.Text.Trim().StartsWith("/")) ||
              (txtAuthorAddress.Text.Trim().StartsWith(".")) || (txtAuthorAddress.Text.Trim().StartsWith("?")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("`")) || (txtAuthorAddress.Text.Trim().StartsWith("_")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("-")) || (txtAuthorAddress.Text.Trim().StartsWith("=")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("#")) || (txtAuthorAddress.Text.Trim().StartsWith("$")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("!")) || (txtAuthorAddress.Text.Trim().StartsWith("%")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("^")) || (txtAuthorAddress.Text.Trim().StartsWith("&")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("(")) || (txtAuthorAddress.Text.Trim().StartsWith(")")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("+")) || (txtAuthorAddress.Text.Trim().StartsWith("0")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("1")) || (txtAuthorAddress.Text.Trim().StartsWith("2")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("3")) || (txtAuthorAddress.Text.Trim().StartsWith("4")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("5")) || (txtAuthorAddress.Text.Trim().StartsWith("6")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("7")) || (txtAuthorAddress.Text.Trim().StartsWith("8")) ||
              (txtAuthorAddress.Text.Trim().StartsWith("9"))
          ))
            {
                MessageBox.Show("Author Address  never start with any digit .", "Author Address Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorAddress.Focus();
            }
        
            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Authir Gender Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (comBoxSex.SelectedItem == "Select")
            {
                MessageBox.Show("Authir Gender Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtAuthorExperience.Text.Trim().Equals(""))
            {
                MessageBox.Show("Experience Author Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorExperience.Text.Trim().StartsWith("@") || (txtAuthorExperience.Text.Trim().StartsWith(",")
                               || (txtAuthorExperience.Text.Trim().StartsWith(">")) || (txtAuthorExperience.Text.Trim().StartsWith("/")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith(".")) || (txtAuthorExperience.Text.Trim().StartsWith("?")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("`")) || (txtAuthorExperience.Text.Trim().StartsWith("_")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("-")) || (txtAuthorExperience.Text.Trim().StartsWith("=")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("#")) || (txtAuthorExperience.Text.Trim().StartsWith("$")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("!")) || (txtAuthorExperience.Text.Trim().StartsWith("%")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("^")) || (txtAuthorExperience.Text.Trim().StartsWith("&")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("(")) || (txtAuthorExperience.Text.Trim().StartsWith(")")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("+")) || (txtAuthorExperience.Text.Trim().StartsWith("*")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("a")) || (txtAuthorExperience.Text.Trim().StartsWith("g")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("b")) || (txtAuthorExperience.Text.Trim().StartsWith("h")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("c")) || (txtAuthorExperience.Text.Trim().StartsWith("i")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("b")) || (txtAuthorExperience.Text.Trim().StartsWith("j")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("e")) || (txtAuthorExperience.Text.Trim().StartsWith("k")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("l")) || (txtAuthorExperience.Text.Trim().StartsWith("q")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("m")) || (txtAuthorExperience.Text.Trim().StartsWith("r")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("n")) || (txtAuthorExperience.Text.Trim().StartsWith("s")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("o")) || (txtAuthorExperience.Text.Trim().StartsWith("t")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("p")) || (txtAuthorExperience.Text.Trim().StartsWith("u")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("v")) || (txtAuthorExperience.Text.Trim().StartsWith("A")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("w")) || (txtAuthorExperience.Text.Trim().StartsWith("B")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("x")) || (txtAuthorExperience.Text.Trim().StartsWith("C")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("y")) || (txtAuthorExperience.Text.Trim().StartsWith("D")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("z")) || (txtAuthorExperience.Text.Trim().StartsWith("E")) ||
                              (txtAuthorExperience.Text.Trim().StartsWith("F")) || (txtAuthorExperience.Text.Trim().StartsWith("O")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("G")) || (txtAuthorExperience.Text.Trim().StartsWith("P")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("H")) || (txtAuthorExperience.Text.Trim().StartsWith("Q")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("I")) || (txtAuthorExperience.Text.Trim().StartsWith("R")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("J")) || (txtAuthorExperience.Text.Trim().StartsWith("S")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("K")) || (txtAuthorExperience.Text.Trim().StartsWith("T")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("L")) || (txtAuthorExperience.Text.Trim().StartsWith("U")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("M")) || (txtAuthorExperience.Text.Trim().StartsWith("V")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("N")) || (txtAuthorExperience.Text.Trim().StartsWith("W")) ||
                             (txtAuthorExperience.Text.Trim().StartsWith("X")) || (txtAuthorExperience.Text.Trim().StartsWith("Y")) ||
                               (txtAuthorExperience.Text.Trim().StartsWith("Z")) 

           ))
            {
                MessageBox.Show("Author Experience  never start with any Character .", "Author Experience Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorExperience.Text == "0 Year" || txtAuthorExperience.Text == "0 years" || txtAuthorExperience.Text == "0 Years" || txtAuthorExperience.Text == "0 years")
            {
                MessageBox.Show("Sorry!. Author Experience Is Less then 1 Year", "Author Experience", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!(txtAuthorPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Author Phone  is must Start with 6.", "Author Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (txtAuthorPhone.Text.Length < 9)
            {
                MessageBox.Show("Author Phone Is Invalid Number", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }

            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
  
           

            else
            {
                conn = myConnections.GetConnections();
                SqlDataAdapter sdt = new SqlDataAdapter("select name from author where name = '" + txtAuthorName.Text + "' ", conn);
                DataTable dtb = new DataTable();
                sdt.Fill(dtb);
                SqlDataAdapter sdt2 = new SqlDataAdapter("select phone from author where phone = '" + txtAuthorPhone.Text + "' ", conn);
                DataTable dtb2 = new DataTable();
                sdt2.Fill(dtb2);
                if (dtb.Rows.Count > 0)
                {
                    MessageBox.Show("This Author Name Is Alredy Exists", "Author Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuthorName.Focus();
                }

                else if (dtb2.Rows.Count > 0)
                {

                    MessageBox.Show("This Phone  Is Alredy Teken", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuthorPhone.Focus();


                }
                else
                {
                    AuthorInfo.registerAuthor(txtAuthorName.Text, txtAuthorAddress.Text, comBoxSex.Text, txtAuthorExperience.Text, txtAuthorPhone.Text);
                    AuthorInfo.loadAllAuthor(AuthorView);

                    makeAuthorEmpty();


                }






               
            }
        }

        private void makeAuthorEmpty()
        {
           
            txtAuthorName.Text = "";
            txtAuthorAddress.Text = "";
            comBoxSex.SelectedItem = "Select";
            txtAuthorExperience.Text = "";
            txtAuthorPhone.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void CellClickAuthor(object sender, DataGridViewCellEventArgs e)
        {


            if (myDash.role != "ADMIN")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
           // btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            int id = (int)AuthorView.SelectedRows[0].Cells[0].Value;
            txtAuthorName.Text = (string)AuthorView.SelectedRows[0].Cells[1].Value;
            txtAuthorAddress.Text = (string)AuthorView.SelectedRows[0].Cells[2].Value;
            comBoxSex.Text = (string)AuthorView.SelectedRows[0].Cells[3].Value;
            txtAuthorExperience.Text = (string)AuthorView.SelectedRows[0].Cells[4].Value;
            txtAuthorPhone.Text = (string)AuthorView.SelectedRows[0].Cells[5].Value;
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phone = txtAuthorPhone.Text;
            int updateId = (int)AuthorView.SelectedRows[0].Cells[0].Value;
            if (txtAuthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorName.Focus();
            }
            else if (txtAuthorName.Text.Trim().StartsWith("@") || (txtAuthorName.Text.Trim().StartsWith(",")
              || (txtAuthorName.Text.Trim().StartsWith(">")) || (txtAuthorName.Text.Trim().StartsWith("/")) ||
              (txtAuthorName.Text.Trim().StartsWith(".")) || (txtAuthorName.Text.Trim().StartsWith("?")) ||
              (txtAuthorName.Text.Trim().StartsWith("`")) || (txtAuthorName.Text.Trim().StartsWith("_")) ||
              (txtAuthorName.Text.Trim().StartsWith("-")) || (txtAuthorName.Text.Trim().StartsWith("=")) ||
              (txtAuthorName.Text.Trim().StartsWith("#")) || (txtAuthorName.Text.Trim().StartsWith("$")) ||
              (txtAuthorName.Text.Trim().StartsWith("!")) || (txtAuthorName.Text.Trim().StartsWith("%")) ||
              (txtAuthorName.Text.Trim().StartsWith("^")) || (txtAuthorName.Text.Trim().StartsWith("&")) ||
              (txtAuthorName.Text.Trim().StartsWith("(")) || (txtAuthorName.Text.Trim().StartsWith(")")) ||
              (txtAuthorName.Text.Trim().StartsWith("+")) || (txtAuthorName.Text.Trim().StartsWith("0")) ||
              (txtAuthorName.Text.Trim().StartsWith("1")) || (txtAuthorName.Text.Trim().StartsWith("2")) ||
              (txtAuthorName.Text.Trim().StartsWith("3")) || (txtAuthorName.Text.Trim().StartsWith("4")) ||
              (txtAuthorName.Text.Trim().StartsWith("5")) || (txtAuthorName.Text.Trim().StartsWith("6")) ||
              (txtAuthorName.Text.Trim().StartsWith("7")) || (txtAuthorName.Text.Trim().StartsWith("8")) ||
              (txtAuthorName.Text.Trim().StartsWith("9")) 
          ))
            {
                MessageBox.Show("Author Name  never start with any digit .", "Author Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorName.Focus();
            }

            else if (txtAuthorAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorAddress.Focus();
            }
            else if (txtAuthorAddress.Text.Trim().StartsWith("@") || (txtAuthorAddress.Text.Trim().StartsWith(",")
          || (txtAuthorAddress.Text.Trim().StartsWith(">")) || (txtAuthorAddress.Text.Trim().StartsWith("/")) ||
          (txtAuthorAddress.Text.Trim().StartsWith(".")) || (txtAuthorAddress.Text.Trim().StartsWith("?")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("`")) || (txtAuthorAddress.Text.Trim().StartsWith("_")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("-")) || (txtAuthorAddress.Text.Trim().StartsWith("=")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("#")) || (txtAuthorAddress.Text.Trim().StartsWith("$")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("!")) || (txtAuthorAddress.Text.Trim().StartsWith("%")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("^")) || (txtAuthorAddress.Text.Trim().StartsWith("&")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("(")) || (txtAuthorAddress.Text.Trim().StartsWith(")")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("+")) || (txtAuthorAddress.Text.Trim().StartsWith("0")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("1")) || (txtAuthorAddress.Text.Trim().StartsWith("2")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("3")) || (txtAuthorAddress.Text.Trim().StartsWith("4")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("5")) || (txtAuthorAddress.Text.Trim().StartsWith("6")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("7")) || (txtAuthorAddress.Text.Trim().StartsWith("8")) ||
          (txtAuthorAddress.Text.Trim().StartsWith("9")) 
      ))
            {
                MessageBox.Show("Author Address  never start with any digit .", "Author Address Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorAddress.Focus();
            }
            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Authir Gender Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (comBoxSex.SelectedItem == "Select")
            {
                MessageBox.Show("Authir Gender Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtAuthorExperience.Text.Trim().Equals(""))
            {
                MessageBox.Show("Experience Author Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorExperience.Text.Trim().StartsWith("@") || (txtAuthorExperience.Text.Trim().StartsWith(",")
                     || (txtAuthorExperience.Text.Trim().StartsWith(">")) || (txtAuthorExperience.Text.Trim().StartsWith("/")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith(".")) || (txtAuthorExperience.Text.Trim().StartsWith("?")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("`")) || (txtAuthorExperience.Text.Trim().StartsWith("_")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("-")) || (txtAuthorExperience.Text.Trim().StartsWith("=")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("#")) || (txtAuthorExperience.Text.Trim().StartsWith("$")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("!")) || (txtAuthorExperience.Text.Trim().StartsWith("%")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("^")) || (txtAuthorExperience.Text.Trim().StartsWith("&")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("(")) || (txtAuthorExperience.Text.Trim().StartsWith(")")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("+")) || (txtAuthorExperience.Text.Trim().StartsWith("*")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("a")) || (txtAuthorExperience.Text.Trim().StartsWith("g")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("b")) || (txtAuthorExperience.Text.Trim().StartsWith("h")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("c")) || (txtAuthorExperience.Text.Trim().StartsWith("i")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("b")) || (txtAuthorExperience.Text.Trim().StartsWith("j")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("e")) || (txtAuthorExperience.Text.Trim().StartsWith("k")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("l")) || (txtAuthorExperience.Text.Trim().StartsWith("q")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("m")) || (txtAuthorExperience.Text.Trim().StartsWith("r")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("n")) || (txtAuthorExperience.Text.Trim().StartsWith("s")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("o")) || (txtAuthorExperience.Text.Trim().StartsWith("t")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("p")) || (txtAuthorExperience.Text.Trim().StartsWith("u")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("v")) || (txtAuthorExperience.Text.Trim().StartsWith("A")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("w")) || (txtAuthorExperience.Text.Trim().StartsWith("B")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("x")) || (txtAuthorExperience.Text.Trim().StartsWith("C")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("y")) || (txtAuthorExperience.Text.Trim().StartsWith("D")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("z")) || (txtAuthorExperience.Text.Trim().StartsWith("E")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("F")) || (txtAuthorExperience.Text.Trim().StartsWith("O")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("G")) || (txtAuthorExperience.Text.Trim().StartsWith("P")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("H")) || (txtAuthorExperience.Text.Trim().StartsWith("Q")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("I")) || (txtAuthorExperience.Text.Trim().StartsWith("R")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("J")) || (txtAuthorExperience.Text.Trim().StartsWith("S")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("K")) || (txtAuthorExperience.Text.Trim().StartsWith("T")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("L")) || (txtAuthorExperience.Text.Trim().StartsWith("U")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("M")) || (txtAuthorExperience.Text.Trim().StartsWith("V")) ||
                     (txtAuthorExperience.Text.Trim().StartsWith("N")) || (txtAuthorExperience.Text.Trim().StartsWith("W")) ||
                    (txtAuthorExperience.Text.Trim().StartsWith("X")) || (txtAuthorExperience.Text.Trim().StartsWith("Y")) ||
                        (txtAuthorExperience.Text.Trim().StartsWith("Z")) 
                    
                 ))
            {
                MessageBox.Show("Author Experience  never start with any Character .", "Author Experience Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorExperience.Text == "0 Year" || txtAuthorExperience.Text == "0 years" || txtAuthorExperience.Text == "0 Years" || txtAuthorExperience.Text == "0 years")
            {
                MessageBox.Show("Sorry!. Author Experience Is Less then 1 Year", "Author Experience", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!(txtAuthorPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Author Phone  is must Start with 6.", "Author Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (txtAuthorPhone.Text.Length < 9)
            {
                MessageBox.Show("Author Phone Is Invalid Number", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 0))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 1))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 2))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 3))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 4))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 5))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 6))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 7))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
            else if (!char.IsDigit(phone, 8))
            {
                MessageBox.Show("Author Phone must be Digit", "Author Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }
           
            else
            {
                AuthorInfo.updateAuthor(txtAuthorName.Text, txtAuthorAddress.Text, comBoxSex.Text, txtAuthorExperience.Text, txtAuthorPhone.Text, updateId);
                AuthorInfo.loadAllAuthor(AuthorView);
                makeAuthorEmpty();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)AuthorView.SelectedRows[0].Cells[0].Value;
            if (txtAuthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorName.Focus();
            }

            else if (txtAuthorAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorAddress.Focus();
            }
            else if (comBoxSex.Text.Trim().Equals(""))
            {
                MessageBox.Show("Authir Gender Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxSex.Focus();
            }
            else if (txtAuthorExperience.Text.Trim().Equals(""))
            {
                MessageBox.Show("Experience Author Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorExperience.Focus();
            }
            else if (txtAuthorPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorPhone.Focus();
            }

            else
            {

                string name = txtAuthorName.Text = (string)AuthorView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Info?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    AuthorInfo.deleteAuthor(deletedId);
                    AuthorInfo.loadAllAuthor(AuthorView);
                    makeAuthorEmpty();
                }

            }
        }

        private void AuthorTextChanged(object sender, EventArgs e)
        {
           
        }

        public void serachText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select id 'Author ID' ,  name 'Author Name', address 'Author Address',sex 'Sex',experience 'Experience' , phone 'Author Phone'  , date 'Date' from author WHERE name LIKE '%" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if(dTable.Rows.Count > 0){
                    AuthorView.DataSource = dTable;
                    AuthorView.Visible = true;
                    lbl_display.Visible = false;
                }else{
                    AuthorView.Visible = false;
                    lbl_display.Visible = true;
                }

               

                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                serachText();
            }
            else
            {
                AuthorView.Visible = true;
                lbl_display.Visible = false;
                AuthorInfo.loadAllAuthor(AuthorView);
            }
        }

        
    }
}
