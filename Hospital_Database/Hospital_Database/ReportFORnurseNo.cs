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
    public partial class ReportFORnurseNo : Form
    {
        public ReportFORnurseNo()
        {
            InitializeComponent();
        }

        private void ReportFORnurseNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.Hospital' table. You can move, or remove it, as needed.
            this.HospitalTableAdapter.Fill(this.Reports.Hospital);

            this.reportViewer1.RefreshReport();
        }
    }
}
