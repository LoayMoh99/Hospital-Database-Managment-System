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
    public partial class Manager : Form
    {
        LoginScreen LSS;
        public Manager(LoginScreen LS)
        {
            InitializeComponent();
            LSS = LS;
        }

        private void button2_Click(object sender, EventArgs e)      //Add Patient
        {
            Add_Patient PForm = new Add_Patient();
            PForm.Show();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)       //Form Closed
        {
            LSS.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //Add Doctor
        {
            Add_Doctor DForm = new Add_Doctor();
            DForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)      //Add Nurse
        {
            Add_Nurse NForm = new Add_Nurse();
            NForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)      //Assign Doctor to a Department
        {
            Assign_Doctor_Dep ADForm = new Assign_Doctor_Dep();
            ADForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)      //Logout
        {
            this.Close();
            LSS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignNurseToAHospital ANForm = new AssignNurseToAHospital();
            ANForm.Show();
        }
    }
}
