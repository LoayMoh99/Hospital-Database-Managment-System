namespace Hospital_Database
{
    partial class XrayAnalysis
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
            this.nextBT = new System.Windows.Forms.Button();
            this.xrayPicB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xrayPicB)).BeginInit();
            this.SuspendLayout();
            // 
            // nextBT
            // 
            this.nextBT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nextBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBT.Location = new System.Drawing.Point(756, 436);
            this.nextBT.Name = "nextBT";
            this.nextBT.Size = new System.Drawing.Size(125, 29);
            this.nextBT.TabIndex = 3;
            this.nextBT.Text = "Next..";
            this.nextBT.UseVisualStyleBackColor = false;
            this.nextBT.Click += new System.EventHandler(this.nextBT_Click);
            // 
            // xrayPicB
            // 
            this.xrayPicB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xrayPicB.Location = new System.Drawing.Point(12, 8);
            this.xrayPicB.Name = "xrayPicB";
            this.xrayPicB.Size = new System.Drawing.Size(893, 422);
            this.xrayPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xrayPicB.TabIndex = 2;
            this.xrayPicB.TabStop = false;
            // 
            // XrayAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 482);
            this.Controls.Add(this.nextBT);
            this.Controls.Add(this.xrayPicB);
            this.Name = "XrayAnalysis";
            this.Text = "XrayAnalysis";
            this.Load += new System.EventHandler(this.XrayAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xrayPicB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextBT;
        private System.Windows.Forms.PictureBox xrayPicB;
    }
}