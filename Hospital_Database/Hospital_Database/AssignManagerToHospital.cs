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
    public partial class AssignManagerToHospital : Form
    {
        Controller controller;
        public AssignManagerToHospital()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void AssignManagerToHospital_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMDSDataSet15.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter2.Fill(this.hMDSDataSet15.Manager);
            // TODO: This line of code loads data into the 'hMDSDataSet14.Hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter2.Fill(this.hMDSDataSet14.Hospital);
            

        }

        private void button2_Click(object sender, EventArgs e)      //Close
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm
        {
            if(H.Text.Length == 0 || M.Text.Length == 0)
            {
                ST.Text = "Empty Fields!";
                return;
            }

            object DT = controller.HowManyDoesHeManage(Convert.ToInt32(M.SelectedValue));
            if(Convert.ToInt32(DT) != 0)
            {
                DialogResult result = MessageBox.Show("This Manager is already assigned to another hospital," +
                    " do you wish to proceed?", "", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                {
                    controller.AssignManagerToHospital(Convert.ToInt32(M.SelectedValue), Convert.ToInt32(H.SelectedValue));
                    ST.Text = "Manager Assigned!";
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
                controller.AssignManagerToHospital(Convert.ToInt32(M.SelectedValue), Convert.ToInt32(H.SelectedValue));
                ST.Text = "Manager Assigned!";
                return;
            }
        }
    }
}
