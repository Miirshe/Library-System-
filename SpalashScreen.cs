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
    public partial class SpalashScreen : Form
    {
        public SpalashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunnaLeftCircle.Increment(2);
            gunaProgressBarCenter.Increment(2);
            timer1.Enabled = true;
            if (gunaProgressBarCenter.Value == 100)
            {
                timer1.Enabled = false;
                UserLogin usr = new UserLogin();
                usr.Show();
                this.Hide();
            }
           
        }

        private void SpalashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
