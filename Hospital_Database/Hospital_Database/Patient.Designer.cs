namespace Hospital_Database
{
    partial class Patient
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
            this.chronicDisesesRB = new System.Windows.Forms.RichTextBox();
            this.pssnTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.complaintBT = new System.Windows.Forms.Button();
            this.prescBT = new System.Windows.Forms.Button();
            this.recordsBT = new System.Windows.Forms.Button();
            this.bloodTyTB = new System.Windows.Forms.TextBox();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chronicDisesesRB
            // 
            this.chronicDisesesRB.Location = new System.Drawing.Point(279, 111);
            this.chronicDisesesRB.Name = "chronicDisesesRB";
            this.chronicDisesesRB.ReadOnly = true;
            this.chronicDisesesRB.Size = new System.Drawing.Size(147, 212);
            this.chronicDisesesRB.TabIndex = 46;
            this.chronicDisesesRB.Text = "";
            // 
            // pssnTB
            // 
            this.pssnTB.Location = new System.Drawing.Point(372, 20);
            this.pssnTB.Multiline = true;
            this.pssnTB.Name = "pssnTB";
            this.pssnTB.ReadOnly = true;
            this.pssnTB.Size = new System.Drawing.Size(56, 28);
            this.pssnTB.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Your SSN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 265);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "kg";
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(109, 301);
            this.heightTB.Margin = new System.Windows.Forms.Padding(2);
            this.heightTB.Name = "heightTB";
            this.heightTB.ReadOnly = true;
            this.heightTB.Size = new System.Drawing.Size(60, 20);
            this.heightTB.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 304);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Height";
            // 
            // complaintBT
            // 
            this.complaintBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintBT.Location = new System.Drawing.Point(504, 214);
            this.complaintBT.Name = "complaintBT";
            this.complaintBT.Size = new System.Drawing.Size(179, 46);
            this.complaintBT.TabIndex = 39;
            this.complaintBT.Text = "Add Complaint";
            this.complaintBT.UseVisualStyleBackColor = true;
            this.complaintBT.Click += new System.EventHandler(this.complaintBT_Click_1);
            // 
            // prescBT
            // 
            this.prescBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescBT.Location = new System.Drawing.Point(504, 159);
            this.prescBT.Name = "prescBT";
            this.prescBT.Size = new System.Drawing.Size(179, 45);
            this.prescBT.TabIndex = 38;
            this.prescBT.Text = "Show My Prescription";
            this.prescBT.UseVisualStyleBackColor = true;
            this.prescBT.Click += new System.EventHandler(this.prescBT_Click_1);
            // 
            // recordsBT
            // 
            this.recordsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsBT.Location = new System.Drawing.Point(504, 111);
            this.recordsBT.Name = "recordsBT";
            this.recordsBT.Size = new System.Drawing.Size(179, 41);
            this.recordsBT.TabIndex = 37;
            this.recordsBT.Text = "Show My Records";
            this.recordsBT.UseVisualStyleBackColor = true;
            this.recordsBT.Click += new System.EventHandler(this.recordsBT_Click);
            // 
            // bloodTyTB
            // 
            this.bloodTyTB.Location = new System.Drawing.Point(164, 214);
            this.bloodTyTB.Name = "bloodTyTB";
            this.bloodTyTB.ReadOnly = true;
            this.bloodTyTB.Size = new System.Drawing.Size(59, 20);
            this.bloodTyTB.TabIndex = 36;
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(109, 262);
            this.weightTB.Name = "weightTB";
            this.weightTB.ReadOnly = true;
            this.weightTB.Size = new System.Drawing.Size(57, 20);
            this.weightTB.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(65, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(158, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Blood Type";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 43);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chronic Diseses";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderTB
            // 
            this.genderTB.Location = new System.Drawing.Point(55, 214);
            this.genderTB.Name = "genderTB";
            this.genderTB.ReadOnly = true;
            this.genderTB.Size = new System.Drawing.Size(57, 20);
            this.genderTB.TabIndex = 31;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(81, 139);
            this.ageTB.Name = "ageTB";
            this.ageTB.ReadOnly = true;
            this.ageTB.Size = new System.Drawing.Size(113, 20);
            this.ageTB.TabIndex = 30;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(81, 94);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(113, 20);
            this.nameTB.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(504, 269);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 54);
            this.button6.TabIndex = 47;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 374);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.chronicDisesesRB);
            this.Controls.Add(this.pssnTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.heightTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.complaintBT);
            this.Controls.Add(this.prescBT);
            this.Controls.Add(this.recordsBT);
            this.Controls.Add(this.bloodTyTB);
            this.Controls.Add(this.weightTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Patient_FormClosed);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chronicDisesesRB;
        private System.Windows.Forms.TextBox pssnTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button complaintBT;
        private System.Windows.Forms.Button prescBT;
        private System.Windows.Forms.Button recordsBT;
        private System.Windows.Forms.TextBox bloodTyTB;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}