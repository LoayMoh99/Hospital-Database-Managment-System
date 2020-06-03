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
    public partial class Medicine_Addition : Form
    {
        Controller controllerObj;
        int Pat_SSN;
        DataTable tcd;
        bool AlreadyTakeMed = false;

        public Medicine_Addition(int PSSN)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetMedicineNameAndID();
            MedName_comboBox.DataSource = dt;
            MedName_comboBox.DisplayMember = "Name";
            MedName_comboBox.ValueMember = "M_ID";
            Pat_SSN = PSSN;
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (MedName_comboBox.SelectedValue != null)
            {
                if (NumOfTimes_txt.Text == "")
                    NumOfTimes_txt.Text = null;

                if (Notes_txt.Text.Length > 50)
                {
                    MessageBox.Show("The Note is too long, please shorten it");
                    return;
                }
                else if (Notes_txt.Text == "")
                    Notes_txt.Text = null;

                tcd = controllerObj.GetPrescription(Pat_SSN);
                for (int i = 0; i < tcd.Rows.Count; i++)
                {
                    if (Convert.ToInt32(tcd.Rows[i]["M_ID"]) == Convert.ToInt32(MedName_comboBox.ValueMember))
                        AlreadyTakeMed = true;
                }

                if (AlreadyTakeMed)
                {
                    DialogResult result = MessageBox.Show("The Patient already have that medicine in his prescription," +
                                    " do want to update the medicine info for the patient? ", "", MessageBoxButtons.YesNo);
                    if (result.ToString().Equals("Yes"))
                        controllerObj.DeleteFromPresc(Pat_SSN, Convert.ToInt16(MedName_comboBox.SelectedValue));
                    else
                        return;
                }

                controllerObj.AddMedToPat(Pat_SSN, Convert.ToInt16(MedName_comboBox.SelectedValue), NumOfTimes_txt.Text, Notes_txt.Text);
                MessageBox.Show("Prescription is Updated Successfully.", "Message");
                AlreadyTakeMed = false;
            }
            else
            {
                MessageBox.Show("Please choose a medicien");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            tcd = controllerObj.GetPrescription(Pat_SSN);
            for (int i = 0; i < tcd.Rows.Count; i++)
            {
                if (Convert.ToInt32(tcd.Rows[i]["M_ID"]) == Convert.ToInt32(MedName_comboBox.SelectedValue))
                    AlreadyTakeMed = true;
            }

            if (AlreadyTakeMed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete (" + MedName_comboBox.SelectedItem.ToString() + ") from the patient?", "", MessageBoxButtons.YesNo);
                if (result.ToString().Equals("Yes"))
                {
                    controllerObj.DeleteFromPresc(Pat_SSN, Convert.ToInt16(MedName_comboBox.SelectedValue));
                    MessageBox.Show("Medicne is deleted Successfully.", "Message");
                }
            }
            else
                MessageBox.Show("Patient already don't take that medicine!");
            AlreadyTakeMed = false;
        }
    }
}
