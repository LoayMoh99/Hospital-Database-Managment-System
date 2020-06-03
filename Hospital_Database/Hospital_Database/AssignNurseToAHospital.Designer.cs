namespace Hospital_Database
{
    partial class AssignNurseToAHospital
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
            this.label11 = new System.Windows.Forms.Label();
            this.ST = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.ComboBox();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.N = new System.Windows.Forms.ComboBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hMDSDataSet10 = new Hospital_Database.HMDSDataSet10();
            this.nurseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter1 = new Hospital_Database.HMDSDataSet10TableAdapters.NurseTableAdapter();
            this.hMDSDataSet11 = new Hospital_Database.HMDSDataSet11();
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter1 = new Hospital_Database.HMDSDataSet11TableAdapters.HospitalTableAdapter();
            this.hMDSDataSet16 = new Hospital_Database.HMDSDataSet16();
            this.nurseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter2 = new Hospital_Database.HMDSDataSet16TableAdapters.NurseTableAdapter();
            this.hMDSDataSet17 = new Hospital_Database.HMDSDataSet17();
            this.hospitalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter2 = new Hospital_Database.HMDSDataSet17TableAdapters.HospitalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Status";
            // 
            // ST
            // 
            this.ST.BackColor = System.Drawing.SystemColors.Window;
            this.ST.Location = new System.Drawing.Point(120, 136);
            this.ST.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ST.Name = "ST";
            this.ST.ReadOnly = true;
            this.ST.Size = new System.Drawing.Size(181, 20);
            this.ST.TabIndex = 36;
            // 
            // H
            // 
            this.H.DataSource = this.hospitalBindingSource2;
            this.H.DisplayMember = "Name";
            this.H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.H.FormattingEnabled = true;
            this.H.Location = new System.Drawing.Point(120, 71);
            this.H.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(116, 21);
            this.H.TabIndex = 35;
            this.H.ValueMember = "H_ID";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.SystemColors.Window;
            this.N.DataSource = this.nurseBindingSource2;
            this.N.DisplayMember = "Name";
            this.N.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.N.FormattingEnabled = true;
            this.N.Location = new System.Drawing.Point(120, 24);
            this.N.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(116, 21);
            this.N.TabIndex = 34;
            this.N.ValueMember = "N_SSN";
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hospital";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nurse";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 37);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hMDSDataSet10
            // 
            this.hMDSDataSet10.DataSetName = "HMDSDataSet10";
            this.hMDSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource1
            // 
            this.nurseBindingSource1.DataMember = "Nurse";
            this.nurseBindingSource1.DataSource = this.hMDSDataSet10;
            // 
            // nurseTableAdapter1
            // 
            this.nurseTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet11
            // 
            this.hMDSDataSet11.DataSetName = "HMDSDataSet11";
            this.hMDSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            this.hospitalBindingSource1.DataSource = this.hMDSDataSet11;
            // 
            // hospitalTableAdapter1
            // 
            this.hospitalTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet16
            // 
            this.hMDSDataSet16.DataSetName = "HMDSDataSet16";
            this.hMDSDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource2
            // 
            this.nurseBindingSource2.DataMember = "Nurse";
            this.nurseBindingSource2.DataSource = this.hMDSDataSet16;
            // 
            // nurseTableAdapter2
            // 
            this.nurseTableAdapter2.ClearBeforeFill = true;
            // 
            // hMDSDataSet17
            // 
            this.hMDSDataSet17.DataSetName = "HMDSDataSet17";
            this.hMDSDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource2
            // 
            this.hospitalBindingSource2.DataMember = "Hospital";
            this.hospitalBindingSource2.DataSource = this.hMDSDataSet17;
            // 
            // hospitalTableAdapter2
            // 
            this.hospitalTableAdapter2.ClearBeforeFill = true;
            // 
            // AssignNurseToAHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 256);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.H);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignNurseToAHospital";
            this.Text = "AssignNurseToAHospital";
            this.Load += new System.EventHandler(this.AssignNurseToAHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ST;
        private System.Windows.Forms.ComboBox H;
        private System.Windows.Forms.ComboBox N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private HMDSDataSet4 hMDSDataSet4;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private HMDSDataSet4TableAdapters.NurseTableAdapter nurseTableAdapter;
        private HMDSDataSet5 hMDSDataSet5;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private HMDSDataSet5TableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private HMDSDataSet10 hMDSDataSet10;
        private System.Windows.Forms.BindingSource nurseBindingSource1;
        private HMDSDataSet10TableAdapters.NurseTableAdapter nurseTableAdapter1;
        private HMDSDataSet11 hMDSDataSet11;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
        private HMDSDataSet11TableAdapters.HospitalTableAdapter hospitalTableAdapter1;
        private HMDSDataSet16 hMDSDataSet16;
        private System.Windows.Forms.BindingSource nurseBindingSource2;
        private HMDSDataSet16TableAdapters.NurseTableAdapter nurseTableAdapter2;
        private HMDSDataSet17 hMDSDataSet17;
        private System.Windows.Forms.BindingSource hospitalBindingSource2;
        private HMDSDataSet17TableAdapters.HospitalTableAdapter hospitalTableAdapter2;
    }
}