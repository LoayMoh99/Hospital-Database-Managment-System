namespace Hospital_Database
{
    partial class Add_Nurse
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
            this.ST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status";
            // 
            // ST
            // 
            this.ST.BackColor = System.Drawing.SystemColors.Window;
            this.ST.Location = new System.Drawing.Point(125, 88);
            this.ST.Name = "ST";
            this.ST.ReadOnly = true;
            this.ST.Size = new System.Drawing.Size(251, 22);
            this.ST.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "SSN";
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(125, 29);
            this.SSN.MaxLength = 50;
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(140, 22);
            this.SSN.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Add_Nurse";
            this.Text = "Add_Nurse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}