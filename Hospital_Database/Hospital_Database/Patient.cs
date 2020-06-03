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
    public partial class Patient : Form
    {
        LoginScreen logS;
        Controller controllerObj;
        int ssn;
        int cpe;
        Object tdob;
        DateTime dob;
        DateTime now;
        int age_Y;
        int age_M;
        DataTable tcd;
        string tstcd;
        int count;
        public Patient(int pssn, LoginScreen ls)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ssn = pssn;
            logS = ls;
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            pssnTB.Text = Convert.ToString(ssn);


            nameTB.Text = "";
            genderTB.Text = "";
            weightTB.Text = "";
            heightTB.Text = "";
            bloodTyTB.Text = "";
            ageTB.Text = "";

            nameTB.Text = Convert.ToString(controllerObj.GetPatientName(ssn));
            genderTB.Text = Convert.ToString(controllerObj.GetPatientGender(ssn));
            weightTB.Text = Convert.ToString(controllerObj.GetPatientWeight(ssn));
            heightTB.Text = Convert.ToString(controllerObj.GetPatientHeight(ssn));
            bloodTyTB.Text = Convert.ToString(controllerObj.GetPatientBloodType(ssn));

            //Calculating Age
            tdob = controllerObj.GetPatientDob(ssn);
            if (tdob != null)
            {
                if (tdob != DBNull.Value) //Check if date is null
                {
                    dob = Convert.ToDateTime(controllerObj.GetPatientDob(ssn));
                    now = DateTime.Today;

                    age_Y = now.Year - dob.Year;
                    if (now.Month < dob.Month)
                    {
                        age_Y--;
                        if (now.Day > dob.Day)
                            age_M = 12 - 1 - (dob.Month - now.Month);
                        else
                            age_M = 12 - (dob.Month - now.Month);
                    }
                    else if (now.Month > dob.Month)
                    {
                        if (now.Day > dob.Day)
                            age_M = now.Month - dob.Month;
                        else
                            age_M = now.Month - dob.Month - 1;
                    }
                    else
                    {
                        if (now.Day < dob.Day)
                        {
                            age_Y--;
                            age_M = 11;
                        }
                        else
                            age_M = 0;
                    }

                    ageTB.Text = age_Y.ToString() + " Years, " + age_M.ToString() + " Month(s)";
                }
            }
            //Getting Chronic Diseases 
            tcd = controllerObj.GetChronicDisease(ssn);
            if (tcd != null)
            {
                if (tcd.Rows.Count != 0)
                {
                    for (int i = 0; i < tcd.Rows.Count; i++)
                    {
                        tstcd = tcd.Rows[i]["Disease_Name"].ToString();
                        chronicDisesesRB.Text += tstcd + "\n";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void prescBT_Click(object sender, EventArgs e)
        {

        }

        private void complaintBT_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            logS.Show();
        }

        private void Patient_FormClosed(object sender, FormClosedEventArgs e)
        {
            logS.Show();
        }

        private void complaintBT_Click_1(object sender, EventArgs e)
        {
            PatAddComplaint a = new PatAddComplaint();
            a.Show();
        }

        private void prescBT_Click_1(object sender, EventArgs e)
        {
            Patient_Prescription_ p = new Patient_Prescription_(ssn);
            p.Show();
        }

        private void recordsBT_Click(object sender, EventArgs e)
        {
            Medical_Records m = new Medical_Records(ssn);
            m.Show();
        }
    }
}

