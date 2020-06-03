namespace Hospital_Database
{
    partial class Medicine_Addition
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
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Notes_txt = new System.Windows.Forms.TextBox();
            this.NumOfTimes_txt = new System.Windows.Forms.TextBox();
            this.MedName_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(167, 219);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(136, 61);
            this.Delete_btn.TabIndex = 14;
            this.Delete_btn.Text = "Delete Medicine from patient";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(27, 219);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(136, 61);
            this.Confirm_btn.TabIndex = 13;
            this.Confirm_btn.Text = "Add Medicine to patient";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Notes_txt
            // 
            this.Notes_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Notes_txt.Location = new System.Drawing.Point(147, 119);
            this.Notes_txt.Multiline = true;
            this.Notes_txt.Name = "Notes_txt";
            this.Notes_txt.Size = new System.Drawing.Size(156, 70);
            this.Notes_txt.TabIndex = 12;
            // 
            // NumOfTimes_txt
            // 
            this.NumOfTimes_txt.Location = new System.Drawing.Point(147, 80);
            this.NumOfTimes_txt.Name = "NumOfTimes_txt";
            this.NumOfTimes_txt.Size = new System.Drawing.Size(156, 22);
            this.NumOfTimes_txt.TabIndex = 11;
            // 
            // MedName_comboBox
            // 
            this.MedName_comboBox.FormattingEnabled = true;
            this.MedName_comboBox.Location = new System.Drawing.Point(147, 37);
            this.MedName_comboBox.Name = "MedName_comboBox";
            this.MedName_comboBox.Size = new System.Drawing.Size(156, 24);
            this.MedName_comboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label4.Location = new System.Drawing.Point(218, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Max 50 Character)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note (Optional):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of times:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medicine Name:";
            // 
            // Medicine_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Notes_txt);
            this.Controls.Add(this.NumOfTimes_txt);
            this.Controls.Add(this.MedName_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Medicine_Addition";
            this.Text = "Medicine_Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.TextBox Notes_txt;
        private System.Windows.Forms.TextBox NumOfTimes_txt;
        private System.Windows.Forms.ComboBox MedName_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}