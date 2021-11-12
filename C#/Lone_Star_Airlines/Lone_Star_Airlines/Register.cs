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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static Boolean Passport = false;
        public static Boolean IdCard = false;
        public static string To, From, TripStartDate, TripEndDate, fName, lName, Document, docNum, DocIssueDate, DocExpDate, BaggageWeight;
        dbAccess db = new dbAccess();
        Confirmation cView = new Confirmation();

        private void Register_Load(object sender, EventArgs e)
        {
            calSelectDates.MaxSelectionCount = 100;
            calSelectDates.ShowToday = true;

            sliderBaggageWeight.Increment = 5;
            sliderBaggageWeight.ReadOnly = true;
        }
               

        private void rbtnPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPassport.Checked)
            {
                Passport = true;
                lbDocumentNum.Text = "Passport No: ";
                lbDocIssuDate.Text = "Passport Issue Date:";
                lbDocExpDate.Text = "Passport Expiry Date:";
                Document = "Passport";
            }
        }

        private void rbtnIdCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIdCard.Checked)
            {
                IdCard = true;
                lbDocumentNum.Text = "ID Card No:";
                lbDocIssuDate.Text = "ID Issue Date:";
                lbDocExpDate.Text = "ID Expiry Date:";
                Document = "ID Card";
            }
        }

        private void dtpPassIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpPassIssueDate.Value;
            dtpPassExpiryDate.MinDate = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            To = txtbxTo.Text;
            From = txtbxFrom.Text;
            TripStartDate = calSelectDates.SelectionStart.ToString("dd MMM yyyy");
            TripEndDate = calSelectDates.SelectionEnd.ToString("dd MMM yyyy");
            fName = txtbxfName.Text;
            lName = txtbxlName.Text;
            //Document
            docNum = txtbxDocNo.Text;
            DocIssueDate = dtpPassIssueDate.Value.ToString("dd MMM yyyy");
            DocExpDate = dtpPassExpiryDate.Value.ToString("dd MMM yyyy");
            BaggageWeight = sliderBaggageWeight.Value.ToString();
                        
            SqlCommand insertPassengers = new SqlCommand("insert into Passengers(first_name,last_name,to_location,from_location,start_date,end_date,travel_document,document_number,document_issue_date,document_expiry_date,baggage_weight) " +
                "values(@fName,@lName,@To,@From,@TripStartDate,@TripEndDate,@Document,@docNum,@DocIssueDate,@DocExpDate,@BaggageWeight)");


            insertPassengers.Parameters.AddWithValue("@fName", fName);
            insertPassengers.Parameters.AddWithValue("@lName", lName);
            insertPassengers.Parameters.AddWithValue("@To", To);
            insertPassengers.Parameters.AddWithValue("@From", From);
            insertPassengers.Parameters.AddWithValue("@TripStartDate", TripStartDate);
            insertPassengers.Parameters.AddWithValue("@TripEndDate", TripEndDate);
            insertPassengers.Parameters.AddWithValue("@Document", Document);
            insertPassengers.Parameters.AddWithValue("@docNum", docNum);
            insertPassengers.Parameters.AddWithValue("@DocIssueDate", DocIssueDate);
            insertPassengers.Parameters.AddWithValue("@DocExpDate", DocExpDate);
            insertPassengers.Parameters.AddWithValue("@BaggageWeight", BaggageWeight);

            db.executeQuery(insertPassengers);

            cView.Show();
            this.Hide();

        }
    }
}
