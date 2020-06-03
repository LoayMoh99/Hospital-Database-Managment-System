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
    public partial class Registeration : Form
    {
        Form Regist;
        Controller controller;
        EncryptCode enc;
        ValidationFunctions VF;
        public Registeration(Form Registeration)
        {
            InitializeComponent();
            Regist = Registeration;
            controller = new Controller();
            enc = new EncryptCode();
            VF = new ValidationFunctions();
            G.Text = "Male";
            EX.Text = "0";
            BT.Text = "A+";
        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)        //Patient
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Regist.Show();
        }

        private void Registeration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Regist.Show();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)        //Nurse
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)        //Doctor
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)        //Administration
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)      //Confirm Registration
        {
            if (SSN.Text.Length == 0 || UN.Text.Length == 0 || PW.Text.Length == 0 || PN.Text.Length == 0 || C.Text.Length == 0 || D.Text.Length == 0 || AD.Text.Length == 0 || G.Text.Length == 0 || FH.Text.Length == 0 || N.Text.Length == 0 || BD.Text.Length == 0)
            {
                ST.Text = "Empty fields!";
                return;
            }

            if (!VF.Validate_Number(SSN.Text))
            {
                ST.Text = "SSN should be a number!";
                return;
            }

            if (PW.Text.Length < 7)
            {
                ST.Text = "Enter stronger password";
                return;
            }


            if (!VF.Validate_Number(PN.Text))
            {
                ST.Text = "PhoneNo should be a number!";
                return;
            }

            if (!VF.Validate_Number(H.Text) && radioButton8.Checked)
            {
                ST.Text = "Height should be a number!";
                return;
            }

            if (!VF.Validate_Number(W.Text) && radioButton8.Checked)
            {
                ST.Text = "Weight should be a number!";
                return;
            }

            if (!VF.Validate_Date(BD.Text))
            {
                ST.Text = "Improper date form";
                return;
            }

            bool Continue = false;
            DataTable SSNS = controller.RetrieveUserandPass();
            for (int i = 0; i < SSNS.Rows.Count; i++)
                if (SSN.Text.Trim() == SSNS.Rows[i]["SSN"].ToString().Trim())
                    Continue = true;

            for (int i = 0; i < SSNS.Rows.Count; i++)
                if (UN.Text == SSNS.Rows[i]["Username"].ToString().Trim())
                {
                    ST.Text = "UserName is already taken!!";
                    return;
                }

            if (radioButton8.Checked && Continue)
            {
                controller.InsertPatientInfo(Convert.ToInt32(SSN.Text), N.Text, C.Text, D.Text, AD.Text, G.Text, Convert.ToInt32(PN.Text), BD.Text, Convert.ToInt32(W.Text), Convert.ToInt32(H.Text), BT.Text);
                controller.RegisterUpdate(Convert.ToInt32(SSN.Text), "Patient", enc.PasswordEncrypt(PW.Text), UN.Text, enc.PasswordEncrypt(FH.Text));
                ST.Text = "Registered Successfully!";
            }
            else if (radioButton7.Checked && Continue)
            {
                controller.InsertDoctorInfo(Convert.ToInt32(SSN.Text), N.Text, C.Text, D.Text, AD.Text, G.Text, Convert.ToInt32(PN.Text), BD.Text);
                controller.RegisterUpdate(Convert.ToInt32(SSN.Text), "Doctor", enc.PasswordEncrypt(PW.Text), UN.Text, enc.PasswordEncrypt(FH.Text));
                ST.Text = "Registered Successfully!";
            }
            else if (radioButton6.Checked && Continue)
            {
                controller.InsertNurseInfo(Convert.ToInt32(SSN.Text), N.Text, C.Text, D.Text, AD.Text, G.Text, Convert.ToInt32(PN.Text), BD.Text, Convert.ToInt32(EX.Text));
                controller.RegisterUpdate(Convert.ToInt32(SSN.Text), "Nurse", enc.PasswordEncrypt(PW.Text), UN.Text, enc.PasswordEncrypt(FH.Text));
                ST.Text = "Registered Successfully!";
            }
            else if (radioButton5.Checked && Continue)
            {
                controller.InsertManagerInfo(Convert.ToInt32(SSN.Text), N.Text, C.Text, D.Text, AD.Text, G.Text, Convert.ToInt32(PN.Text), BD.Text);
                controller.RegisterUpdate(Convert.ToInt32(SSN.Text), "Manager", enc.PasswordEncrypt(PW.Text), UN.Text, enc.PasswordEncrypt(FH.Text));
                ST.Text = "Registered Successfully!";
            }
            else
                ST.Text = "Wrong Info!";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
