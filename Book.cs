using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.SqlClient;
using System.IO;

namespace DatabaseConnection
{
    public partial class Book : Form
    {
        public static SqlConnection conn;
        public static string ImageName;
        public Book()
        {
            InitializeComponent();
        }

        private void registerBook(object sender, EventArgs e)
        {
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();

            }
            else if (txtBookName.Text.Trim().StartsWith("@") || (txtBookName.Text.Trim().StartsWith(",")
              || (txtBookName.Text.Trim().StartsWith(">")) || (txtBookName.Text.Trim().StartsWith("/")) ||
              (txtBookName.Text.Trim().StartsWith(".")) || (txtBookName.Text.Trim().StartsWith("?")) ||
              (txtBookName.Text.Trim().StartsWith("`")) || (txtBookName.Text.Trim().StartsWith("_")) ||
              (txtBookName.Text.Trim().StartsWith("-")) || (txtBookName.Text.Trim().StartsWith("=")) ||
              (txtBookName.Text.Trim().StartsWith("#")) || (txtBookName.Text.Trim().StartsWith("$")) ||
              (txtBookName.Text.Trim().StartsWith("!")) || (txtBookName.Text.Trim().StartsWith("%")) ||
              (txtBookName.Text.Trim().StartsWith("^")) || (txtBookName.Text.Trim().StartsWith("&")) ||
              (txtBookName.Text.Trim().StartsWith("(")) || (txtBookName.Text.Trim().StartsWith(")")) ||
              (txtBookName.Text.Trim().StartsWith("+")) || (txtBookName.Text.Trim().StartsWith("0")) ||
              (txtBookName.Text.Trim().StartsWith("1")) || (txtBookName.Text.Trim().StartsWith("2")) ||
              (txtBookName.Text.Trim().StartsWith("3")) || (txtBookName.Text.Trim().StartsWith("4")) ||
              (txtBookName.Text.Trim().StartsWith("5")) || (txtBookName.Text.Trim().StartsWith("6")) ||
              (txtBookName.Text.Trim().StartsWith("7")) || (txtBookName.Text.Trim().StartsWith("8")) ||
              (txtBookName.Text.Trim().StartsWith("9")) || (txtBookName.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Name  never start with any digit .", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (txtPublisherName.Text.Trim().Equals(""))
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
                MessageBox.Show("Publisher Name  never start with any digit .", "Publisher Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }
            else if (comBoxBookType.SelectedItem == "Select")
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Value == 0)
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "Page Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookPages.Value < 30)
            {
                MessageBox.Show("Book Pages is less then  30 page", "Book Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }

            else if (txtBookEdition.SelectedItem == "Select")
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else if (bookPicture.Image == null)
            {
                MessageBox.Show("Book Picture is Empty Please choose Image", "Book Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                butBrowsers.Focus();
            }
            else
            {
                string bookName = txtBookName.Text;
                int categoryName = int.Parse(comBoxCategory.SelectedValue.ToString());
                int authorName = int.Parse(comBoxAthorName.SelectedValue.ToString());
                string publisherName = txtPublisherName.Text;
                string bookType = comBoxBookType.Text;
                int pages = int.Parse(txtBookPages.Value.ToString());
                int qtty = int.Parse(txtQtty.Value.ToString());
                string edition = txtBookEdition.Text;

                BookInfo.registerBooks(bookName, categoryName, authorName, publisherName, bookType, pages, qtty, qtty, bookPicture.Image, edition);
                BookInfo.loadAllBooks(BookView);
                MakeEmpryBooks();
            }



        }

        private void MakeEmpryBooks()
        {
            txtBookName.Text = "";
            comBoxCategory.Text = "";
            txtPublisherName.Text = "";
            txtPublisherName.Text = "";
            comBoxBookType.SelectedItem = "Select";
            txtBookPages.Value = 30;
            txtQtty.Value = 0;
            txtBookEdition.SelectedItem = "Select";
            bookPicture.Image = null;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void Book_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            BookInfo.loadAllBooks(BookView);
            categoryName();
            AuthorName();
            //PublisherName();

            txtBookEdition.SelectedItem = "Select";
            comBoxBookType.SelectedItem = "Select";


        }




        public void categoryName()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM category where status = 'active'", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxCategory.DataSource = d_table.Tables[0];
            comBoxCategory.DisplayMember = "catname";
            comBoxCategory.ValueMember = "id";

            conn.Close();
        }



        public void AuthorName()
        {
            conn = myConnections.GetConnections();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM author", conn);
            SqlDataAdapter reader = new SqlDataAdapter(cmd);
            DataSet d_table = new DataSet();
            reader.Fill(d_table);
            comBoxAthorName.DataSource = d_table.Tables[0];
            comBoxAthorName.DisplayMember = "name";
            comBoxAthorName.ValueMember = "id";

            conn.Close();
        }



        //public void PublisherName()
        //{
        //    conn = myConnections.GetConnections();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM publisher", conn);
        //    SqlDataAdapter reader = new SqlDataAdapter(cmd);
        //    DataSet d_table = new DataSet();
        //    reader.Fill(d_table);
        //    txtPublisherName.DataSource = d_table.Tables[0];
        //    txtPublisherName.DisplayMember = "name";
        //    txtPublisherName.ValueMember = "id";

        //    conn.Close();
        //}

        //private void clicked(object sender, EventArgs e)
        //{
        //    categoryName();
        //}

        //private void clikedAuthor(object sender, EventArgs e)
        //{
        //    AuthorName();

        //}

        //private void ClikedPublisher(object sender, MouseEventArgs e)
        //{
        //    PublisherName();
        //}

        private void BookCellClik(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = (int)BookView.SelectedRows[0].Cells[0].Value;
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();

            }
            else if (txtBookName.Text.Trim().StartsWith("@") || (txtBookName.Text.Trim().StartsWith(",")
              || (txtBookName.Text.Trim().StartsWith(">")) || (txtBookName.Text.Trim().StartsWith("/")) ||
              (txtBookName.Text.Trim().StartsWith(".")) || (txtBookName.Text.Trim().StartsWith("?")) ||
              (txtBookName.Text.Trim().StartsWith("`")) || (txtBookName.Text.Trim().StartsWith("_")) ||
              (txtBookName.Text.Trim().StartsWith("-")) || (txtBookName.Text.Trim().StartsWith("=")) ||
              (txtBookName.Text.Trim().StartsWith("#")) || (txtBookName.Text.Trim().StartsWith("$")) ||
              (txtBookName.Text.Trim().StartsWith("!")) || (txtBookName.Text.Trim().StartsWith("%")) ||
              (txtBookName.Text.Trim().StartsWith("^")) || (txtBookName.Text.Trim().StartsWith("&")) ||
              (txtBookName.Text.Trim().StartsWith("(")) || (txtBookName.Text.Trim().StartsWith(")")) ||
              (txtBookName.Text.Trim().StartsWith("+")) || (txtBookName.Text.Trim().StartsWith("0")) ||
              (txtBookName.Text.Trim().StartsWith("1")) || (txtBookName.Text.Trim().StartsWith("2")) ||
              (txtBookName.Text.Trim().StartsWith("3")) || (txtBookName.Text.Trim().StartsWith("4")) ||
              (txtBookName.Text.Trim().StartsWith("5")) || (txtBookName.Text.Trim().StartsWith("6")) ||
              (txtBookName.Text.Trim().StartsWith("7")) || (txtBookName.Text.Trim().StartsWith("8")) ||
              (txtBookName.Text.Trim().StartsWith("9")) || (txtBookName.Text.Trim().StartsWith(" "))
              ))
            {
                MessageBox.Show("Book Name  never start with any digit .", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (txtPublisherName.Text.Trim().Equals(""))
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
                MessageBox.Show("Publisher Name  never start with any digit .", "Publisher Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }
            else if (comBoxBookType.SelectedItem == "Select")
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Value == 0)
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "Page Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookPages.Value < 30)
            {
                MessageBox.Show("Book Pages is less then  30 page", "Book Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }

            else if (txtBookEdition.SelectedItem == "Select")
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else if (bookPicture.Image == null)
            {
                MessageBox.Show("Book Picture is Empty Please choose Image", "Book Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                butBrowsers.Focus();
            }


            else
            {
                string bookName = txtBookName.Text;
                int categoryName = int.Parse(comBoxCategory.SelectedValue.ToString());
                int authorName = int.Parse(comBoxAthorName.SelectedValue.ToString());
                string publisherName = txtPublisherName.Text;
                string bookType = comBoxBookType.Text;
                int pages = int.Parse(txtBookPages.Value.ToString());
                int qtty = int.Parse(txtQtty.Value.ToString());
                string edition = txtBookEdition.Text;

                BookInfo.updateBooks(bookName, categoryName, authorName, publisherName, bookType, pages, qtty, bookPicture.Image, edition, updatedId);
                BookInfo.loadAllBooks(BookView);
                MakeEmpryBooks();
            }
        }






        public void serachText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select book.id 'BookID', book.name 'Book Name', category.catname 'Category Name', author.name 'Author Name', book.pname 'Publisher Name', book.type 'Book Type', book.pages 'Pages', book.qtty 'Quantity', book.bphoto 'Image', book.edition 'Edition' ,book.date 'Date' from book INNER JOIN category ON book.cid = category.id INNER JOIN author ON book.aid = author.id INNER JOIN publisher ON book.pid = publisher.id WHERE book.name LIKE '" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    BookView.DataSource = dTable;
                    BookView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    BookView.Visible = false;
                    lbl_display.Visible = true;

                }



                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void BookTextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                serachText();
            }
            else
            {
                lbl_display.Visible = false;
                BookView.Visible = true;
                BookInfo.loadAllBooks(BookView);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)BookView.SelectedRows[0].Cells[0].Value;
            if (txtBookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();

            }
            else if (comBoxCategory.Text.Trim().Equals(""))
            {
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxCategory.Focus();
            }
            else if (comBoxAthorName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxAthorName.Focus();
            }
            else if (txtPublisherName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisherName.Focus();
            }
            else if (comBoxBookType.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Type TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxBookType.Focus();
            }
            else if (txtBookPages.Value == 0)
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookPages.Focus();
            }
            else if (txtBookEdition.Text.Trim().Equals(""))
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookEdition.Focus();
            }
            else
            {


                string name = txtBookPages.Text = (string)BookView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Book?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    BookInfo.deleteBook(deletedId);
                    BookInfo.loadAllBooks(BookView);
                    MakeEmpryBooks();
                }

            }
        }

        private void BookView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            int id = (int)BookView.SelectedRows[0].Cells[0].Value;
            txtBookName.Text = (string)BookView.SelectedRows[0].Cells[1].Value;
            comBoxCategory.Text = (string)BookView.SelectedRows[0].Cells[2].Value;
            comBoxAthorName.Text = (string)BookView.SelectedRows[0].Cells[3].Value;
            txtPublisherName.Text = (string)BookView.SelectedRows[0].Cells[4].Value;
            comBoxBookType.Text = (string)BookView.SelectedRows[0].Cells[5].Value;
            txtBookPages.Value = (int)BookView.SelectedRows[0].Cells[6].Value;
            txtQtty.Value = (int)BookView.SelectedRows[0].Cells[7].Value;
            txtBookEdition.Text = (string)BookView.SelectedRows[0].Cells[9].Value;
            bookPicture.SizeMode = PictureBoxSizeMode.Zoom;
            bookPicture.Image = getBookImage(id);

        }






        private void butBrowsers_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Image File(*.jpg;*.bmo;*.gif;*.png;) | *.jpg;*.bmo;*.gif;*.png;";
            try
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    ImageName = fd.FileName;
                    Bitmap newImg = new Bitmap(ImageName);
                    bookPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    bookPicture.Image = (Image)newImg;
                }
                fd = null;
            }
            catch (System.ArgumentException ae)
            {
                ImageName = " ";
                MessageBox.Show(ae.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private Image getBookImage(int id)
        {
            conn = myConnections.GetConnections();
            conn.Open();
            var cmd = new SqlCommand("searchbookimage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            reader.Read();
            var img = BookInfo.getImage(reader[0]);
            conn.Close();
            return img;
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
                BookView.Visible = true;
                lbl_display.Visible = false;
                BookInfo.loadAllBooks(BookView);
            }
        }

        private void searchText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select book.id 'BookID', book.name 'Book Name', category.catname 'Category Name',author.name 'Author Name', book.pname 'Publisher Name', book.type 'Book Type',book.pages 'Pages', book.qtty 'Quantity',book.aqtty 'Available', book.edition 'Edition' ,book.date 'Date' from book INNER JOIN category ON book.cid = category.id INNER JOIN author ON book.aid = author.id WHERE book.name LIKE '%" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    BookView.DataSource = dTable;
                    BookView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    BookView.Visible = false;
                    lbl_display.Visible = true;
                }



                cmd.ExecuteNonQuery();

                conn.Close();
            }




        }
    }
}
