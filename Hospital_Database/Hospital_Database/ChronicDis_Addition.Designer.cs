namespace Hospital_Database
{
    partial class ChronicDis_Addition
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChDis_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(49, 143);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(206, 46);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add Chronic Disease";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chronic Disease name:";
            // 
            // ChDis_txt
            // 
            this.ChDis_txt.Location = new System.Drawing.Point(49, 75);
            this.ChDis_txt.Multiline = true;
            this.ChDis_txt.Name = "ChDis_txt";
            this.ChDis_txt.Size = new System.Drawing.Size(206, 32);
            this.ChDis_txt.TabIndex = 6;
            // 
            // ChronicDis_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 236);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChDis_txt);
            this.Name = "ChronicDis_Addition";
            this.Text = "ChronicDis_Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChDis_txt;
    }
}