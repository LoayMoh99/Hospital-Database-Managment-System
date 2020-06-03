using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Database
{
    public partial class AddXray : Form
    {
        Controller controllerObj;
        int Pssn;
        string imgSrc;
        public AddXray(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Pssn = pssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            FileStream str = new FileStream(imgSrc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(str);
            image = br.ReadBytes((int)str.Length);
            int r = controllerObj.AddXrayImage(Pssn, image);
            if (r > 0)
            {
                MessageBox.Show("The X-ray data is added!");
            }
            else MessageBox.Show("Sorry, but there was a problem while inserting the X-ray data!");
        }

        private void browseBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog d = new OpenFileDialog()
            {
                Filter = "png files(*.png)|*.png|jpg files(*.jpg)|All files(*.*)|*.*",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    imgSrc = d.FileName.ToString();
                    xrayPB.ImageLocation = imgSrc;
                }
            }
        }

        private void AddXray_Load(object sender, EventArgs e)
        {

        }

        private void browseBT_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog d = new OpenFileDialog()
            {
                Filter = "png files(*.png) | *.png | jpg files(*.jpg) |*.jpg| All files(*.*) | *.*",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    imgSrc = d.FileName.ToString();
                    xrayPB.ImageLocation = imgSrc;
                }
            }
        }

        private void xrayPB_Click(object sender, EventArgs e)
        {

        }

    }
}
