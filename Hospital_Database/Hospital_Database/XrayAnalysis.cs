using System;
using System.IO;
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
    public partial class XrayAnalysis : Form
    {
        Controller controllerObj;
        int Pssn;
        DataTable img;
        Image[] xrays;
        int iNew = 0;
        public XrayAnalysis(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Pssn = pssn;
            img = controllerObj.GetXrayImage(Pssn);
            if (img == null)
            {
                xrayPicB.Image = null;
                this.Close();
                return;
            }
            xrays = new Image[img.Rows.Count];

        }

        private void XrayAnalysis_Load(object sender, EventArgs e)
        {
            //retrival of the image
            byte[] image;
            int count = 0;
            for (int i = 0; i < img.Rows.Count; i++)
            {
                try
                {
                    image = ((byte[])img.Rows[i][0]);
                }
                catch
                {
                    image = null;
                }
                if (image != null)
                {
                    MemoryStream ms = new MemoryStream(image);
                    xrays[i] = Image.FromStream(ms);
                    count++;
                }
            }
            if (count == 0)
            {
                xrayPicB.Image = null;
                MessageBox.Show("You don't have a X-ray image to be shown!!");
                this.Close();
            }

            for (int i = 0; i < img.Rows.Count; i++)
            {
                if (xrays[i] != null)
                {
                    xrayPicB.Image = xrays[i];
                    iNew = i + 1;
                    break;
                }
            }
        }

        private void nextBT_Click(object sender, EventArgs e)
        {
            for (int i = iNew; i < img.Rows.Count; i++)
            {
                if (xrays[i] != null)
                {
                    xrayPicB.Image = xrays[i];
                    iNew = i + 1;
                    break;
                }
            }
        }
    }
}
