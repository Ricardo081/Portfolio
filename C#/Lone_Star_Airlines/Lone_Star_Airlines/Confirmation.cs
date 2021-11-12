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

namespace Lone_Star_Airlines
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        public string query;
        dbAccess db = new dbAccess();
        DataTable dt = new DataTable();

        private void Confirmation_Load(object sender, EventArgs e)
        {
            if (Register.Passport == true)
            {
                lbDocNoName.Text = "Passport No:";
                lbDocExpDateName.Text = "Passport Expiry Date:";
            }
            else
            {
                lbDocExpDateName.Text = "ID Card No:";
                lbDocExpDateName.Text = "ID Card Expiry Date:";
            }

            query = "Select * from Passengers where first_name= '" + Register.fName + "' AND document_number= '"
                + Register.docNum + "'";

            db.readDatathroughAdapter(query, dt);

            if (dt.Rows.Count == 1)//access granted
            {
                string first_name, last_name, full_name, TripStartDate, TripEndDate;
                first_name = dt.Rows[0]["first_name"].ToString();
                last_name = dt.Rows[0]["last_name"].ToString();
                full_name = first_name + " " + last_name;
                TripStartDate = dt.Rows[0]["start_date"].ToString();
                TripEndDate = dt.Rows[0]["end_date"].ToString();
                                               
                lbFullName.Text = full_name;
                lbDepartCity.Text = dt.Rows[0]["from_location"].ToString();
                lbDestCity.Text = dt.Rows[0]["to_location"].ToString();
                lbTripDates.Text = TripStartDate + " to " + TripEndDate;
                lbDocNo.Text = dt.Rows[0]["document_number"].ToString();
                lbDocExpDate.Text = dt.Rows[0]["document_expiry_date"].ToString();
                lbEstWeightBag.Text = dt.Rows[0]["baggage_weight"].ToString();

                db.closeConn();
            }
            else
            {
                MessageBox.Show("Internal Error!");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Register rView = new Register();
            rView.Show();
            this.Hide();
        }
    }
}
