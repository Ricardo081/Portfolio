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
    public partial class RegisterB : Form
    {
        public RegisterB()
        {
            InitializeComponent();
        }
        public int userIdentifier;
        public int age, grade_level, isTeacher;
        public string first_name, last_name, username, password, gender, phone_number, email, home_address, city, state, zip;
       
        dbAccess db = new dbAccess();

        private void RegisterB_Load_1(object sender, EventArgs e)
        {
            if (userIdentifier == 0)
            {
                tbPN.Location = new Point(256, 346);
                lbUReg.Text = "Student Registration";
                lbPN.Text = "Parent Phone Number:";
                lbEmail.Text = "Parent Email:";
            }
            else if (userIdentifier == 1)
            {
                lbUReg.Text = "Teacher Registration";

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (userIdentifier == 0)//student
            {
                first_name = tbfName.Text;
                last_name = tblName.Text;
                username = (last_name + first_name);//temp so null wont be entered
                password = tbPass.Text;
                age = Convert.ToInt32(tbAge.Text);
                gender = tbGender.Text;
                grade_level = Convert.ToInt32(tbGLevel.Text);
                phone_number = tbPN.Text;
                email = tbEmail.Text;
                home_address = tbHomeAddress.Text;
                city = tbCity.Text;
                state = tbState.Text;
                zip = tbZip.Text;
                isTeacher = 0;

            }
            else if (userIdentifier == 1)//teacher
            {
                first_name = tbfName.Text;
                last_name = tblName.Text;
                username = (last_name + first_name);//temp
                password = tbPass.Text;
                age = Convert.ToInt32(tbAge.Text);
                gender = tbGender.Text;
                grade_level = Convert.ToInt32(tbGLevel.Text);
                phone_number = tbPN.Text;
                email = tbEmail.Text;
                home_address = tbHomeAddress.Text;
                city = tbCity.Text;
                state = tbState.Text;
                zip = tbZip.Text;
                isTeacher = 1;

            }


            SqlCommand insertMembers = new SqlCommand("insert into Members(first_name,last_name,username,password,isTeacher,age,gender,grade_level,phone_number,home_address,city,state,zip,email_address) values(@first_name,@last_name,@username,@password,@isTeacher,@age,@gender,@grade_level,@phone_number,@home_address,@city,@state,@zip,@email)");
            SqlCommand insertAcademics = new SqlCommand("insert into Academics(username,first_name,last_name) values(@username,@first_name,@last_name)");


            insertMembers.Parameters.AddWithValue("@first_name", first_name);
            insertMembers.Parameters.AddWithValue("@last_name", last_name);
            insertMembers.Parameters.AddWithValue("@username", username);
            insertMembers.Parameters.AddWithValue("@password", password);
            insertMembers.Parameters.AddWithValue("@isTeacher", isTeacher);
            insertMembers.Parameters.AddWithValue("@age", age);
            insertMembers.Parameters.AddWithValue("@gender", gender);
            insertMembers.Parameters.AddWithValue("@grade_level", grade_level);
            insertMembers.Parameters.AddWithValue("@phone_number", phone_number);
            insertMembers.Parameters.AddWithValue("@home_address", home_address);
            insertMembers.Parameters.AddWithValue("@city", city);
            insertMembers.Parameters.AddWithValue("@state", state);
            insertMembers.Parameters.AddWithValue("@zip", zip);
            insertMembers.Parameters.AddWithValue("@email", email);

            db.executeQuery(insertMembers);

            if (userIdentifier == 0)//student, send to Academics as well
            {
                insertAcademics.Parameters.AddWithValue("@username", username);
                insertAcademics.Parameters.AddWithValue("@first_name", first_name);
                insertAcademics.Parameters.AddWithValue("@last_name", last_name);

                db.executeQuery(insertAcademics);
            }


            MessageBox.Show("Account Created Successfully!\nUsername: " + username);
            this.Hide();
            Login showLogin = new Login();
            showLogin.Show();
        }
    }
}
