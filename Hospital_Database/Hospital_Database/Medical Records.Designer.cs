namespace Hospital_Database
{
    partial class Medical_Records
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
            this.MR_RecdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mRRecdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKMRRecdsMRID398D8EEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMDSDataSet = new Hospital_Database.HMDSDataSet();
            this.mRRecdsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalRecordBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mRRecdsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.xrayBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MR_RecdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMRRecdsMRID398D8EEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // MR_RecdsBindingSource
            // 
            this.MR_RecdsBindingSource.DataMember = "MR_Recds";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(368, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // mRRecdsBindingSource
            // 
            this.mRRecdsBindingSource.DataMember = "MR_Recds";
            // 
            // medicalRecordBindingSource
            // 
            this.medicalRecordBindingSource.DataMember = "Medical_Record";
            // 
            // fKMRRecdsMRID398D8EEEBindingSource
            // 
            this.fKMRRecdsMRID398D8EEEBindingSource.DataMember = "FK__MR_Recds__MR_ID__398D8EEE";
            this.fKMRRecdsMRID398D8EEEBindingSource.DataSource = this.medicalRecordBindingSource;
            // 
            // medicalRecordBindingSource1
            // 
            this.medicalRecordBindingSource1.DataMember = "Medical_Record";
            // 
            // hMDSDataSet
            // 
            this.hMDSDataSet.DataSetName = "HMDSDataSet";
            this.hMDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mRRecdsBindingSource1
            // 
            this.mRRecdsBindingSource1.DataMember = "MR_Recds";
            this.mRRecdsBindingSource1.DataSource = this.hMDSDataSet;
            // 
            // medicalRecordBindingSource2
            // 
            this.medicalRecordBindingSource2.DataMember = "Medical_Record";
            // 
            // mRRecdsBindingSource2
            // 
            this.mRRecdsBindingSource2.DataMember = "MR_Recds";
            // 
            // xrayBT
            // 
            this.xrayBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrayBT.Location = new System.Drawing.Point(126, 206);
            this.xrayBT.Name = "xrayBT";
            this.xrayBT.Size = new System.Drawing.Size(188, 41);
            this.xrayBT.TabIndex = 7;
            this.xrayBT.Text = "Show My X-Rays";
            this.xrayBT.UseVisualStyleBackColor = true;
            this.xrayBT.Click += new System.EventHandler(this.xrayBT_Click_1);
            // 
            // Medical_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 255);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.xrayBT);
            this.Name = "Medical_Records";
            this.Text = "Medical_Records";
            this.Load += new System.EventHandler(this.Medical_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MR_RecdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.fKMRRecdsMRID398D8EEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.medicalRecordBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRRecdsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource MR_RecdsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mRRecdsBindingSource;
        private System.Windows.Forms.BindingSource medicalRecordBindingSource;
        private System.Windows.Forms.BindingSource fKMRRecdsMRID398D8EEEBindingSource;
        private System.Windows.Forms.BindingSource medicalRecordBindingSource1;
        private HMDSDataSet hMDSDataSet;
        private System.Windows.Forms.BindingSource mRRecdsBindingSource1;
        private System.Windows.Forms.BindingSource medicalRecordBindingSource2;
        private System.Windows.Forms.BindingSource mRRecdsBindingSource2;
        private System.Windows.Forms.Button xrayBT;
    }
}