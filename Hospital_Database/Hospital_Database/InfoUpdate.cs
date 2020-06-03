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
    public partial class InfoUpdate : Form
    {
        int weight;
        Controller control;
        Form parent;
        int PSSN;
        int Height;
        public InfoUpdate(int a, Form parent)
        {
            InitializeComponent();
            control = new Controller();
            PSSN = a;
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (WeightBox.Text != "")
                {
                    weight = Convert.ToInt32(WeightBox.Text);
                    if (weight < 0)
                        throw new Exception();
                }
                if (HeightBox.Text != "")
                {
                    Height = Convert.ToInt32(HeightBox.Text);
                    if (Height < 0)
                    {
                        throw new Exception();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Enter a Valid Value");
                return;
            }

            if (HeightBox.Text != "")
            {
                int x = control.UpdateHeight(PSSN, Height);
                if (x == 0)
                {
                    MessageBox.Show("Height is NOT updated :( ");
                    return;
                }
            }
            if (WeightBox.Text != "")
            {
                int x = control.UpdateWeight(PSSN, weight);
                if (x == 0)
                {
                    MessageBox.Show("Weight is NOT updated :( ");
                    return;
                }
            }
            if (bloodTypeCB.Text != "")
            {
                int x = control.UpdateBloodyType(PSSN, bloodTypeCB.Text);
                if (x == 0)
                {
                    MessageBox.Show("BloodyType is NOT updated :( ");
                    return;
                }
            }
            if (HeightBox.Text != "" || WeightBox.Text != "" || bloodTypeCB.Text != "")
                MessageBox.Show("Update is Done");
            else MessageBox.Show("No thing to be updated");

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
