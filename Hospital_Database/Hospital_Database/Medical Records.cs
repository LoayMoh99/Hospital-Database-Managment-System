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
    public partial class Medical_Records : Form
    {
        Controller controllerObj;
        int pssn;
        public Medical_Records(int ssn)
        {
            InitializeComponent();
            pssn = ssn;
        }

        private void Medical_Records_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetRecords(pssn); //pssn is the patient ssn sent from the login page
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void xrayBT_Click_1(object sender, EventArgs e)
        {
            XrayAnalysis x = new XrayAnalysis(pssn);
            x.Show();
        }
    }
}
