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
    public partial class Category : Form
    {
        public static SqlConnection conn;   
        public Category()
        {
            InitializeComponent();
        }
        public Category(string name, string type)
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtCategoryName.Text.Trim().Trim().Equals(""))
            {
                MessageBox.Show("Category Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }
            else if (txtCategoryName.Text.Trim().StartsWith("@") || (txtCategoryName.Text.Trim().StartsWith(",")
              || (txtCategoryName.Text.Trim().StartsWith(">")) || (txtCategoryName.Text.Trim().StartsWith("/")) ||
              (txtCategoryName.Text.Trim().StartsWith(".")) || (txtCategoryName.Text.Trim().StartsWith("?")) ||
              (txtCategoryName.Text.Trim().StartsWith("`")) || (txtCategoryName.Text.Trim().StartsWith("_")) ||
              (txtCategoryName.Text.Trim().StartsWith("-")) || (txtCategoryName.Text.Trim().StartsWith("=")) ||
              (txtCategoryName.Text.Trim().StartsWith("#")) || (txtCategoryName.Text.Trim().StartsWith("$")) ||
              (txtCategoryName.Text.Trim().StartsWith("!")) || (txtCategoryName.Text.Trim().StartsWith("%")) ||
              (txtCategoryName.Text.Trim().StartsWith("^")) || (txtCategoryName.Text.Trim().StartsWith("&")) ||
              (txtCategoryName.Text.Trim().StartsWith("(")) || (txtCategoryName.Text.Trim().StartsWith(")")) ||
              (txtCategoryName.Text.Trim().StartsWith("+")) || (txtCategoryName.Text.Trim().StartsWith("0")) ||
              (txtCategoryName.Text.Trim().StartsWith("1")) || (txtCategoryName.Text.Trim().StartsWith("2")) ||
              (txtCategoryName.Text.Trim().StartsWith("3")) || (txtCategoryName.Text.Trim().StartsWith("4")) ||
              (txtCategoryName.Text.Trim().StartsWith("5")) || (txtCategoryName.Text.Trim().StartsWith("6")) ||
              (txtCategoryName.Text.Trim().StartsWith("7")) || (txtCategoryName.Text.Trim().StartsWith("8")) ||
              (txtCategoryName.Text.Trim().StartsWith("9")) 
        ))
            {
                MessageBox.Show("Category Name never start with any digit .", "Category Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }

            else if (comBoxStatus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Category Status Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxStatus.Focus();
            }
            else if (comBoxStatus.SelectedItem == "Select")
            {
                MessageBox.Show("Category Status Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxStatus.Focus();
            }



            else
            {

                conn = myConnections.GetConnections();
                SqlDataAdapter sdt = new SqlDataAdapter("select catname from category where catname = '" + txtCategoryName.Text + "' ", conn);
                DataTable dtb = new DataTable();
                sdt.Fill(dtb);
                
                if (dtb.Rows.Count > 0)
                {
                    MessageBox.Show("This Category Name Is Alredy Exists", "Cateogy Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryName.Focus();
                }

               
                else
                {
                    CategoryInfo.registerCategory(txtCategoryName.Text, comBoxStatus.Text, DateTime.Parse(txtRegisterDate.Text));
                    CategoryInfo.loadAllCategory(CategoryView);
                    makeCategoryEmpty();
                

                }
               
               

            }


               

            
           
            
        }

        private void makeCategoryEmpty()
        {
            txtCategoryName.Text = "";
            comBoxStatus.SelectedItem = "Select";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            
          
            CategoryInfo.loadAllCategory(CategoryView);
            comBoxStatus.SelectedItem = "Select";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
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
            int id = (int)CategoryView.SelectedRows[0].Cells[0].Value;
            txtCategoryName.Text = (string)CategoryView.SelectedRows[0].Cells[1].Value;
            comBoxStatus.Text = (string)CategoryView.SelectedRows[0].Cells[2].Value;
            DateTime date = (DateTime)CategoryView.SelectedRows[0].Cells[3].Value;

            txtRegisterDate.Text = date.ToString();
            
           
        }

        public void disebleBtnDelete()
        {
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int updateId = (int)CategoryView.SelectedRows[0].Cells[0].Value;
            if (txtCategoryName.Text.Trim().Trim().Equals(""))
            {
                MessageBox.Show("Category Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }
            else if (txtCategoryName.Text.Trim().StartsWith("@") || (txtCategoryName.Text.Trim().StartsWith(",")
                    || (txtCategoryName.Text.Trim().StartsWith(">")) || (txtCategoryName.Text.Trim().StartsWith("/")) ||
                    (txtCategoryName.Text.Trim().StartsWith(".")) || (txtCategoryName.Text.Trim().StartsWith("?")) ||
                    (txtCategoryName.Text.Trim().StartsWith("`")) || (txtCategoryName.Text.Trim().StartsWith("_")) ||
                    (txtCategoryName.Text.Trim().StartsWith("-")) || (txtCategoryName.Text.Trim().StartsWith("=")) ||
                    (txtCategoryName.Text.Trim().StartsWith("#")) || (txtCategoryName.Text.Trim().StartsWith("$")) ||
                    (txtCategoryName.Text.Trim().StartsWith("!")) || (txtCategoryName.Text.Trim().StartsWith("%")) ||
                    (txtCategoryName.Text.Trim().StartsWith("^")) || (txtCategoryName.Text.Trim().StartsWith("&")) ||
                    (txtCategoryName.Text.Trim().StartsWith("(")) || (txtCategoryName.Text.Trim().StartsWith(")")) ||
                    (txtCategoryName.Text.Trim().StartsWith("+")) || (txtCategoryName.Text.Trim().StartsWith("0")) ||
                    (txtCategoryName.Text.Trim().StartsWith("1")) || (txtCategoryName.Text.Trim().StartsWith("2")) ||
                    (txtCategoryName.Text.Trim().StartsWith("3")) || (txtCategoryName.Text.Trim().StartsWith("4")) ||
                    (txtCategoryName.Text.Trim().StartsWith("5")) || (txtCategoryName.Text.Trim().StartsWith("6")) ||
                    (txtCategoryName.Text.Trim().StartsWith("7")) || (txtCategoryName.Text.Trim().StartsWith("8")) ||
                    (txtCategoryName.Text.Trim().StartsWith("9")) 
            ))
            {
                MessageBox.Show("Category Name never start with any digit .", "Category Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }
            else if (comBoxStatus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Category Status Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxStatus.Focus();
            }



            else
            {

                CategoryInfo.updateCategory(txtCategoryName.Text, comBoxStatus.Text, DateTime.Parse(txtRegisterDate.Text),updateId);
                CategoryInfo.loadAllCategory(CategoryView);
                makeCategoryEmpty();


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)CategoryView.SelectedRows[0].Cells[0].Value;
            if (txtCategoryName.Text.Trim().Trim().Equals(""))
            {
                MessageBox.Show("Category Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }

            else if (comBoxStatus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Category Status Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxStatus.Focus();
            }



            else
            {
                string name = txtCategoryName.Text = (string)CategoryView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Category?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    CategoryInfo.deleteCategory(deletedId);
                    CategoryInfo.loadAllCategory(CategoryView);
                    makeCategoryEmpty();
                }

               


            }

        }


        public void searchText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select id 'CategoryID' , catname 'Category Name', status 'Category Status', date 'Date'from category WHERE catname LIKE '%" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    CategoryView.DataSource = dTable;

                    CategoryView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    CategoryView.Visible = false;
                    lbl_display.Visible = true;
                }

               

                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void CategoryVewiTextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text != "")
            {
                searchText();
            }
            else
            {
                CategoryView.Visible = true;
                lbl_display.Visible = false;
                CategoryInfo.loadAllCategory(CategoryView);
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
                searchText();
            }
            else
            {
                CategoryView.Visible = true;
                lbl_display.Visible = false;
                CategoryInfo.loadAllCategory(CategoryView);
            }
        }
    }
}
