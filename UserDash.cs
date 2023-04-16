using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class UserDash : Form
    {
        public static Label countAuthorLabel;
        public static Label countBookLabel;
        public static Label countMemberLabel;
        public static Label countReturnBookLabel;
        public UserDash()
        {
            InitializeComponent();
        }

        private void UserDash_Load(object sender, EventArgs e)
        {

            countAuthorLabel = lbllDisplayAuthor;
            AuthorInfo.CountAuthor(lbllDisplayAuthor);


            countBookLabel = lblDisplayBook;
            BookInfo.CountBook(lblDisplayBook);

            countMemberLabel = lblDisplayMember;
            MemberInfo.CountMember(lblDisplayMember);

            countReturnBookLabel = lblDisplayReturnBook;
            ReturnBookInfo.CountReturnBook(lblDisplayReturnBook);
            Dash.CountAvaibleBooks(lblAvailableBooks);

            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
