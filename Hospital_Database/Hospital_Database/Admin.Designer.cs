namespace Hospital_Database
{
    partial class Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.showPat = new System.Windows.Forms.Button();
            this.showDoc = new System.Windows.Forms.Button();
            this.showNur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Hospital";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Manager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "AssignManager to a Hospital";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 199);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 38);
            this.button6.TabIndex = 9;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // showPat
            // 
            this.showPat.Location = new System.Drawing.Point(185, 116);
            this.showPat.Margin = new System.Windows.Forms.Padding(2);
            this.showPat.Name = "showPat";
            this.showPat.Size = new System.Drawing.Size(123, 38);
            this.showPat.TabIndex = 12;
            this.showPat.Text = "Show Patients No.";
            this.showPat.UseVisualStyleBackColor = true;
            this.showPat.Click += new System.EventHandler(this.showPat_Click);
            // 
            // showDoc
            // 
            this.showDoc.Location = new System.Drawing.Point(312, 116);
            this.showDoc.Margin = new System.Windows.Forms.Padding(2);
            this.showDoc.Name = "showDoc";
            this.showDoc.Size = new System.Drawing.Size(123, 38);
            this.showDoc.TabIndex = 11;
            this.showDoc.Text = "Show Doctors No.";
            this.showDoc.UseVisualStyleBackColor = true;
            this.showDoc.Click += new System.EventHandler(this.showDoc_Click);
            // 
            // showNur
            // 
            this.showNur.Location = new System.Drawing.Point(58, 116);
            this.showNur.Margin = new System.Windows.Forms.Padding(2);
            this.showNur.Name = "showNur";
            this.showNur.Size = new System.Drawing.Size(123, 38);
            this.showNur.TabIndex = 10;
            this.showNur.Text = "Show Nurses No.";
            this.showNur.UseVisualStyleBackColor = true;
            this.showNur.Click += new System.EventHandler(this.showNur_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 275);
            this.Controls.Add(this.showPat);
            this.Controls.Add(this.showDoc);
            this.Controls.Add(this.showNur);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button showPat;
        private System.Windows.Forms.Button showDoc;
        private System.Windows.Forms.Button showNur;
    }
}