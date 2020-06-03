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
    public partial class Admin : Form
    {
        LoginScreen LogScr;
        public Admin(LoginScreen LS)
        {
            InitializeComponent();
            LogScr = LS;
        }

        private void button2_Click(object sender, EventArgs e)      //Add Manager
        {
            Add_Manager MTemp = new Add_Manager();
            MTemp.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogScr.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //Add Hospital
        {
            Add_Hospital HForm = new Add_Hospital();
            HForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)     //Assign Manager
        {
            AssignManagerToHospital AForm = new AssignManagerToHospital();
            AForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)      //Logout
        {
            this.Close();
            LogScr.Show();
        }

        private void showNur_Click(object sender, EventArgs e)
        {
            ReportFORnurseNo n = new ReportFORnurseNo();
            n.Show();
        }

        private void showPat_Click(object sender, EventArgs e)
        {
            PatNo n = new PatNo();
            n.Show();
        }

        private void showDoc_Click(object sender, EventArgs e)
        {
            Report_FORdoctorNO n = new Report_FORdoctorNO();
            n.Show();
        }
    }
}
