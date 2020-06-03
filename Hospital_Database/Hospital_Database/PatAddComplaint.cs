using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Database
{
    public partial class PatAddComplaint : Form
    {
        Controller controllerObj;
        public PatAddComplaint()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetHospitalNameAndID();
            hosIdCB.DataSource = dt;
            hosIdCB.DisplayMember = "Name";
            hosIdCB.ValueMember = "H_ID";
        }

        private void PatAddComplaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMDSDataSet.Hospital' table. You can move, or remove it, as needed.
           // this.hospitalTableAdapter.Fill(this.hMDSDataSet.Hospital);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            int hID = Convert.ToInt32(hosIdCB.SelectedValue);
            string complaint = "";
            if (complaintTB.Text == "")
            {
                MessageBox.Show("Insert your complaint before submitting, Please!!");
                return;
            }
            else
            {
                complaint = complaintTB.Text;
            }
            int r = controllerObj.AddComplaint(hID, complaint);
            if (r > 0)
            {
                MessageBox.Show("Your complaint will be considered and we hope it won't occur again!");
            }
            else MessageBox.Show("Sorry, but there was a problem while inserting your complaint!!");
        }
    }
}
