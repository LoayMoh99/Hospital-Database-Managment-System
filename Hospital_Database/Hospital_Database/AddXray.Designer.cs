namespace Hospital_Database
{
    partial class AddXray
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
            this.browseBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.xrayPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrayPB)).BeginInit();
            this.SuspendLayout();
            // 
            // browseBT
            // 
            this.browseBT.Location = new System.Drawing.Point(661, 372);
            this.browseBT.Name = "browseBT";
            this.browseBT.Size = new System.Drawing.Size(104, 27);
            this.browseBT.TabIndex = 18;
            this.browseBT.Text = "Browse..";
            this.browseBT.UseVisualStyleBackColor = true;
            this.browseBT.Click += new System.EventHandler(this.browseBT_Click_2);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add X-ray ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xrayPB
            // 
            this.xrayPB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrayPB.Location = new System.Drawing.Point(51, 37);
            this.xrayPB.Name = "xrayPB";
            this.xrayPB.Size = new System.Drawing.Size(714, 329);
            this.xrayPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xrayPB.TabIndex = 16;
            this.xrayPB.TabStop = false;
            // 
            // AddXray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(817, 475);
            this.Controls.Add(this.browseBT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xrayPB);
            this.Name = "AddXray";
            this.Text = "AddXray";
            ((System.ComponentModel.ISupportInitialize)(this.xrayPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox xrayPB;
    }
}