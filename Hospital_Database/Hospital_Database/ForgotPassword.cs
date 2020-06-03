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
    public partial class ForgotPassword : Form
    {
        LoginScreen LogScreen;
        Controller controller;
        EncryptCode enc;
        public ForgotPassword(LoginScreen LS)
        {
            InitializeComponent();
            LogScreen = LS;
            controller = new Controller();
            enc = new EncryptCode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LogScreen.Show();
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //Retrieve Password
        {
            object PW = controller.RetrievePassword(textBox3.Text, enc.PasswordEncrypt(textBox9.Text));
            int ck;
            if (PW != null)
            {
                ck = controller.PasswordUpdate(enc.PasswordEncrypt(NewPass_txt.Text), enc.PasswordEncrypt(textBox9.Text));
                if (ck != 0)
                    textBox2.Text = "Password Updated!";
                else
                    textBox2.Text = "An error occured";
            }
            else
            {
                textBox2.Text = "An error occured";
                //NewPass_txt.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
