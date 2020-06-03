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
    public partial class Patient_Prescription_ : Form
    {
        Controller controllerObj;
        int pssn;
        public Patient_Prescription_(int ssn)
        {
            InitializeComponent();
            pssn = ssn;
        }


        private void Patient_Prescription__Load_1(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetPrescription(pssn); //pssn is the patient ssn sent from the login page
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("You don't have any prescription to be shown!");
                this.Close();
            }
        }
    }
}
