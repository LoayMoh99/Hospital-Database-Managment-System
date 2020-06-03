namespace Hospital_Database
{
    partial class PatNo
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
            this.Hospital2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hospital2TableAdapter = new Hospital_Database.ReportsTableAdapters.Hospital2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Hospital2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital_Database.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(791, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.DataSetName = "Reports";
            this.Reports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hospital2BindingSource
            // 
            this.Hospital2BindingSource.DataMember = "Hospital2";
            this.Hospital2BindingSource.DataSource = this.Reports;
            // 
            // Hospital2TableAdapter
            // 
            this.Hospital2TableAdapter.ClearBeforeFill = true;
            // 
            // PatNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 390);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PatNo";
            this.Text = "PatNo";
            this.Load += new System.EventHandler(this.PatNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Hospital2BindingSource;
        private Reports Reports;
        private ReportsTableAdapters.Hospital2TableAdapter Hospital2TableAdapter;
    }
}