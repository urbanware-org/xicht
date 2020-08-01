namespace Xicht
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblXicht = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lnkLicense = new System.Windows.Forms.LinkLabel();
            this.lblGraphics = new System.Windows.Forms.Label();
            this.pbReinchard = new System.Windows.Forms.PictureBox();
            this.pbAboutLogo = new System.Windows.Forms.PictureBox();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.lblHosted = new System.Windows.Forms.Label();
            this.lnkGitLab = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbReinchard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblXicht
            // 
            this.lblXicht.AutoSize = true;
            this.lblXicht.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXicht.Location = new System.Drawing.Point(82, 12);
            this.lblXicht.Name = "lblXicht";
            this.lblXicht.Size = new System.Drawing.Size(64, 30);
            this.lblXicht.TabIndex = 2;
            this.lblXicht.Text = "Xicht";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(84, 42);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(181, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Visual CPU load monitoring tool";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(84, 85);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(60, 15);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(84, 61);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 15);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(84, 109);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(119, 15);
            this.lblLicense.TabIndex = 6;
            this.lblLicense.Text = "Distributed under the";
            // 
            // lnkLicense
            // 
            this.lnkLicense.AutoSize = true;
            this.lnkLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLicense.Location = new System.Drawing.Point(201, 109);
            this.lnkLicense.Name = "lnkLicense";
            this.lnkLicense.Size = new System.Drawing.Size(70, 15);
            this.lnkLicense.TabIndex = 7;
            this.lnkLicense.TabStop = true;
            this.lnkLicense.Text = "MIT License";
            this.lnkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicense_LinkClicked);
            // 
            // lblGraphics
            // 
            this.lblGraphics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphics.Location = new System.Drawing.Point(84, 157);
            this.lblGraphics.Name = "lblGraphics";
            this.lblGraphics.Size = new System.Drawing.Size(321, 46);
            this.lblGraphics.TabIndex = 8;
            this.lblGraphics.Text = "Special thanks to Reinchard who designed and kindly provided the high resolution " +
    "face images used by default.";
            this.lblGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbReinchard
            // 
            this.pbReinchard.Image = global::Xicht.Properties.Resources.faces_reinchard;
            this.pbReinchard.Location = new System.Drawing.Point(411, 157);
            this.pbReinchard.Name = "pbReinchard";
            this.pbReinchard.Size = new System.Drawing.Size(47, 46);
            this.pbReinchard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReinchard.TabIndex = 9;
            this.pbReinchard.TabStop = false;
            // 
            // pbAboutLogo
            // 
            this.pbAboutLogo.Image = global::Xicht.Properties.Resources.Xicht_about;
            this.pbAboutLogo.Location = new System.Drawing.Point(12, 12);
            this.pbAboutLogo.Name = "pbAboutLogo";
            this.pbAboutLogo.Size = new System.Drawing.Size(64, 64);
            this.pbAboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAboutLogo.TabIndex = 0;
            this.pbAboutLogo.TabStop = false;
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitHub.Location = new System.Drawing.Point(217, 133);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(45, 15);
            this.lnkGitHub.TabIndex = 11;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "GitHub";
            this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
            // 
            // lblHosted
            // 
            this.lblHosted.AutoSize = true;
            this.lblHosted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHosted.Location = new System.Drawing.Point(84, 133);
            this.lblHosted.Name = "lblHosted";
            this.lblHosted.Size = new System.Drawing.Size(201, 15);
            this.lblHosted.TabIndex = 10;
            this.lblHosted.Text = "This project is hosted on               and";
            // 
            // lnkGitLab
            // 
            this.lnkGitLab.AutoSize = true;
            this.lnkGitLab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitLab.Location = new System.Drawing.Point(282, 133);
            this.lnkGitLab.Name = "lnkGitLab";
            this.lnkGitLab.Size = new System.Drawing.Size(41, 15);
            this.lnkGitLab.TabIndex = 12;
            this.lnkGitLab.TabStop = true;
            this.lnkGitLab.Text = "GitLab";
            this.lnkGitLab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitLab_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 223);
            this.ControlBox = false;
            this.Controls.Add(this.lnkGitLab);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.lblHosted);
            this.Controls.Add(this.pbReinchard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGraphics);
            this.Controls.Add(this.lnkLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblXicht);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbAboutLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReinchard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAboutLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblXicht;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.LinkLabel lnkLicense;
        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.PictureBox pbReinchard;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.Label lblHosted;
        private System.Windows.Forms.LinkLabel lnkGitLab;
    }
}