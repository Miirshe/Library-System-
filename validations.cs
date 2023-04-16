using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace DatabaseConnection
{
    public class validations
    {
        public static void  isEmpty(GunaTextBox fname, GunaTextBox lname, GunaTextBox username, GunaTextBox password)
        {
            if (fname.Text.Trim().Equals("") || lname.Text.Trim().Equals("") || username.Text.Trim().Equals("") || password.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Filed Are Required!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return false;
            }
         

            else
            {


                

               // return true;
               
            }

        }

        public  static void MakeEmpty(GunaTextBox fname, GunaTextBox lname, GunaTextBox username, GunaTextBox password)
        {
            fname.Text = "";
            lname.Text = "";
            username.Text = "";
            password.Text = "";
        }



        public static void validBooks(GunaTextBox bookName, GunaComboBox category, GunaComboBox author, GunaComboBox publisher, GunaTextBox description, GunaTextBox pages, GunaTextBox edition)
        {
            if(bookName.Text.Trim().Equals("")){
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookName.Focus();

            }
            else if (category.Text.Trim().Equals("")){
                MessageBox.Show("Categoty Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                category.Focus();
            }
            else if (author.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                author.Focus();
            }
            else if (publisher.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                publisher.Focus();
            }
            else if (description.Text.Trim().Equals(""))
            {
                MessageBox.Show("Description TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                description.Focus();
            }
            else if (pages.Text.Trim().Equals(""))
            {
                MessageBox.Show("Page TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pages.Focus();
            }
            else if (edition.Text.Trim().Equals(""))
            {
                MessageBox.Show("Edition TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edition.Focus();
            }
            else
            {
               // return true;
               // MakeEmpryBooks();
            }
        }

        public static void MakeEmpryBooks(GunaTextBox bookName, GunaComboBox category, GunaComboBox author, GunaComboBox publisher, GunaTextBox description, GunaTextBox pages, GunaTextBox edition)
        {
            bookName.Text = "";
            category.Text = "";
            author.Text = "";
            publisher.Text = "";
            description.Text = "";
            pages.Text = "";
            edition.Text = "";
           
        }



        public static void validLendBook(GunaTextBox memberId, GunaTextBox memberName, GunaComboBox bookName)
        {
            if (memberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                memberId.Focus();
            }
            else if (memberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                memberName.Focus();
            }
            else if (bookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookName.Focus();
            }
            
            else
            {
                MessageBox.Show("Successfully Regsiter", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MakeEmptLendyBooks(memberId, memberName, bookName);
                
            }
        }

        private static void MakeEmptLendyBooks(GunaTextBox memberId, GunaTextBox memberName, GunaComboBox bookName)
        {
            memberId.Text = "";
            memberName.Text = "";
            bookName.Text = "";
        }


        public static void validAuthor(GunaTextBox authorname,  GunaTextBox address, GunaTextBox experience, GunaTextBox phone)
        {
            if (authorname.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authorname.Focus();
            }

            else if (address.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                address.Focus();
            }
            else if (experience.Text.Trim().Equals(""))
            {
                MessageBox.Show("Experience Author Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                experience.Focus();
            }
            else if (phone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Author Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.Focus();
            }

            else
            {
                MessageBox.Show("Successfully Regsiter", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MakeEmptyAuthor(authorname, address, experience, phone);

            }
        }

        private static void MakeEmptyAuthor(GunaTextBox  authorname,  GunaTextBox address, GunaTextBox experience, GunaTextBox phone)
        {
            authorname.Text = "";
            address.Text = "";
            experience.Text = "";
            phone.Text = "";

        }

        public static void validReturnBook(GunaTextBox memberId, GunaComboBox bookName, GunaTextBox dayElapsed, GunaTextBox fine)
        {
            if (memberId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                memberId.Focus();
            }

            else if (bookName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Book Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookName.Focus();
            }
            else if (dayElapsed.Text.Trim().Equals(""))
            {
                MessageBox.Show("Day Elapsed TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dayElapsed.Focus();
            }
            else if (fine.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fine TextBox Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fine.Focus();
            }

            else
            {
                MessageBox.Show("Successfully Regsiter", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MakeEmptyRuturnBooks(memberId, bookName, dayElapsed, fine);

            }
        }

        private static void MakeEmptyRuturnBooks(GunaTextBox memberId, GunaComboBox bookName, GunaTextBox dayElapsed, GunaTextBox fine)
        {
            memberId.Text = "";
            bookName.Text = "";
            dayElapsed.Text = "";
            fine.Text = "";

        }





        public static void validPublisher(GunaTextBox publishername, GunaTextBox address, GunaTextBox phone)
        {
            if (publishername.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                publishername.Focus();
            }

            else if (address.Text.Trim().Equals(""))
            {
                MessageBox.Show("Publisher Address Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                address.Focus();
            }
           
            else if (phone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Puplisher Phone Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.Focus();
            }

            else
            {
                MessageBox.Show("Successfully Regsiter", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MakeEmptyPublisher(publishername, address, phone);

            }
        }

        private static void MakeEmptyPublisher(GunaTextBox publishername, GunaTextBox address,  GunaTextBox phone)
        {
            publishername.Text = "";
            address.Text = "";
            phone.Text = "";

        }






        public static void  validCategory(GunaTextBox cateogoryname, GunaComboBox status)
        {
            if (cateogoryname.Text.Trim().Equals(""))
            {
                MessageBox.Show("Category Name Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cateogoryname.Focus();
            }

            else if (status.Text.Trim().Equals(""))
            {
                MessageBox.Show("Category Status Is Empty. Please try and Check Again.", "EMPTY?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Focus();
            }

           

            else
            {
                //return true;

            }
        }

        private static void MakeEmptyCategory(GunaTextBox cateogoryname, GunaComboBox status)
        {
            cateogoryname.Text = "";
            status.Text = "";
           

        }





    }


 

    
}
