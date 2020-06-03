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
    public partial class Assign_Doctor_Dep : Form
    {
        Controller controller;
        public Assign_Doctor_Dep()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Assign_Doctor_Dep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMDSDataSet13.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter2.Fill(this.hMDSDataSet13.Departments);
            // TODO: This line of code loads data into the 'hMDSDataSet12.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter1.Fill(this.hMDSDataSet12.Doctor);
            

        }

        private void button2_Click(object sender, EventArgs e)      //Cancel
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm
        {
            if (D.Text.Length == 0 || DP.Text.Length == 0)
            {
                ST.Text = "Empty Fields!";
                return;
            }

            object DT = controller.IsDocInADep(Convert.ToInt32(D.SelectedValue));
            if (Convert.ToInt32(DT) != 0)
            {
                DialogResult result = MessageBox.Show("This Doctor is already assigned to another department," +
                    " do you wish to proceed?", "", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                {
                    controller.AssignDoctorToDepartment(Convert.ToInt32(D.SelectedValue), Convert.ToInt32(DP.SelectedValue));
                    ST.Text = "Doctor Assigned!";
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
                controller.AssignDoctorToDepartment(Convert.ToInt32(D.SelectedValue), Convert.ToInt32(DP.SelectedValue));
                ST.Text = "Doctor Assigned!";
                return;
            }
        }
    }
}
