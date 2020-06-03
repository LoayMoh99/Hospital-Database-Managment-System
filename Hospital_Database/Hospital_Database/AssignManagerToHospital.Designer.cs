namespace Hospital_Database
{
    partial class AssignManagerToHospital
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.ComboBox();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.M = new System.Windows.Forms.ComboBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.ST = new System.Windows.Forms.TextBox();
            this.hMDSDataSet8 = new Hospital_Database.HMDSDataSet8();
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter1 = new Hospital_Database.HMDSDataSet8TableAdapters.HospitalTableAdapter();
            this.hMDSDataSet9 = new Hospital_Database.HMDSDataSet9();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter1 = new Hospital_Database.HMDSDataSet9TableAdapters.ManagerTableAdapter();
            this.hMDSDataSet14 = new Hospital_Database.HMDSDataSet14();
            this.hospitalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter2 = new Hospital_Database.HMDSDataSet14TableAdapters.HospitalTableAdapter();
            this.hMDSDataSet15 = new Hospital_Database.HMDSDataSet15();
            this.managerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter2 = new Hospital_Database.HMDSDataSet15TableAdapters.ManagerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hospital";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.SystemColors.Window;
            this.H.DataSource = this.hospitalBindingSource2;
            this.H.DisplayMember = "Name";
            this.H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.H.FormattingEnabled = true;
            this.H.Location = new System.Drawing.Point(99, 24);
            this.H.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(116, 21);
            this.H.TabIndex = 12;
            this.H.ValueMember = "H_ID";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            // 
            // M
            // 
            this.M.DataSource = this.managerBindingSource2;
            this.M.DisplayMember = "Name";
            this.M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.M.FormattingEnabled = true;
            this.M.Location = new System.Drawing.Point(99, 70);
            this.M.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(116, 21);
            this.M.TabIndex = 13;
            this.M.ValueMember = "M_SSN";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Status";
            // 
            // ST
            // 
            this.ST.BackColor = System.Drawing.SystemColors.Window;
            this.ST.Location = new System.Drawing.Point(99, 134);
            this.ST.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ST.Name = "ST";
            this.ST.ReadOnly = true;
            this.ST.Size = new System.Drawing.Size(181, 20);
            this.ST.TabIndex = 20;
            // 
            // hMDSDataSet8
            // 
            this.hMDSDataSet8.DataSetName = "HMDSDataSet8";
            this.hMDSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            this.hospitalBindingSource1.DataSource = this.hMDSDataSet8;
            // 
            // hospitalTableAdapter1
            // 
            this.hospitalTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet9
            // 
            this.hMDSDataSet9.DataSetName = "HMDSDataSet9";
            this.hMDSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.hMDSDataSet9;
            // 
            // managerTableAdapter1
            // 
            this.managerTableAdapter1.ClearBeforeFill = true;
            // 
            // hMDSDataSet14
            // 
            this.hMDSDataSet14.DataSetName = "HMDSDataSet14";
            this.hMDSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource2
            // 
            this.hospitalBindingSource2.DataMember = "Hospital";
            this.hospitalBindingSource2.DataSource = this.hMDSDataSet14;
            // 
            // hospitalTableAdapter2
            // 
            this.hospitalTableAdapter2.ClearBeforeFill = true;
            // 
            // hMDSDataSet15
            // 
            this.hMDSDataSet15.DataSetName = "HMDSDataSet15";
            this.hMDSDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource2
            // 
            this.managerBindingSource2.DataMember = "Manager";
            this.managerBindingSource2.DataSource = this.hMDSDataSet15;
            // 
            // managerTableAdapter2
            // 
            this.managerTableAdapter2.ClearBeforeFill = true;
            // 
            // AssignManagerToHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 240);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.M);
            this.Controls.Add(this.H);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignManagerToHospital";
            this.Text = "AssignManagerToHospital";
            this.Load += new System.EventHandler(this.AssignManagerToHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMDSDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox H;
        private System.Windows.Forms.ComboBox M;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ST;
        private HMDSDataSet hMDSDataSet;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private HMDSDataSetTableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private HMDSDataSet1 hMDSDataSet1;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private HMDSDataSet1TableAdapters.ManagerTableAdapter managerTableAdapter;
        private HMDSDataSet8 hMDSDataSet8;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
        private HMDSDataSet8TableAdapters.HospitalTableAdapter hospitalTableAdapter1;
        private HMDSDataSet9 hMDSDataSet9;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private HMDSDataSet9TableAdapters.ManagerTableAdapter managerTableAdapter1;
        private HMDSDataSet14 hMDSDataSet14;
        private System.Windows.Forms.BindingSource hospitalBindingSource2;
        private HMDSDataSet14TableAdapters.HospitalTableAdapter hospitalTableAdapter2;
        private HMDSDataSet15 hMDSDataSet15;
        private System.Windows.Forms.BindingSource managerBindingSource2;
        private HMDSDataSet15TableAdapters.ManagerTableAdapter managerTableAdapter2;
    }
}