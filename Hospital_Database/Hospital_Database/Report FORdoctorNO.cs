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
    public partial class Report_FORdoctorNO : Form
    {
        public Report_FORdoctorNO()
        {
            InitializeComponent();
        }

        private void Report_FORdoctorNO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.Hospital1' table. You can move, or remove it, as needed.
            this.Hospital1TableAdapter.Fill(this.Reports.Hospital1);

            this.reportViewer1.RefreshReport();
        }
    }
}
