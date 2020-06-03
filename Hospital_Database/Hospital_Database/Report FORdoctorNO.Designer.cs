namespace Hospital_Database
{
    partial class Report_FORdoctorNO
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
            this.Hospital1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hospital1TableAdapter = new Hospital_Database.ReportsTableAdapters.Hospital1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Hospital1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital_Database.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.DataSetName = "Reports";
            this.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hospital1BindingSource
            // 
            this.Hospital1BindingSource.DataMember = "Hospital1";
            this.Hospital1BindingSource.DataSource = this.Reports;
            // 
            // Hospital1TableAdapter
            // 
            this.Hospital1TableAdapter.ClearBeforeFill = true;
            // 
            // Report_FORdoctorNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_FORdoctorNO";
            this.Text = "Report_FORdoctorNO";
            this.Load += new System.EventHandler(this.Report_FORdoctorNO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Hospital1BindingSource;
        private Reports Reports;
        private ReportsTableAdapters.Hospital1TableAdapter Hospital1TableAdapter;
    }
}