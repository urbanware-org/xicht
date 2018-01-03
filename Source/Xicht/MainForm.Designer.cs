namespace Xicht
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmsPreferences = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmHead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRestorePosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRestoreSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrayIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlaceHolder1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmFaceEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFaceInvincible = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFaceSmile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFaceHurt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFaceShocked = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMaxHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax80 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax60 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMax0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlaceHolder2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmRandomHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFreakOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrFace = new System.Windows.Forms.Timer(this.components);
            this.tmrMeasurement = new System.Windows.Forms.Timer(this.components);
            this.imlFaces = new System.Windows.Forms.ImageList(this.components);
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.ttContextMenu = new System.Windows.Forms.ToolTip(this.components);
            this.nfiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsPreferences
            // 
            this.cmsPreferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHead,
            this.tsmPlaceHolder1,
            this.tsmFaceEffects,
            this.tsmMaxHealth,
            this.tsmMood});
            this.cmsPreferences.Name = "cmsPreferences";
            this.cmsPreferences.Size = new System.Drawing.Size(171, 120);
            // 
            // tsmHead
            // 
            this.tsmHead.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRestorePosition,
            this.tsmRestoreSize,
            this.tsmTrayIcon,
            this.tsmAbout,
            this.tsmExit});
            this.tsmHead.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmHead.Image = global::Xicht.Properties.Resources.Xicht;
            this.tsmHead.Name = "tsmHead";
            this.tsmHead.Size = new System.Drawing.Size(170, 22);
            this.tsmHead.Text = "Xicht";
            // 
            // tsmRestorePosition
            // 
            this.tsmRestorePosition.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmRestorePosition.Image = global::Xicht.Properties.Resources.Xicht_restore;
            this.tsmRestorePosition.Name = "tsmRestorePosition";
            this.tsmRestorePosition.Size = new System.Drawing.Size(228, 22);
            this.tsmRestorePosition.Text = "Restore default window position";
            this.tsmRestorePosition.Click += new System.EventHandler(this.tsmRestorePosition_Click);
            // 
            // tsmRestoreSize
            // 
            this.tsmRestoreSize.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmRestoreSize.Image = global::Xicht.Properties.Resources.Xicht_restore;
            this.tsmRestoreSize.Name = "tsmRestoreSize";
            this.tsmRestoreSize.Size = new System.Drawing.Size(228, 22);
            this.tsmRestoreSize.Text = "Restore default window size";
            this.tsmRestoreSize.Click += new System.EventHandler(this.tsmRestoreSize_Click);
            // 
            // tsmTrayIcon
            // 
            this.tsmTrayIcon.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmTrayIcon.Image = global::Xicht.Properties.Resources.Xicht_tray;
            this.tsmTrayIcon.Name = "tsmTrayIcon";
            this.tsmTrayIcon.Size = new System.Drawing.Size(228, 22);
            this.tsmTrayIcon.Text = "Show tray icon";
            this.tsmTrayIcon.Click += new System.EventHandler(this.tsmTrayIcon_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmAbout.Image = global::Xicht.Properties.Resources.Xicht;
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(228, 22);
            this.tsmAbout.Text = "About";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsmExit.Image = global::Xicht.Properties.Resources.Xicht_exit;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(228, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmPlaceHolder1
            // 
            this.tsmPlaceHolder1.Name = "tsmPlaceHolder1";
            this.tsmPlaceHolder1.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmFaceEffects
            // 
            this.tsmFaceEffects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFaceInvincible,
            this.tsmFaceSmile,
            this.tsmFaceHurt,
            this.tsmFaceShocked});
            this.tsmFaceEffects.Name = "tsmFaceEffects";
            this.tsmFaceEffects.Size = new System.Drawing.Size(170, 22);
            this.tsmFaceEffects.Text = "Face effects";
            // 
            // tsmFaceInvincible
            // 
            this.tsmFaceInvincible.Name = "tsmFaceInvincible";
            this.tsmFaceInvincible.Size = new System.Drawing.Size(119, 22);
            this.tsmFaceInvincible.Text = "Invincible";
            this.tsmFaceInvincible.Click += new System.EventHandler(this.tsmFaceInvincible_Click);
            // 
            // tsmFaceSmile
            // 
            this.tsmFaceSmile.Name = "tsmFaceSmile";
            this.tsmFaceSmile.Size = new System.Drawing.Size(119, 22);
            this.tsmFaceSmile.Text = "Smile";
            this.tsmFaceSmile.Click += new System.EventHandler(this.tsmFaceSmile_Click);
            // 
            // tsmFaceHurt
            // 
            this.tsmFaceHurt.Name = "tsmFaceHurt";
            this.tsmFaceHurt.Size = new System.Drawing.Size(119, 22);
            this.tsmFaceHurt.Text = "Hurt";
            this.tsmFaceHurt.Click += new System.EventHandler(this.tsmFaceHurt_Click);
            // 
            // tsmFaceShocked
            // 
            this.tsmFaceShocked.Name = "tsmFaceShocked";
            this.tsmFaceShocked.Size = new System.Drawing.Size(119, 22);
            this.tsmFaceShocked.Text = "Shocked";
            this.tsmFaceShocked.Click += new System.EventHandler(this.tsmFaceShocked_Click);
            // 
            // tsmMaxHealth
            // 
            this.tsmMaxHealth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMax100,
            this.tsmMax80,
            this.tsmMax60,
            this.tsmMax40,
            this.tsmMax20,
            this.tsmMax0,
            this.tsmPlaceHolder2,
            this.tsmRandomHealth});
            this.tsmMaxHealth.Name = "tsmMaxHealth";
            this.tsmMaxHealth.Size = new System.Drawing.Size(170, 22);
            this.tsmMaxHealth.Text = "Set maximum health";
            // 
            // tsmMax100
            // 
            this.tsmMax100.Name = "tsmMax100";
            this.tsmMax100.Size = new System.Drawing.Size(113, 22);
            this.tsmMax100.Text = "Full";
            this.tsmMax100.Click += new System.EventHandler(this.tsmMax100_Click);
            // 
            // tsmMax80
            // 
            this.tsmMax80.Name = "tsmMax80";
            this.tsmMax80.Size = new System.Drawing.Size(113, 22);
            this.tsmMax80.Text = "80 %";
            this.tsmMax80.Click += new System.EventHandler(this.tsmMax80_Click);
            // 
            // tsmMax60
            // 
            this.tsmMax60.Name = "tsmMax60";
            this.tsmMax60.Size = new System.Drawing.Size(113, 22);
            this.tsmMax60.Text = "60 %";
            this.tsmMax60.Click += new System.EventHandler(this.tsmMax60_Click);
            // 
            // tsmMax40
            // 
            this.tsmMax40.Name = "tsmMax40";
            this.tsmMax40.Size = new System.Drawing.Size(113, 22);
            this.tsmMax40.Text = "40 %";
            this.tsmMax40.Click += new System.EventHandler(this.tsmMax40_Click);
            // 
            // tsmMax20
            // 
            this.tsmMax20.Name = "tsmMax20";
            this.tsmMax20.Size = new System.Drawing.Size(113, 22);
            this.tsmMax20.Text = "20 %";
            this.tsmMax20.Click += new System.EventHandler(this.tsmMax20_Click);
            // 
            // tsmMax0
            // 
            this.tsmMax0.Name = "tsmMax0";
            this.tsmMax0.Size = new System.Drawing.Size(113, 22);
            this.tsmMax0.Text = "Dead";
            this.tsmMax0.Click += new System.EventHandler(this.tsmMax0_Click);
            // 
            // tsmPlaceHolder2
            // 
            this.tsmPlaceHolder2.Name = "tsmPlaceHolder2";
            this.tsmPlaceHolder2.Size = new System.Drawing.Size(110, 6);
            // 
            // tsmRandomHealth
            // 
            this.tsmRandomHealth.Name = "tsmRandomHealth";
            this.tsmRandomHealth.Size = new System.Drawing.Size(113, 22);
            this.tsmRandomHealth.Text = "Random";
            this.tsmRandomHealth.Click += new System.EventHandler(this.tsmRandomHealth_Click);
            // 
            // tsmMood
            // 
            this.tsmMood.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFreakOut});
            this.tsmMood.Name = "tsmMood";
            this.tsmMood.Size = new System.Drawing.Size(170, 22);
            this.tsmMood.Text = "Set mood";
            // 
            // tsmFreakOut
            // 
            this.tsmFreakOut.CheckOnClick = true;
            this.tsmFreakOut.Name = "tsmFreakOut";
            this.tsmFreakOut.Size = new System.Drawing.Size(120, 22);
            this.tsmFreakOut.Text = "Freak out";
            this.tsmFreakOut.Click += new System.EventHandler(this.tsmFreakOut_Click);
            // 
            // tmrFace
            // 
            this.tmrFace.Enabled = true;
            this.tmrFace.Interval = 480;
            this.tmrFace.Tick += new System.EventHandler(this.tmrFace_Tick);
            // 
            // tmrMeasurement
            // 
            this.tmrMeasurement.Enabled = true;
            this.tmrMeasurement.Interval = 1000;
            this.tmrMeasurement.Tick += new System.EventHandler(this.tmrMeasurement_Tick);
            // 
            // imlFaces
            // 
            this.imlFaces.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlFaces.ImageSize = new System.Drawing.Size(256, 256);
            this.imlFaces.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Black;
            this.pbMain.ContextMenuStrip = this.cmsPreferences;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(192, 153);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            this.ttContextMenu.SetToolTip(this.pbMain, "Right-click for menu");
            // 
            // nfiTray
            // 
            this.nfiTray.ContextMenuStrip = this.cmsPreferences;
            this.nfiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTray.Icon")));
            this.nfiTray.Text = "Xicht";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(192, 153);
            this.Controls.Add(this.pbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MinimumSize = new System.Drawing.Size(64, 63);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Xicht";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cmsPreferences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.ContextMenuStrip cmsPreferences;
        private System.Windows.Forms.ToolStripMenuItem tsmFaceEffects;
        private System.Windows.Forms.ToolStripMenuItem tsmFaceShocked;
        private System.Windows.Forms.ToolStripMenuItem tsmFaceHurt;
        private System.Windows.Forms.ToolStripMenuItem tsmFaceSmile;
        private System.Windows.Forms.ToolStripMenuItem tsmFaceInvincible;
        private System.Windows.Forms.ToolStripMenuItem tsmMaxHealth;
        private System.Windows.Forms.ToolStripMenuItem tsmMax100;
        private System.Windows.Forms.ToolStripMenuItem tsmMax80;
        private System.Windows.Forms.ToolStripMenuItem tsmMax60;
        private System.Windows.Forms.ToolStripMenuItem tsmMax40;
        private System.Windows.Forms.ToolStripMenuItem tsmMax20;
        private System.Windows.Forms.ToolStripMenuItem tsmMax0;
        private System.Windows.Forms.ToolStripMenuItem tsmMood;
        private System.Windows.Forms.ToolStripMenuItem tsmFreakOut;
        private System.Windows.Forms.Timer tmrFace;
        private System.Windows.Forms.Timer tmrMeasurement;
        private System.Windows.Forms.ImageList imlFaces;
        private System.Windows.Forms.ToolStripMenuItem tsmHead;
        private System.Windows.Forms.ToolStripSeparator tsmPlaceHolder1;
        private System.Windows.Forms.ToolStripMenuItem tsmRestoreSize;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmRestorePosition;
        private System.Windows.Forms.ToolStripMenuItem tsmRandomHealth;
        private System.Windows.Forms.ToolStripSeparator tsmPlaceHolder2;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolTip ttContextMenu;
        private System.Windows.Forms.NotifyIcon nfiTray;
        private System.Windows.Forms.ToolStripMenuItem tsmTrayIcon;
    }
}

