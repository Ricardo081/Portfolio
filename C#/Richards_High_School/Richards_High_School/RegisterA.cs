using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richards_High_School
{
    public partial class RegisterA : Form
    {
        public RegisterA()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            if (code == "ae98-23Zx@eQEwR")//teacher
            {
                this.Hide();
                RegisterB rb = new RegisterB();
                rb.userIdentifier = 1;
                rb.Show();
            }
            else if (code == "student")//student
            {
                this.Hide();
                RegisterB rb = new RegisterB();
                rb.userIdentifier = 0;
                rb.Show();
            }
            else
            {
                lbEnterCode.ForeColor = Color.Firebrick;
                tbCode.Text = "";
                MessageBox.Show("Incorrect Code! Try again.");
            }
        }
    }
}
