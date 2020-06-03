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
    public partial class AssignNurseToAHospital : Form
    {
        Controller controller;
        public AssignNurseToAHospital()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void AssignNurseToAHospital_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMDSDataSet17.Hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter2.Fill(this.hMDSDataSet17.Hospital);
            // TODO: This line of code loads data into the 'hMDSDataSet16.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter2.Fill(this.hMDSDataSet16.Nurse);
            

        }

        private void button2_Click(object sender, EventArgs e)      //Cancel
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm
        {
            if (N.Text.Length == 0 || H.Text.Length == 0)
            {
                ST.Text = "Empty Fields!";
                return;
            }

            object DT = controller.IsNurseInAHospital(Convert.ToInt32(N.SelectedValue));
            if (Convert.ToInt32(DT) != 0)
            {
                DialogResult result = MessageBox.Show("This Nurse is already assigned to another hospital," +
                    " do you wish to proceed?", "", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                {
                    controller.AssignNurseToHospital(Convert.ToInt32(N.SelectedValue), Convert.ToInt32(H.SelectedValue));
                    ST.Text = "Nurse Assigned!";
                    return;
                }
                else
                {
                    ST.Text = "";
                    return;
                }
            }
            else
            {
                controller.AssignNurseToHospital(Convert.ToInt32(N.SelectedValue), Convert.ToInt32(H.SelectedValue));
                ST.Text = "Nurse Assigned!";
                return;
            }
        }
    }
}
