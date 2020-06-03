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
    public partial class Report_Addition : Form
    {
        Controller controllerObj;
        int D_SSN, P_SSN;
        public Report_Addition(int DSSN, int PSSN)
        {
            InitializeComponent();
            controllerObj = new Controller();
            D_SSN = DSSN;
            P_SSN = PSSN;
        }

        private void AddRecord_btn_Click(object sender, EventArgs e)
        {
            if (Description_richTxt.Text != "")
                controllerObj.AddMedRecord(P_SSN, Description_richTxt.Text, D_SSN);
            else
            {
                MessageBox.Show("Write the Report, Please");
                return;
            }

            MessageBox.Show("Recored added successfully.");

            this.Hide();
        }
    }
}
