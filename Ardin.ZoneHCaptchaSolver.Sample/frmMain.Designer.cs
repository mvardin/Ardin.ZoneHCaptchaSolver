
namespace Ardin.ZoneHCaptchaSolver.Sample
{
    partial class frmMain
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
            this.btnLoadCaptcha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblSolvedCaptchaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadCaptcha
            // 
            this.btnLoadCaptcha.Location = new System.Drawing.Point(12, 12);
            this.btnLoadCaptcha.Name = "btnLoadCaptcha";
            this.btnLoadCaptcha.Size = new System.Drawing.Size(169, 23);
            this.btnLoadCaptcha.TabIndex = 0;
            this.btnLoadCaptcha.Text = "Load Captcha from zone-h";
            this.btnLoadCaptcha.UseVisualStyleBackColor = true;
            this.btnLoadCaptcha.Click += new System.EventHandler(this.btnLoadCaptcha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 213);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(169, 23);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve the captcha";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblSolvedCaptchaText
            // 
            this.lblSolvedCaptchaText.AutoSize = true;
            this.lblSolvedCaptchaText.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolvedCaptchaText.Location = new System.Drawing.Point(158, 267);
            this.lblSolvedCaptchaText.Name = "lblSolvedCaptchaText";
            this.lblSolvedCaptchaText.Size = new System.Drawing.Size(116, 46);
            this.lblSolvedCaptchaText.TabIndex = 3;
            this.lblSolvedCaptchaText.Text = "====";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 349);
            this.Controls.Add(this.lblSolvedCaptchaText);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadCaptcha);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Ardin Zone-h Captcha Solver by ML.NET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCaptcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblSolvedCaptchaText;
    }
}