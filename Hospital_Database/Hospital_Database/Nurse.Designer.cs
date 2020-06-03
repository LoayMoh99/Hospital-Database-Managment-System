namespace Hospital_Database
{
    partial class Nurse
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
            this.InfoUpdate = new System.Windows.Forms.Button();
            this.Prescription_richTxt = new System.Windows.Forms.RichTextBox();
            this.Records_richTxt = new System.Windows.Forms.RichTextBox();
            this.ChronicDiseases_richTxt = new System.Windows.Forms.RichTextBox();
            this.BloodType_txt = new System.Windows.Forms.TextBox();
            this.Height_txt = new System.Windows.Forms.TextBox();
            this.Weight_txt = new System.Windows.Forms.TextBox();
            this.Gender_txt = new System.Windows.Forms.TextBox();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // InfoUpdate
            // 
            this.InfoUpdate.Location = new System.Drawing.Point(507, 229);
            this.InfoUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoUpdate.Name = "InfoUpdate";
            this.InfoUpdate.Size = new System.Drawing.Size(140, 45);
            this.InfoUpdate.TabIndex = 59;
            this.InfoUpdate.Text = "UpdateInfo";
            this.InfoUpdate.UseVisualStyleBackColor = true;
            this.InfoUpdate.Click += new System.EventHandler(this.InfoUpdate_Click_1);
            // 
            // Prescription_richTxt
            // 
            this.Prescription_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prescription_richTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Prescription_richTxt.Location = new System.Drawing.Point(232, 229);
            this.Prescription_richTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prescription_richTxt.Name = "Prescription_richTxt";
            this.Prescription_richTxt.ReadOnly = true;
            this.Prescription_richTxt.Size = new System.Drawing.Size(155, 128);
            this.Prescription_richTxt.TabIndex = 58;
            this.Prescription_richTxt.Text = "";
            // 
            // Records_richTxt
            // 
            this.Records_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Records_richTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Records_richTxt.Location = new System.Drawing.Point(396, 48);
            this.Records_richTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Records_richTxt.Name = "Records_richTxt";
            this.Records_richTxt.ReadOnly = true;
            this.Records_richTxt.Size = new System.Drawing.Size(251, 147);
            this.Records_richTxt.TabIndex = 57;
            this.Records_richTxt.Text = "";
            // 
            // ChronicDiseases_richTxt
            // 
            this.ChronicDiseases_richTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChronicDiseases_richTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChronicDiseases_richTxt.Location = new System.Drawing.Point(232, 48);
            this.ChronicDiseases_richTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChronicDiseases_richTxt.Name = "ChronicDiseases_richTxt";
            this.ChronicDiseases_richTxt.ReadOnly = true;
            this.ChronicDiseases_richTxt.Size = new System.Drawing.Size(136, 147);
            this.ChronicDiseases_richTxt.TabIndex = 56;
            this.ChronicDiseases_richTxt.Text = "";
            // 
            // BloodType_txt
            // 
            this.BloodType_txt.Location = new System.Drawing.Point(102, 291);
            this.BloodType_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BloodType_txt.Name = "BloodType_txt";
            this.BloodType_txt.ReadOnly = true;
            this.BloodType_txt.Size = new System.Drawing.Size(97, 20);
            this.BloodType_txt.TabIndex = 54;
            // 
            // Height_txt
            // 
            this.Height_txt.Location = new System.Drawing.Point(89, 259);
            this.Height_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Height_txt.Name = "Height_txt";
            this.Height_txt.ReadOnly = true;
            this.Height_txt.Size = new System.Drawing.Size(90, 20);
            this.Height_txt.TabIndex = 53;
            // 
            // Weight_txt
            // 
            this.Weight_txt.Location = new System.Drawing.Point(89, 226);
            this.Weight_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Weight_txt.Name = "Weight_txt";
            this.Weight_txt.ReadOnly = true;
            this.Weight_txt.Size = new System.Drawing.Size(110, 20);
            this.Weight_txt.TabIndex = 52;
            // 
            // Gender_txt
            // 
            this.Gender_txt.Location = new System.Drawing.Point(89, 194);
            this.Gender_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gender_txt.Name = "Gender_txt";
            this.Gender_txt.ReadOnly = true;
            this.Gender_txt.Size = new System.Drawing.Size(110, 20);
            this.Gender_txt.TabIndex = 51;
            // 
            // Age_txt
            // 
            this.Age_txt.Location = new System.Drawing.Point(89, 161);
            this.Age_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.ReadOnly = true;
            this.Age_txt.Size = new System.Drawing.Size(110, 20);
            this.Age_txt.TabIndex = 55;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(89, 129);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.ReadOnly = true;
            this.Name_txt.Size = new System.Drawing.Size(110, 20);
            this.Name_txt.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Blood Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Prescription :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Records :-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Chronic Diseases :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name:";
            // 
            // ShowData_btn
            // 
            this.ShowData_btn.Location = new System.Drawing.Point(32, 57);
            this.ShowData_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowData_btn.Name = "ShowData_btn";
            this.ShowData_btn.Size = new System.Drawing.Size(166, 51);
            this.ShowData_btn.TabIndex = 39;
            this.ShowData_btn.Text = "Show Patient Data\r\n";
            this.ShowData_btn.UseVisualStyleBackColor = true;
            this.ShowData_btn.Click += new System.EventHandler(this.ShowData_btn_Click_1);
            // 
            // PatientSsn_txt
            // 
            this.PatientSsn_txt.Location = new System.Drawing.Point(106, 19);
            this.PatientSsn_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientSsn_txt.Name = "PatientSsn_txt";
            this.PatientSsn_txt.Size = new System.Drawing.Size(94, 20);
            this.PatientSsn_txt.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Patient\'s SSN: ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(507, 316);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 47);
            this.button6.TabIndex = 60;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.InfoUpdate);
            this.Controls.Add(this.Prescription_richTxt);
            this.Controls.Add(this.Records_richTxt);
            this.Controls.Add(this.ChronicDiseases_richTxt);
            this.Controls.Add(this.BloodType_txt);
            this.Controls.Add(this.Height_txt);
            this.Controls.Add(this.Weight_txt);
            this.Controls.Add(this.Gender_txt);
            this.Controls.Add(this.Age_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label7);
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
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Nurse_FormClosed);
            this.Load += new System.EventHandler(this.Nurse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoUpdate;
        private System.Windows.Forms.RichTextBox Prescription_richTxt;
        private System.Windows.Forms.RichTextBox Records_richTxt;
        private System.Windows.Forms.RichTextBox ChronicDiseases_richTxt;
        private System.Windows.Forms.TextBox BloodType_txt;
        private System.Windows.Forms.TextBox Height_txt;
        private System.Windows.Forms.TextBox Weight_txt;
        private System.Windows.Forms.TextBox Gender_txt;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label7;
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
    }
}