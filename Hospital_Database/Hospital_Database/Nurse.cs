using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Database
{
    public partial class Nurse : Form
    {
        LoginScreen logS;
        Controller controllerObj;
        int Pssn;
        int cpe;
        Object tdob;
        DateTime dob;
        DateTime now;
        int age_Y;
        int age_M;
        DataTable tcd;
        string tstcd;
        int count;
        string pname;
        public Nurse(LoginScreen LS)
        {
            InitializeComponent();
            controllerObj = new Controller();
            logS = LS;
        }

        private void ShowData_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Pssn = Convert.ToInt32(PatientSsn_txt.Text);

                if (Pssn < 0)
                    throw new Exception();
            }
            catch
            {
                Name_txt.Text = "";
                Gender_txt.Text = "";
                Weight_txt.Text = "";
                Height_txt.Text = "";
                BloodType_txt.Text = "";
                Age_txt.Text = "";
                ChronicDiseases_richTxt.Text = "";
                Records_richTxt.Text = "";
                Prescription_richTxt.Text = "";
                MessageBox.Show("Please, Enter valid SSN");
                InfoUpdate.Enabled = false;
                return;
            }

            //cpe = Convert.ToInt16(controllerObj.CheckPatientExistance(Pssn));
            pname = controllerObj.GetPatientName(Pssn).ToString();
            if (pname == null)  //Checking if patient exists, (cpe == 1) then patient exist
            {
                Name_txt.Text = "";
                Gender_txt.Text = "";
                Weight_txt.Text = "";
                Height_txt.Text = "";
                BloodType_txt.Text = "";
                Age_txt.Text = "";
                ChronicDiseases_richTxt.Text = "";
                Records_richTxt.Text = "";
                Prescription_richTxt.Text = "";
                MessageBox.Show("Patient not found!");
                InfoUpdate.Enabled = false;
                return;
            }

            InfoUpdate.Enabled = true;
            Name_txt.Text = "";
            Gender_txt.Text = "";
            Weight_txt.Text = "";
            Height_txt.Text = "";
            BloodType_txt.Text = "";
            Age_txt.Text = "";
            ChronicDiseases_richTxt.Text = "";
            Records_richTxt.Text = "";
            Prescription_richTxt.Text = "";

            Name_txt.Text = Convert.ToString(controllerObj.GetPatientName(Pssn));
            Gender_txt.Text = Convert.ToString(controllerObj.GetPatientGender(Pssn));
            Weight_txt.Text = Convert.ToString(controllerObj.GetPatientWeight(Pssn));
            Height_txt.Text = Convert.ToString(controllerObj.GetPatientHeight(Pssn));
            BloodType_txt.Text = Convert.ToString(controllerObj.GetPatientBloodType(Pssn));

            //Calculating Age
            tdob = controllerObj.GetPatientDob(Pssn);
            if (tdob != DBNull.Value) //Check if date is null
            {
                dob = Convert.ToDateTime(controllerObj.GetPatientDob(Pssn));
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

                Age_txt.Text = age_Y.ToString() + " Years, " + age_M.ToString() + " Month(s)";
            }

            //Getting Chronic Diseases 
            tcd = controllerObj.GetChronicDisease(Pssn);
            if (tcd != null)
            {
                for (int i = 0; i < tcd.Rows.Count; i++)
                {
                    tstcd = tcd.Rows[i]["Disease_Name"].ToString();
                    ChronicDiseases_richTxt.Text += "-" + tstcd + "\n";
                }
            }


            //Getting Reports
            tcd = controllerObj.GetRecords(Pssn);
            if (tcd != null)
            {
                count = tcd.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    tstcd = tcd.Rows[i]["Name"].ToString();
                    Records_richTxt.Text += "Made by Dr. " + tstcd;
                    tstcd = Convert.ToDateTime(tcd.Rows[i]["R_Date"]).ToShortDateString().ToString();
                    Records_richTxt.Text += "   (" + tstcd + ") \n";
                    tstcd = tcd.Rows[i]["Description"].ToString();
                    Records_richTxt.Text += tstcd + "\n";
                    if (i != count - 1)
                        Records_richTxt.Text += "-------------------------------------------" +
                                                "-----------------------------------------\n";
                }
            }



            //Getting Prescription
            tcd = controllerObj.GetPrescription(Pssn);
            if (tcd != null)
            {
                count = tcd.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    tstcd = tcd.Rows[i]["Name"].ToString();
                    Prescription_richTxt.Text += "'" + tstcd + "'";
                    tstcd = tcd.Rows[i]["NoTimes"].ToString();
                    if (tstcd != "")
                        Prescription_richTxt.Text += ", " + tstcd + "\n";
                    else
                        Prescription_richTxt.Text += "\n";
                    tstcd = tcd.Rows[i]["Notes"].ToString();
                    if (tstcd != "")
                        Prescription_richTxt.Text += "Note: " + tstcd + "\n";
                    if (i != count - 1)
                        Prescription_richTxt.Text += "-------------------------------------\n";
                }
            }
        }

        private void InfoUpdate_Click_1(object sender, EventArgs e)
        {
            InfoUpdate Update = new InfoUpdate(Convert.ToInt32(PatientSsn_txt.Text), this);
            Update.Show();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {

        }


        private void Nurse_FormClosed(object sender, FormClosedEventArgs e)
        {
            logS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            logS.Show();
        }


    }
}
