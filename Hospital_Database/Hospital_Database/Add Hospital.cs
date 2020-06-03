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
    public partial class Add_Hospital : Form
    {
        Controller controller;
        ValidationFunctions VF;
        public Add_Hospital()
        {
            InitializeComponent();
            controller = new Controller();
            VF = new ValidationFunctions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm
        {
            if (HID.Text.Length == 0 || N.Text.Length == 0 || C.Text.Length == 0 || D.Text.Length == 0 || A.Text.Length == 0)
            {
                ST.Text = "Empty fields!";
                return;
            }

            if (!VF.Validate_Number(HID.Text))
            {
                ST.Text = "Hospital ID should be a number!";
                return;
            }

            bool Continue = true;
            DataTable HIDS = controller.RetrieveHosID();
            if (HIDS!=null)
                for (int i = 0; i < HIDS.Rows.Count; i++)
                    if (HID.Text.Trim() == HIDS.Rows[i][0].ToString().Trim())
                        Continue = false;

            if(Continue)
            {
                controller.AddHospital(Convert.ToInt32(HID.Text), N.Text, C.Text, D.Text, A.Text);
                ST.Text = "Hospital added successfully!";
                return;
            }
            else
            {
                ST.Text = "Already registered!";
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Hospital_Load(object sender, EventArgs e)
        {

        }
    }
}
