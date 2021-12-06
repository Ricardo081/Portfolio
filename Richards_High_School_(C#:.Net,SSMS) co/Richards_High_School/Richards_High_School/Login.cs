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

namespace Richards_High_School//done
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string name, fname, lname;
        public string username, password;// id;
        public int isTeacher;
        
        dbAccess db = new dbAccess();
        DataTable dtAccess = new DataTable();//isTeacher? Open 1st access
        DataTable dtAccess2 = new DataTable();//isTeacher? Open 2nd access for student access toi Academics table
                
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;

            string query = "Select * from Members Where username= '" + username + "' AND Password= '"
                + password + "'";
            db.readDatathroughAdapter(query, dtAccess);

            if (dtAccess.Rows.Count == 1)//access granted
            {

                fname = dtAccess.Rows[0]["first_name"].ToString();
                lname = dtAccess.Rows[0]["last_name"].ToString();
                isTeacher = Convert.ToInt32(dtAccess.Rows[0]["isTeacher"].ToString());
                name = (fname + " " + lname);

                db.closeConn();

                if (isTeacher == 0)//student
                {
                    StudentView sView = new StudentView();//access studentview data variables

                    query = "Select * from Academics Where username= '" + username + "'";
                    db.readDatathroughAdapter(query, dtAccess2);

                    sView.name = name;
                    sView.Assignment1 = dtAccess2.Rows[0]["Assignment_1"].ToString();
                    sView.Assignment2 = dtAccess2.Rows[0]["Assignment_2"].ToString();
                    sView.Assignment3 = dtAccess2.Rows[0]["Assignment_3"].ToString();
                    sView.Midterm = dtAccess2.Rows[0]["Midterm"].ToString();
                    sView.Assignment4 = dtAccess2.Rows[0]["Assignment_4"].ToString();
                    sView.Assignment5 = dtAccess2.Rows[0]["Assignment_5"].ToString();
                    sView.Final_Exam = dtAccess2.Rows[0]["Final_Exam"].ToString();

                    db.closeConn();

                    this.Hide();
                    sView.Show();
                }
                else if (isTeacher == 1)
                {
                    this.Hide();
                    TeacherView tView = new TeacherView();
                    tView.name = name;
                    tView.Show();
                }

            }
            else
            {
                MessageBox.Show("Credentials are incorrect, or not in system!");
            }
        }

        private void lbCodeLink_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterA rUser = new RegisterA();
            rUser.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
