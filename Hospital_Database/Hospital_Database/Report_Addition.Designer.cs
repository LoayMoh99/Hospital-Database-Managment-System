namespace Hospital_Database
{
    partial class Report_Addition
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
            this.AddRecord_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Description_richTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddRecord_btn
            // 
            this.AddRecord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddRecord_btn.Location = new System.Drawing.Point(195, 213);
            this.AddRecord_btn.Name = "AddRecord_btn";
            this.AddRecord_btn.Size = new System.Drawing.Size(328, 44);
            this.AddRecord_btn.TabIndex = 5;
            this.AddRecord_btn.Text = "Add Record";
            this.AddRecord_btn.UseVisualStyleBackColor = true;
            this.AddRecord_btn.Click += new System.EventHandler(this.AddRecord_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // Description_richTxt
            // 
            this.Description_richTxt.Location = new System.Drawing.Point(135, 31);
            this.Description_richTxt.Name = "Description_richTxt";
            this.Description_richTxt.Size = new System.Drawing.Size(519, 162);
            this.Description_richTxt.TabIndex = 3;
            this.Description_richTxt.Text = "";
            // 
            // Report_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 287);
            this.Controls.Add(this.AddRecord_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description_richTxt);
            this.Name = "Report_Addition";
            this.Text = "Report_Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRecord_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Description_richTxt;
    }
}