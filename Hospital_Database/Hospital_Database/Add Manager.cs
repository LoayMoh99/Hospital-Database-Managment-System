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
    public partial class Add_Manager : Form
    {
        Controller controller;
        ValidationFunctions VF;
        public Add_Manager()
        {
            InitializeComponent();
            controller = new Controller();
            VF = new ValidationFunctions();
        }

        private void button2_Click(object sender, EventArgs e)      //Close form
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm registration
        {
            if (VF.Validate_Number(textBox1.Text))
            {
                bool Continue = true;
                DataTable SSNS = controller.RetrieveSSN();
                for (int i = 0; i < SSNS.Rows.Count; i++)
                    if (textBox1.Text.Trim() == SSNS.Rows[i][0].ToString().Trim())
                        Continue = false;

                if (Continue)
                {
                    int r=controller.Register(Convert.ToInt32(textBox1.Text), textBox1.Text, "Manager", "", "");
                    if(r!=0)
                         textBox2.Text = "Registered Successfully!";
                    else 
                        textBox2.Text = "Not Registered!";
                    return;
                }
                else
                    textBox2.Text = "Already Registered!";
            }
            else
                textBox2.Text = "Wrong info!";
        }
    }
}
