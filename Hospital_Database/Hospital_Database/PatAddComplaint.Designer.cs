namespace Hospital_Database
{
    partial class PatAddComplaint
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.complaintTB = new System.Windows.Forms.TextBox();
            this.hosIdCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Complaint:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hospital Name:";
            // 
            // submitBT
            // 
            this.submitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBT.Location = new System.Drawing.Point(186, 232);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(129, 42);
            this.submitBT.TabIndex = 7;
            this.submitBT.Text = "Submit";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // complaintTB
            // 
            this.complaintTB.Location = new System.Drawing.Point(76, 98);
            this.complaintTB.Multiline = true;
            this.complaintTB.Name = "complaintTB";
            this.complaintTB.Size = new System.Drawing.Size(353, 115);
            this.complaintTB.TabIndex = 6;
            // 
            // hosIdCB
            // 
            this.hosIdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hosIdCB.FormattingEnabled = true;
            this.hosIdCB.Location = new System.Drawing.Point(146, 36);
            this.hosIdCB.Name = "hosIdCB";
            this.hosIdCB.Size = new System.Drawing.Size(121, 21);
            this.hosIdCB.TabIndex = 5;
            // 
            // PatAddComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.complaintTB);
            this.Controls.Add(this.hosIdCB);
            this.Name = "PatAddComplaint";
            this.Text = "PatAddComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.TextBox complaintTB;
        private System.Windows.Forms.ComboBox hosIdCB;
    }
}