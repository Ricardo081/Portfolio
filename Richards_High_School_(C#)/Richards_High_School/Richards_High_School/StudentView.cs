using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richards_High_School
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        dbAccess db = new dbAccess();
        public string name;
        public string Assignment1, Assignment2, Assignment3, Midterm, Assignment4, Assignment5, Final_Exam;
       
        private void StudentView_Load(object sender, EventArgs e)
        {
            lbStudentName.Text = name;//only first name appears because sql tabel made each name have 50 chars


            if (Assignment1 != "")
            {
                lbA1.Text = Assignment1;
            }
            if (Assignment2 != "")
            {
                lbA2.Text = Assignment2;
            }
            if (Assignment3 != "")
            {
                lbA3.Text = Assignment3;
            }
            if (Midterm != "")
            {
                lbAM.Text = Midterm;
            }
            if (Assignment4 != "")
            {
                lbA4.Text = Assignment4;
            }
            if (Assignment5 != "")
            {
                lbA5.Text = Assignment5;
            }
            if (Final_Exam != "")
            {
                lbAF.Text = Final_Exam;
            }

        }
    }
}
