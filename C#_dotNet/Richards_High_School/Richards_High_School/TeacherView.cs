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
    public partial class TeacherView : Form
    {
        public TeacherView()
        {
            InitializeComponent();
        }

        dbAccess db = new dbAccess();
        DataTable dt = new DataTable();
        public string name;
        string query;
        
        private void TeacherView_Load_1(object sender, EventArgs e)
        {
            lbTeacherName.Text = name;

            query = "Select * from Academics";
            db.readDatathroughAdapter(query, dt);

            dataGridView1.DataSource = dt;
            db.closeConn();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            query = "Select * from Academics";
            db.executeDataAdapter(dt, query);

            MessageBox.Show("Changes Saved.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
