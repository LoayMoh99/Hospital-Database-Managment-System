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
    public partial class ChronicDis_Addition : Form
    {
        Controller controllerObj;
        int P_SSN;
        public ChronicDis_Addition(int Pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            P_SSN = Pssn;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ChDis_txt.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure that " + controllerObj.GetPatientName(P_SSN) + " have that disease?", "", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                    controllerObj.AddChronicDisease(P_SSN, ChDis_txt.Text);
            }
            else
            {
                MessageBox.Show("Write the Chronic Disease name to be added, Please");
            }
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChDis_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
