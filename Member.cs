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
    public partial class Member : Form
    {
        public static SqlConnection conn;
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            MemberInfo.loadAllMembers(MemberView);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bphone =txtBailedphone.Text;
            string mphone = txtMemberPhone.Text;
            if (txtMemberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }
            else if (txtMemberName.Text.Trim().StartsWith("@") || (txtMemberName.Text.Trim().StartsWith(",")
                || (txtMemberName.Text.Trim().StartsWith(">")) || (txtMemberName.Text.Trim().StartsWith("/")) ||
                (txtMemberName.Text.Trim().StartsWith(".")) || (txtMemberName.Text.Trim().StartsWith("?")) ||
                (txtMemberName.Text.Trim().StartsWith("`")) || (txtMemberName.Text.Trim().StartsWith("_")) ||
                (txtMemberName.Text.Trim().StartsWith("-")) || (txtMemberName.Text.Trim().StartsWith("=")) ||
                (txtMemberName.Text.Trim().StartsWith("#")) || (txtMemberName.Text.Trim().StartsWith("$")) ||
                (txtMemberName.Text.Trim().StartsWith("!")) || (txtMemberName.Text.Trim().StartsWith("%")) ||
                (txtMemberName.Text.Trim().StartsWith("^")) || (txtMemberName.Text.Trim().StartsWith("&")) ||
                (txtMemberName.Text.Trim().StartsWith("(")) || (txtMemberName.Text.Trim().StartsWith(")")) ||
                (txtMemberName.Text.Trim().StartsWith("+")) || (txtMemberName.Text.Trim().StartsWith("0")) ||
                (txtMemberName.Text.Trim().StartsWith("1")) || (txtMemberName.Text.Trim().StartsWith("2")) ||
                (txtMemberName.Text.Trim().StartsWith("3")) || (txtMemberName.Text.Trim().StartsWith("4")) ||
                (txtMemberName.Text.Trim().StartsWith("5")) || (txtMemberName.Text.Trim().StartsWith("6")) ||
                (txtMemberName.Text.Trim().StartsWith("7")) || (txtMemberName.Text.Trim().StartsWith("8")) ||
                (txtMemberName.Text.Trim().StartsWith("9"))
                ))
            {
                MessageBox.Show("Member Name  never start with any digit .", "Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }
            else if (txtMemberAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Address is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberAddress.Focus();
            }
            else if (txtMemberAddress.Text.Trim().StartsWith("@") || (txtMemberAddress.Text.Trim().StartsWith(",")
                || (txtMemberAddress.Text.Trim().StartsWith(">")) || (txtMemberAddress.Text.Trim().StartsWith("/")) ||
                (txtMemberAddress.Text.Trim().StartsWith(".")) || (txtMemberAddress.Text.Trim().StartsWith("?")) ||
                (txtMemberAddress.Text.Trim().StartsWith("`")) || (txtMemberAddress.Text.Trim().StartsWith("_")) ||
                (txtMemberAddress.Text.Trim().StartsWith("-")) || (txtMemberAddress.Text.Trim().StartsWith("=")) ||
                (txtMemberAddress.Text.Trim().StartsWith("#")) || (txtMemberAddress.Text.Trim().StartsWith("$")) ||
                (txtMemberAddress.Text.Trim().StartsWith("!")) || (txtMemberAddress.Text.Trim().StartsWith("%")) ||
                (txtMemberAddress.Text.Trim().StartsWith("^")) || (txtMemberAddress.Text.Trim().StartsWith("&")) ||
                (txtMemberAddress.Text.Trim().StartsWith("(")) || (txtMemberAddress.Text.Trim().StartsWith(")")) ||
                (txtMemberAddress.Text.Trim().StartsWith("+")) || (txtMemberAddress.Text.Trim().StartsWith("0")) ||
                (txtMemberAddress.Text.Trim().StartsWith("1")) || (txtMemberAddress.Text.Trim().StartsWith("2")) ||
                (txtMemberAddress.Text.Trim().StartsWith("3")) || (txtMemberAddress.Text.Trim().StartsWith("4")) ||
                (txtMemberAddress.Text.Trim().StartsWith("5")) || (txtMemberAddress.Text.Trim().StartsWith("6")) ||
                (txtMemberAddress.Text.Trim().StartsWith("7")) || (txtMemberAddress.Text.Trim().StartsWith("8")) ||
                (txtMemberAddress.Text.Trim().StartsWith("9")) 
                ))
            {
                MessageBox.Show("Member Address  never start with any digit .", "Member Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberAddress.Focus();
            }
            else if (txtMemberEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Email is Empty. Please Try And Check Again!", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if(txtMemberEmail.Text.StartsWith("@gmail.com")){
                MessageBox.Show("Member Email Is incorrect Format '@gmail.com' Naver start", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if (!txtMemberEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Member Email Is incorrect Format '@gmail.com' is missing", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if (txtBailedName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Name is Empty. Please Try And Check Again!", "Bailed Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedName.Focus();
            }
            else if (txtBailedName.Text.Trim().StartsWith("@") || (txtBailedName.Text.Trim().StartsWith(",")
                 || (txtBailedName.Text.Trim().StartsWith(">")) || (txtBailedName.Text.Trim().StartsWith("/")) ||
                 (txtBailedName.Text.Trim().StartsWith(".")) || (txtBailedName.Text.Trim().StartsWith("?")) ||
                 (txtBailedName.Text.Trim().StartsWith("`")) || (txtBailedName.Text.Trim().StartsWith("_")) ||
                 (txtBailedName.Text.Trim().StartsWith("-")) || (txtBailedName.Text.Trim().StartsWith("=")) ||
                 (txtBailedName.Text.Trim().StartsWith("#")) || (txtBailedName.Text.Trim().StartsWith("$")) ||
                 (txtBailedName.Text.Trim().StartsWith("!")) || (txtBailedName.Text.Trim().StartsWith("%")) ||
                 (txtBailedName.Text.Trim().StartsWith("^")) || (txtBailedName.Text.Trim().StartsWith("&")) ||
                 (txtBailedName.Text.Trim().StartsWith("(")) || (txtBailedName.Text.Trim().StartsWith(")")) ||
                 (txtBailedName.Text.Trim().StartsWith("+")) || (txtBailedName.Text.Trim().StartsWith("0")) ||
                 (txtBailedName.Text.Trim().StartsWith("1")) || (txtBailedName.Text.Trim().StartsWith("2")) ||
                 (txtBailedName.Text.Trim().StartsWith("3")) || (txtBailedName.Text.Trim().StartsWith("4")) ||
                 (txtBailedName.Text.Trim().StartsWith("5")) || (txtBailedName.Text.Trim().StartsWith("6")) ||
                 (txtBailedName.Text.Trim().StartsWith("7")) || (txtBailedName.Text.Trim().StartsWith("8")) ||
                 (txtBailedName.Text.Trim().StartsWith("9")) 
             ))
            {
                MessageBox.Show("Bailed Name  never start with any digit .", "Bailed Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedName.Focus();
            }
            else if (txtBailedphone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Phone is Empty. Please Try And Check Again!", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (!(txtBailedphone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Bailed Phone number is must Start with 6.", "Bailed Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (txtBailedphone.Text.Length < 9)
            {
                MessageBox.Show("Bailed Phone Is Invalid Number", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 0))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 1))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 2))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 3))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 4))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 5))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 6))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 7))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 8))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }

            else if (txtMemberPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Phone is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!(txtMemberPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Member Phone number is must Start with 6.", "Member Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
          
            else if (txtMemberPhone.Text.Length < 9)
            {
                MessageBox.Show("Memeber Phone Is Invalid Number", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 0))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 1))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 2))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 3))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 4))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 5))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 6))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 7))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 8))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtMemberPhone.Focus();
            }
            else
            {
                conn = myConnections.GetConnections();
                SqlDataAdapter sdt = new SqlDataAdapter("select bphone from member where bphone = '" + txtBailedphone.Text + "' ", conn);
                DataTable dtb = new DataTable();
                sdt.Fill(dtb);
                SqlDataAdapter sdt2 = new SqlDataAdapter("select phone from member where phone = '" + txtMemberPhone.Text + "' ", conn);
                DataTable dtb2 = new DataTable();
                sdt2.Fill(dtb2);
                if (dtb.Rows.Count > 0)
                {
                    MessageBox.Show("This Bialed Phone Is Alredy Exists", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBailedphone.Focus();
                }

                else if (dtb2.Rows.Count > 0)
                {

                    MessageBox.Show("This Member Phone Is Alredy Teken", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberPhone.Focus();


                }
                else
                {
                    MemberInfo.registerMembers(txtMemberName.Text, txtMemberAddress.Text,txtMemberEmail.Text, txtBailedName.Text, txtBailedphone.Text, txtMemberPhone.Text);
                    MemberInfo.loadAllMembers(MemberView);
                    makeEmptyMember();

                }



                
            }

        }

        private void makeEmptyMember()
        {
            txtMemberName.Text = "";
            txtMemberAddress.Text = "";
            txtMemberEmail.Text = "";
            txtBailedName.Text = "";
            txtBailedphone.Text = "";
            txtMemberPhone.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bphone = txtBailedphone.Text;
            string mphone = txtMemberPhone.Text;
            int updateId = (int)MemberView.SelectedRows[0].Cells[0].Value;
            if (txtMemberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }
            else if (txtMemberName.Text.Trim().StartsWith("@") || (txtMemberName.Text.Trim().StartsWith(",")
                || (txtMemberName.Text.Trim().StartsWith(">")) || (txtMemberName.Text.Trim().StartsWith("/")) ||
                (txtMemberName.Text.Trim().StartsWith(".")) || (txtMemberName.Text.Trim().StartsWith("?")) ||
                (txtMemberName.Text.Trim().StartsWith("`")) || (txtMemberName.Text.Trim().StartsWith("_")) ||
                (txtMemberName.Text.Trim().StartsWith("-")) || (txtMemberName.Text.Trim().StartsWith("=")) ||
                (txtMemberName.Text.Trim().StartsWith("#")) || (txtMemberName.Text.Trim().StartsWith("$")) ||
                (txtMemberName.Text.Trim().StartsWith("!")) || (txtMemberName.Text.Trim().StartsWith("%")) ||
                (txtMemberName.Text.Trim().StartsWith("^")) || (txtMemberName.Text.Trim().StartsWith("&")) ||
                (txtMemberName.Text.Trim().StartsWith("(")) || (txtMemberName.Text.Trim().StartsWith(")")) ||
                (txtMemberName.Text.Trim().StartsWith("+")) || (txtMemberName.Text.Trim().StartsWith("0")) ||
                (txtMemberName.Text.Trim().StartsWith("1")) || (txtMemberName.Text.Trim().StartsWith("2")) ||
                (txtMemberName.Text.Trim().StartsWith("3")) || (txtMemberName.Text.Trim().StartsWith("4")) ||
                (txtMemberName.Text.Trim().StartsWith("5")) || (txtMemberName.Text.Trim().StartsWith("6")) ||
                (txtMemberName.Text.Trim().StartsWith("7")) || (txtMemberName.Text.Trim().StartsWith("8")) ||
                (txtMemberName.Text.Trim().StartsWith("9")) 
                ))
            {
                MessageBox.Show("Member Name  never start with any digit .", "Member Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }
            else if (txtMemberAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Address is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberAddress.Focus();
            }
            else if (txtMemberAddress.Text.Trim().StartsWith("@") || (txtMemberAddress.Text.Trim().StartsWith(",")
                || (txtMemberAddress.Text.Trim().StartsWith(">")) || (txtMemberAddress.Text.Trim().StartsWith("/")) ||
                (txtMemberAddress.Text.Trim().StartsWith(".")) || (txtMemberAddress.Text.Trim().StartsWith("?")) ||
                (txtMemberAddress.Text.Trim().StartsWith("`")) || (txtMemberAddress.Text.Trim().StartsWith("_")) ||
                (txtMemberAddress.Text.Trim().StartsWith("-")) || (txtMemberAddress.Text.Trim().StartsWith("=")) ||
                (txtMemberAddress.Text.Trim().StartsWith("#")) || (txtMemberAddress.Text.Trim().StartsWith("$")) ||
                (txtMemberAddress.Text.Trim().StartsWith("!")) || (txtMemberAddress.Text.Trim().StartsWith("%")) ||
                (txtMemberAddress.Text.Trim().StartsWith("^")) || (txtMemberAddress.Text.Trim().StartsWith("&")) ||
                (txtMemberAddress.Text.Trim().StartsWith("(")) || (txtMemberAddress.Text.Trim().StartsWith(")")) ||
                (txtMemberAddress.Text.Trim().StartsWith("+")) || (txtMemberAddress.Text.Trim().StartsWith("0")) ||
                (txtMemberAddress.Text.Trim().StartsWith("1")) || (txtMemberAddress.Text.Trim().StartsWith("2")) ||
                (txtMemberAddress.Text.Trim().StartsWith("3")) || (txtMemberAddress.Text.Trim().StartsWith("4")) ||
                (txtMemberAddress.Text.Trim().StartsWith("5")) || (txtMemberAddress.Text.Trim().StartsWith("6")) ||
                (txtMemberAddress.Text.Trim().StartsWith("7")) || (txtMemberAddress.Text.Trim().StartsWith("8")) ||
                (txtMemberAddress.Text.Trim().StartsWith("9")) 
                ))
            {
                MessageBox.Show("Member Address  never start with any digit .", "Member Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberAddress.Focus();
            }
            else if (txtMemberEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Email is Empty. Please Try And Check Again!", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if (txtMemberEmail.Text.StartsWith("@gmail.com"))
            {
                MessageBox.Show("Member Email Is incorrect Format '@gmail.com' Naver start", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if (!txtMemberEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Member Email Is incorrect Format '@gmail.com' is missing", "Member Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberEmail.Focus();
            }
            else if (txtBailedName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Name is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedName.Focus();
            }
            else if (txtBailedName.Text.Trim().StartsWith("@") || (txtBailedName.Text.Trim().StartsWith(",")
                 || (txtBailedName.Text.Trim().StartsWith(">")) || (txtBailedName.Text.Trim().StartsWith("/")) ||
                 (txtBailedName.Text.Trim().StartsWith(".")) || (txtBailedName.Text.Trim().StartsWith("?")) ||
                 (txtBailedName.Text.Trim().StartsWith("`")) || (txtBailedName.Text.Trim().StartsWith("_")) ||
                 (txtBailedName.Text.Trim().StartsWith("-")) || (txtBailedName.Text.Trim().StartsWith("=")) ||
                 (txtBailedName.Text.Trim().StartsWith("#")) || (txtBailedName.Text.Trim().StartsWith("$")) ||
                 (txtBailedName.Text.Trim().StartsWith("!")) || (txtBailedName.Text.Trim().StartsWith("%")) ||
                 (txtBailedName.Text.Trim().StartsWith("^")) || (txtBailedName.Text.Trim().StartsWith("&")) ||
                 (txtBailedName.Text.Trim().StartsWith("(")) || (txtBailedName.Text.Trim().StartsWith(")")) ||
                 (txtBailedName.Text.Trim().StartsWith("+")) || (txtBailedName.Text.Trim().StartsWith("0")) ||
                 (txtBailedName.Text.Trim().StartsWith("1")) || (txtBailedName.Text.Trim().StartsWith("2")) ||
                 (txtBailedName.Text.Trim().StartsWith("3")) || (txtBailedName.Text.Trim().StartsWith("4")) ||
                 (txtBailedName.Text.Trim().StartsWith("5")) || (txtBailedName.Text.Trim().StartsWith("6")) ||
                 (txtBailedName.Text.Trim().StartsWith("7")) || (txtBailedName.Text.Trim().StartsWith("8")) ||
                 (txtBailedName.Text.Trim().StartsWith("9")) 
             ))
            {
                MessageBox.Show("Bailed Name  never start with any digit .", "Bailed Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedName.Focus();
            }
            else if (txtBailedphone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Phone is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (!(txtBailedphone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Bailed Phone number is must Start with 6.", "Bailed Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (txtBailedphone.Text.Length < 9)
            {
                MessageBox.Show("Bailed Phone Is Invalid Number", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 0))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 1))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 2))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 3))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 4))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 5))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 6))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 7))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }
            else if (!char.IsDigit(bphone, 8))
            {
                MessageBox.Show("Bailed Phone must be Digit", "Bailed Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedphone.Focus();
            }

            else if (txtMemberPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Phone is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!(txtMemberPhone.Text.Trim().StartsWith("6")))
            {
                MessageBox.Show("Member Phone number is must Start with 6.", "Member Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }

            else if (txtMemberPhone.Text.Length < 9)
            {
                MessageBox.Show("Memeber Phone Is Invalid Number", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 0))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 1))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 2))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 3))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 4))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 5))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 6))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 7))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else if (!char.IsDigit(mphone, 8))
            {
                MessageBox.Show("Member Phone must be Digit", "Member Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }

           
            else
            {
                MemberInfo.updateMembers(txtMemberName.Text, txtMemberAddress.Text,txtMemberEmail.Text, txtBailedName.Text,txtBailedphone.Text, txtMemberPhone.Text,updateId);
                MemberInfo.loadAllMembers(MemberView);
                makeEmptyMember();
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedId = (int)MemberView.SelectedRows[0].Cells[0].Value;
            if (txtMemberName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Name is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberName.Focus();
            }
            else if (txtMemberAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Address is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberAddress.Focus();
            }
            else if (txtBailedName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Name is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBailedName.Focus();
            }
            else if (txtBailedphone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bailed Phone is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtBailedphone.Focus();
            }
            else if (txtMemberPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Member Phone is Empty. Please Try And Check Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberPhone.Focus();
            }
            else
            {


                string name = txtMemberName.Text = (string)MemberView.SelectedRows[0].Cells[1].Value;
                DialogResult confirmation = MessageBox.Show("Are You Sure To Delete " + name + " Member?", "COMFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation.HasFlag(DialogResult.No)) { return; }
                else
                {
                    MemberInfo.deleteMembers(deletedId);
                    MemberInfo.loadAllMembers(MemberView);
                    makeEmptyMember();
                }
               
            }
        }

        private void MemberCellClick(object sender, DataGridViewCellEventArgs e)
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

            int id = (int)MemberView.SelectedRows[0].Cells[0].Value;
            txtMemberName.Text = (string)MemberView.SelectedRows[0].Cells[1].Value;
            txtMemberAddress.Text = (string)MemberView.SelectedRows[0].Cells[2].Value;
            txtMemberEmail.Text = (string)MemberView.SelectedRows[0].Cells[3].Value ;
            txtBailedName.Text = (string)MemberView.SelectedRows[0].Cells[4].Value;
            txtBailedphone.Text = (string)MemberView.SelectedRows[0].Cells[5].Value;
            txtMemberPhone.Text = (string)MemberView.SelectedRows[0].Cells[6].Value;
        }



        public void serachText()
        {
            using (SqlConnection conn = myConnections.GetConnections())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT id 'ID', name 'Name', address 'Address', email 'M Email', bname 'B Name', bphone 'B Phone' ,phone 'Mem Phone', date 'Date' FROM member WHERE name LIKE '%" + txtSearch.Text + "%'", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    MemberView.DataSource = dTable;
                    MemberView.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    MemberView.Visible = false;
                    lbl_display.Visible = true;
                }
               

                cmd.ExecuteNonQuery();

                conn.Close();



            }
        }

        private void MemberTextChanged(object sender, EventArgs e)
        {
             if (txtSearch.Text != "")
            {
                serachText();
            }
            else
             {
                 MemberView.Visible = true;
                 lbl_display.Visible = false;
                MemberInfo.loadAllMembers(MemberView);
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

     
    }
}
