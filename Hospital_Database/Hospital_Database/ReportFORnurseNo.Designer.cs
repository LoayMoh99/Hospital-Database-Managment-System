namespace Hospital_Database
{
    partial class ReportFORnurseNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reports = new Hospital_Database.Reports();
            this.HospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalTableAdapter = new Hospital_Database.ReportsTableAdapters.HospitalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HospitalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital_Database.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(732, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.DataSetName = "Reports";
            this.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HospitalBindingSource
            // 
            this.HospitalBindingSource.DataMember = "Hospital";
            this.HospitalBindingSource.DataSource = this.Reports;
            // 
            // HospitalTableAdapter
            // 
            this.HospitalTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFORnurseNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFORnurseNo";
            this.Text = "ReportFORnurseNo";
            this.Load += new System.EventHandler(this.ReportFORnurseNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HospitalBindingSource;
        private Reports Reports;
        private ReportsTableAdapters.HospitalTableAdapter HospitalTableAdapter;
    }
}