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
    public partial class Add_Doctor : Form
    {
        Controller controller;
        ValidationFunctions VF;
        public Add_Doctor()
        {
            InitializeComponent();
            controller = new Controller();
            VF = new ValidationFunctions();
        }

        private void button2_Click(object sender, EventArgs e)      //Cancel
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm
        {
            if (VF.Validate_Number(SSN.Text))
            {
                bool Continue = true;
                DataTable SSNS = controller.RetrieveUserandPass();
                for (int i = 0; i < SSNS.Rows.Count; i++)
                    if (SSN.Text.Trim() == SSNS.Rows[i][2].ToString().Trim())
                    {
                        if (SSNS.Rows[i]["Username"].ToString().Trim() == SSN.Text)
                            Continue = false;
                    }

                if (Continue)
                {
                    controller.Register(Convert.ToInt32(SSN.Text), SSN.Text, "Doctor", "", "");
                    ST.Text = "Registered Successfully!";
                    return;
                }
                else
                    ST.Text = "Not Registered!";
            }
            else
                ST.Text = "Wrong info!";
        }
    }
}
