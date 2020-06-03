namespace Hospital_Database
{
    partial class Assign_Doctor_Dep
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
            this.DP = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMDSDataSet3 = new Hospital_Database.HMDSDataSet3();
            this.D = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMDSDataSet2 = new Hospital_Database.HMDSDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorTableAdapter = new Hospital_Database.HMDSDataSet2TableAdapters.DoctorTableAdapter();
            this.departmentsTableAdapter = new Hospital_Database.HMDSDataSet3TableAdapters.DepartmentsTableAdapter();
            this.hMDSDataSet6 = new Hospital_Database.HMDSDataSet6();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter = new Hospital_Database.HMDSDataSet6TableAdapters.HospitalTableAdapter();
            this.hMDSDataSet7 = new Hospital_Database.HMDSDataSet7();
            this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter1 = new Hospital_Database.HMDSDataSet7TableAdapters.DepartmentsTableAdapter();
            this.hMDSDataSet12 = new Hospital_Database.HMDSDataSet12();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter1 = new Hospital_Database.HMDSDataSet12TableAdapters.DoctorTableAdapter();
            this.hMDSDataSet13 = new Hospital_Database.HMDSDataSet13();
            this.departmentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter2 = new Hospital_Database.HMDSDataSet13TableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Status";
            // 
            // ST
            // 
            this.ST.BackColor = System.Drawing.SystemColors.Window;
            this.ST.Location = new System.Drawing.Point(115, 135);
            this.ST.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ST.Name = "ST";
            this.ST.ReadOnly = true;
            this.ST.Size = new System.Drawing.Size(181, 20);
            this.ST.TabIndex = 28;
            // 
            // DP
            // 
            this.DP.DataSource = this.departmentsBindingSource2;
            this.DP.DisplayMember = "Name";
            this.DP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DP.FormattingEnabled = true;
            this.DP.Location = new System.Drawing.Point(115, 69);
            this.DP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DP.Name = "DP";
            this.DP.Size = new System.Drawing.Size(116, 21);
            this.DP.TabIndex = 27;
            this.DP.ValueMember = "D_ID";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.hMDSDataSet3;
            // 
            // hMDSDataSet3
            // 
            this.hMDSDataSet3.DataSetName = "HMDSDataSet3";
            this.hMDSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.SystemColors.Window;
            this.D.DataSource = this.doctorBindingSource1;
            this.D.DisplayMember = "Name";
            this.D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.D.FormattingEnabled = true;
            this.D.Location = new System.Drawing.Point(115, 23);
            this.D.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(116, 21);
            this.D.TabIndex = 26;
            this.D.ValueMember = "D_SSN";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hMDSDataSet2;
            // 
            // hMDSDataSet2
            // 
            this.hMDSDataSet2.DataSetName = "HMDSDataSet2";
            this.hMDSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doctor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // hMDSDataSet6
            // 
            this.hMDSDataSet6.DataSetName = "HMDSDataSet6";
            this.hMDSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            this.hospitalBindingSource.DataSource = this.hMDSDataSet6;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // hMDSDataSet7
            // 
            this.hMDSDataSet7.DataSetName = "HMDSDataSet7";
            this.hMDSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource1
            // 
            this.departmentsBindingSource1.DataMember = "Departments";
            this.departmentsBindingSource1.DataSource = this.hMDSDataSet7;
            // 
            // departmentsTableAdapter1
            // 
            this.departmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet12
            // 
            this.hMDSDataSet12.DataSetName = "HMDSDataSet12";
            this.hMDSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.hMDSDataSet12;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet13
            // 
            this.hMDSDataSet13.DataSetName = "HMDSDataSet13";
            this.hMDSDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource2
            // 
            this.departmentsBindingSource2.DataMember = "Departments";
            this.departmentsBindingSource2.DataSource = this.hMDSDataSet13;
            // 
            // departmentsTableAdapter2
            // 
            this.departmentsTableAdapter2.ClearBeforeFill = true;
            // 
            // Assign_Doctor_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 241);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.DP);
            this.Controls.Add(this.D);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Assign_Doctor_Dep";
            this.Text = "Assign_Doctor_Dep";
            this.Load += new System.EventHandler(this.Assign_Doctor_Dep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ST;
        private System.Windows.Forms.ComboBox DP;
        private System.Windows.Forms.ComboBox D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private HMDSDataSet2 hMDSDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HMDSDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private HMDSDataSet3 hMDSDataSet3;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private HMDSDataSet3TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private HMDSDataSet6 hMDSDataSet6;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private HMDSDataSet6TableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private HMDSDataSet7 hMDSDataSet7;
        private System.Windows.Forms.BindingSource departmentsBindingSource1;
        private HMDSDataSet7TableAdapters.DepartmentsTableAdapter departmentsTableAdapter1;
        private HMDSDataSet12 hMDSDataSet12;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private HMDSDataSet12TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private HMDSDataSet13 hMDSDataSet13;
        private System.Windows.Forms.BindingSource departmentsBindingSource2;
        private HMDSDataSet13TableAdapters.DepartmentsTableAdapter departmentsTableAdapter2;
    }
}