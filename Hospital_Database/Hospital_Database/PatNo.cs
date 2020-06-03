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
    public partial class PatNo : Form
    {
        public PatNo()
        {
            InitializeComponent();
        }

        private void PatNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reports.Hospital2' table. You can move, or remove it, as needed.
            this.Hospital2TableAdapter.Fill(this.Reports.Hospital2);

            this.reportViewer1.RefreshReport();
        }
    }
}
