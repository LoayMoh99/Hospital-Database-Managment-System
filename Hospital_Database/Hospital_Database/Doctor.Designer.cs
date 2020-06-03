namespace Hospital_Database
{
    partial class Doctor
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
            this.Prescription_btn = new System.Windows.Forms.Button();
            this.AddRecord_btn = new System.Windows.Forms.Button();
            this.Prescription_richTxt = new System.Windows.Forms.RichTextBox();
            this.Records_richTxt = new System.Windows.Forms.RichTextBox();
            this.AddChrncDis_btn = new System.Windows.Forms.Button();
            this.ChronicDiseases_richTxt = new System.Windows.Forms.RichTextBox();
            this.BloodType_txt = new System.Windows.Forms.TextBox();
            this.Height_txt = new System.Windows.Forms.TextBox();
            this.Weight_txt = new System.Windows.Forms.TextBox();
            this.Gender_txt = new System.Windows.Forms.TextBox();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowData_btn = new System.Windows.Forms.Button();
            this.PatientSsn_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.xrayBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prescription_btn
            // 
            this.Prescription_btn.Enabled = false;
            this.Prescription_btn.Location = new System.Drawing.Point(400, 229);
            this.Prescription_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prescription_btn.Name = "Prescription_btn";
            this.Prescription_btn.Size = new System.Drawing.Size(70, 127);
            this.Prescription_btn.TabIndex = 36;
            this.Prescription_btn.Text = "Write Prescription";
            this.Prescription_btn.UseVisualStyleBackColor = true;
            this.Prescription_btn.Click += new System.EventHandler(this.Prescription_btn_Click_1);
            // 
            // AddRecord_btn
            // 
            this.AddRecord_btn.Enabled = false;
            this.AddRecord_btn.Location = new System.Drawing.Point(475, 229);
            this.AddRecord_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecord_btn.Name = "AddRecord_btn";
            this.AddRecord_btn.Size = new System.Drawing.Size(152, 37);
            this.AddRecord_btn.TabIndex = 35;
            this.AddRecord_btn.Text = "Add Record";
            this.AddRecord_btn.UseVisualStyleBackColor = true;
            this.AddRecord_btn.Click += new System.EventHandler(this.AddRecord_btn_Click);
            // 
            // Prescription_richTxt
            // 
            this.Prescription_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prescription_richTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Prescription_richTxt.Location = new System.Drawing.Point(212, 229);
            this.Prescription_richTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prescription_richTxt.Name = "Prescription_richTxt";
            this.Prescription_richTxt.ReadOnly = true;
            this.Prescription_richTxt.Size = new System.Drawing.Size(185, 128);
            this.Prescription_richTxt.TabIndex = 34;
            this.Prescription_richTxt.Text = "";
            // 
            // Records_richTxt
            // 
            this.Records_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Records_richTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Records_richTxt.Location = new System.Drawing.Point(368, 48);
            this.Records_richTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Records_richTxt.Name = "Records_richTxt";
            this.Records_richTxt.ReadOnly = true;
            this.Records_richTxt.Size = new System.Drawing.Size(260, 163);
            this.Records_richTxt.TabIndex = 33;
            this.Records_richTxt.Text = "";
            // 
            // AddChrncDis_btn
            // 
            this.AddChrncDis_btn.Enabled = false;
            this.AddChrncDis_btn.Location = new System.Drawing.Point(212, 149);
            this.AddChrncDis_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddChrncDis_btn.Name = "AddChrncDis_btn";
            this.AddChrncDis_btn.Size = new System.Drawing.Size(135, 33);
            this.AddChrncDis_btn.TabIndex = 32;
            this.AddChrncDis_btn.Text = "Add Chronic Disease";
            this.AddChrncDis_btn.UseVisualStyleBackColor = true;
            this.AddChrncDis_btn.Click += new System.EventHandler(this.AddChrncDis_btn_Click_1);
            // 
            // ChronicDiseases_richTxt
            // 
            this.ChronicDiseases_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChronicDiseases_richTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChronicDiseases_richTxt.Location = new System.Drawing.Point(212, 48);
            this.ChronicDiseases_richTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChronicDiseases_richTxt.Name = "ChronicDiseases_richTxt";
            this.ChronicDiseases_richTxt.ReadOnly = true;
            this.ChronicDiseases_richTxt.Size = new System.Drawing.Size(136, 97);
            this.ChronicDiseases_richTxt.TabIndex = 31;
            this.ChronicDiseases_richTxt.Text = "";
            // 
            // BloodType_txt
            // 
            this.BloodType_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BloodType_txt.Location = new System.Drawing.Point(82, 292);
            this.BloodType_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BloodType_txt.Name = "BloodType_txt";
            this.BloodType_txt.ReadOnly = true;
            this.BloodType_txt.Size = new System.Drawing.Size(98, 20);
            this.BloodType_txt.TabIndex = 29;
            // 
            // Height_txt
            // 
            this.Height_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Height_txt.Location = new System.Drawing.Point(69, 259);
            this.Height_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Height_txt.Name = "Height_txt";
            this.Height_txt.ReadOnly = true;
            this.Height_txt.Size = new System.Drawing.Size(90, 20);
            this.Height_txt.TabIndex = 28;
            // 
            // Weight_txt
            // 
            this.Weight_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Weight_txt.Location = new System.Drawing.Point(69, 227);
            this.Weight_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weight_txt.Name = "Weight_txt";
            this.Weight_txt.ReadOnly = true;
            this.Weight_txt.Size = new System.Drawing.Size(90, 20);
            this.Weight_txt.TabIndex = 27;
            // 
            // Gender_txt
            // 
            this.Gender_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gender_txt.Location = new System.Drawing.Point(69, 194);
            this.Gender_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gender_txt.Name = "Gender_txt";
            this.Gender_txt.ReadOnly = true;
            this.Gender_txt.Size = new System.Drawing.Size(110, 20);
            this.Gender_txt.TabIndex = 26;
            // 
            // Age_txt
            // 
            this.Age_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Age_txt.Location = new System.Drawing.Point(69, 162);
            this.Age_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.ReadOnly = true;
            this.Age_txt.Size = new System.Drawing.Size(110, 20);
            this.Age_txt.TabIndex = 25;
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name_txt.Location = new System.Drawing.Point(69, 129);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.ReadOnly = true;
            this.Name_txt.Size = new System.Drawing.Size(110, 20);
            this.Name_txt.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Blood Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Prescription :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Records :-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chronic Diseases :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // ShowData_btn
            // 
            this.ShowData_btn.Location = new System.Drawing.Point(12, 58);
            this.ShowData_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowData_btn.Name = "ShowData_btn";
            this.ShowData_btn.Size = new System.Drawing.Size(166, 51);
            this.ShowData_btn.TabIndex = 13;
            this.ShowData_btn.Text = "Show Patient Data\r\n";
            this.ShowData_btn.UseVisualStyleBackColor = true;
            this.ShowData_btn.Click += new System.EventHandler(this.ShowData_btn_Click);
            // 
            // PatientSsn_txt
            // 
            this.PatientSsn_txt.Location = new System.Drawing.Point(86, 20);
            this.PatientSsn_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientSsn_txt.Name = "PatientSsn_txt";
            this.PatientSsn_txt.Size = new System.Drawing.Size(94, 20);
            this.PatientSsn_txt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient\'s SSN: ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(475, 274);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 82);
            this.button6.TabIndex = 37;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // xrayBT
            // 
            this.xrayBT.Enabled = false;
            this.xrayBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrayBT.Location = new System.Drawing.Point(20, 321);
            this.xrayBT.Margin = new System.Windows.Forms.Padding(2);
            this.xrayBT.Name = "xrayBT";
            this.xrayBT.Size = new System.Drawing.Size(146, 38);
            this.xrayBT.TabIndex = 38;
            this.xrayBT.Text = "Add X-ray ";
            this.xrayBT.UseVisualStyleBackColor = true;
            this.xrayBT.Click += new System.EventHandler(this.xrayBT_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 370);
            this.Controls.Add(this.xrayBT);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Prescription_btn);
            this.Controls.Add(this.AddRecord_btn);
            this.Controls.Add(this.Prescription_richTxt);
            this.Controls.Add(this.Records_richTxt);
            this.Controls.Add(this.AddChrncDis_btn);
            this.Controls.Add(this.ChronicDiseases_richTxt);
            this.Controls.Add(this.BloodType_txt);
            this.Controls.Add(this.Height_txt);
            this.Controls.Add(this.Weight_txt);
            this.Controls.Add(this.Gender_txt);
            this.Controls.Add(this.Age_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowData_btn);
            this.Controls.Add(this.PatientSsn_txt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doctor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prescription_btn;
        private System.Windows.Forms.Button AddRecord_btn;
        private System.Windows.Forms.RichTextBox Prescription_richTxt;
        private System.Windows.Forms.RichTextBox Records_richTxt;
        private System.Windows.Forms.Button AddChrncDis_btn;
        private System.Windows.Forms.RichTextBox ChronicDiseases_richTxt;
        private System.Windows.Forms.TextBox BloodType_txt;
        private System.Windows.Forms.TextBox Height_txt;
        private System.Windows.Forms.TextBox Weight_txt;
        private System.Windows.Forms.TextBox Gender_txt;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowData_btn;
        private System.Windows.Forms.TextBox PatientSsn_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button xrayBT;
    }
}