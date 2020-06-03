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
    public partial class LoginScreen : Form
    {
        Controller controller;
        EncryptCode enc;
        Doctor DForm;
        Admin AForm;
        Manager MForm;
        Nurse NForm;
        Patient PForm;
        int count = 0;
        public LoginScreen()
        {
            InitializeComponent();
            controller = new Controller();
            enc = new EncryptCode();
        }

        private void button4_Click(object sender, EventArgs e)      //Exit
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)     //Login
        {
            bool P = false;

            if (UN.Text.Length == 0 || PW.Text.Length == 0)
            {
                ST.Text = "Empty Field";
                return;
            }

            char T = 'S';
            string temp = enc.PasswordEncrypt(PW.Text.Trim());
            temp += "12321088242244204752252164234211278524621614138217";
            DataTable Usernames = controller.RetrieveUserandPass();
            for (int i = 0; i < Usernames.Rows.Count; i++)
                if (UN.Text.Trim() == Usernames.Rows[i]["Username"].ToString().Trim())
                {
                    if (PW.Text == (Usernames.Rows[i]["PassCode"].ToString()))
                    {
                        object UserType = controller.GetUserType(Convert.ToInt32(controller.RetrieveCertainSSN(UN.Text.Trim())));
                        if (UserType != null)
                        {
                            if (UserType.ToString() == "Admin")
                                T = 'A';
                            else if (UserType.ToString() == "Manager")
                                T = 'M';
                            else if (UserType.ToString() == "Patient")
                                T = 'P';
                            else if (UserType.ToString() == "Doctor")
                                T = 'D';
                            else if (UserType.ToString() == "Nurse")
                                T = 'N';
                            P = true;
                        }
                    }
                }

            if (P)
            {
                if (T == 'D')
                {
                    DForm = new Doctor(Convert.ToInt32(controller.RetrieveCertainSSN(UN.Text.Trim())), this);
                    DForm.Show();
                }
                else if (T == 'A')
                {
                    AForm = new Admin(this);
                    this.Hide();
                    AForm.Show();
                }
                else if (T == 'M')
                {
                    MForm = new Manager(this);
                    this.Hide();
                    MForm.Show();
                }
                else if (T == 'N')
                {
                    NForm = new Nurse(this);
                    this.Hide();
                    NForm.Show();
                }
                else if (T == 'P')
                {
                    PForm = new Patient(Convert.ToInt32(controller.RetrieveCertainSSN(UN.Text.Trim())), this);
                    this.Hide();
                    PForm.Show();
                }
                else
                {
                    ST.Text = "Wrong Info!";
                    return;
                }
                this.Hide();
            }
            else
                ST.Text = "Wrong Info!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registeration RegistForm = new Registeration(this);
            RegistForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)      //Forgot Password
        {
            this.Hide();
            ForgotPassword ForgPass = new ForgotPassword(this);
            ForgPass.Show();
        }

        private void showBT_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                PW.UseSystemPasswordChar = false;
                count++;
            }
            else
            {
                PW.UseSystemPasswordChar = true;
                count++;
            }
        }

        private void PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            PW.UseSystemPasswordChar = true;
        }
    }
}
