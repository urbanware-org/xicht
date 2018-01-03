/******************************************************************************
 * Xicht - Visual CPU load monitoring tool                                    *
 * Copyright (C) 2018 by Ralf Kilian                                          *
 * Distributed under the MIT License (https://opensource.org/licenses/MIT)    *
 *                                                                            *
 * GitHub: https://github.com/urbanware-org/xicht                             *
 ******************************************************************************/

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Xicht
{
    public partial class MainForm : Form
    {

        #region Variable declarations

        private int health = 100;
        private int face = 100;
        private int dir = 0;

        private int lastHealth = 100;
        private int maxHealth = 100;

        private int xpos = 100;
        private int ypos = 100;

        private int height = 180;
        private int width = 200;

        private bool freakOut = false;
        private bool randomHealth = false;

        private bool topMost = true;
        private bool trayIcon = false;

        private Random rnd = new Random();
        private PerformanceCounter cpuCounter;

        private bool canDestroyIcon = true;

        #endregion

        #region Main form constructor and load event handler

        public MainForm()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            string temp = String.Empty;
            foreach (String arg in args)
            {
                var larg = arg.ToLower();

                try
                {
                    if (larg.StartsWith("left="))
                    {
                        temp = larg.Replace("left=", "");
                        this.Left = Convert.ToInt32(temp);
                    }
                    if (larg.StartsWith("top="))
                    {
                        temp = larg.Replace("top=", "");
                        this.Top = Convert.ToInt32(temp);
                    }
                    if (larg.StartsWith("height="))
                    {
                        temp = larg.Replace("height=", "");
                        this.Height = Convert.ToInt32(temp);
                    }
                    if (larg.StartsWith("width="))
                    {
                        temp = larg.Replace("width=", "");
                        this.Width = Convert.ToInt32(temp);
                    }
                }
                catch {}

                if (larg == "disable-topmost")
                {
                    this.topMost = false;
                }

                if (larg == "tray")
                {
                    this.trayIcon = true;
                }
            }

            // This solves some problems with some tiling window managers on
            // Unix-like systems which don't like the TopMost option enabled
            // by default
            this.TopMost = topMost;

            foreach (string image in Directory.GetFiles(Path.Combine(Application.StartupPath, "Images"), "*.png", SearchOption.TopDirectoryOnly))
            {
                imlFaces.Images.Add(Path.GetFileNameWithoutExtension(image), Image.FromFile(image));
            }
            
            tsmFaceEffects.Image = imlFaces.Images["face_shock_100"];
            tsmFaceShocked.Image = imlFaces.Images["face_shock_100"];
            tsmFaceHurt.Image = imlFaces.Images["face_hurt_center_100"];
            tsmFaceSmile.Image = imlFaces.Images["face_smile_100"];
            tsmFaceInvincible.Image = imlFaces.Images["face_invincible"];

            tsmMaxHealth.Image = imlFaces.Images["face_look_center_100"];
            tsmMax100.Image = imlFaces.Images["face_look_center_100"];
            tsmMax80.Image = imlFaces.Images["face_look_center_80"];
            tsmMax60.Image = imlFaces.Images["face_look_center_60"];
            tsmMax40.Image = imlFaces.Images["face_look_center_40"];
            tsmMax20.Image = imlFaces.Images["face_look_center_20"];
            tsmMax0.Image = imlFaces.Images["face_dead"];
            tsmRandomHealth.Image = imlFaces.Images["face_shock_100"];

            tsmMood.Image = imlFaces.Images["face_smile_100"];
            tsmFreakOut.Image = imlFaces.Images["face_shock_60"];

            nfiTray.Visible = this.trayIcon;
            tsmTrayIcon.Checked = this.trayIcon;
        }

        #endregion

        #region Timer stuff

        private void ResetTimers()
        {
            tmrFace.Stop();
            tmrMeasurement.Stop();

            tmrFace.Start();
            tmrMeasurement.Start();
        }

        private void tmrFace_Tick(object sender, EventArgs e)
        {
            dir = rnd.Next(0, 3);

            if (freakOut)
            {
                FaceHurt();
                return;
            }

            if (health < 1)
            {
                if (freakOut)
                {
                    health = 1;
                    this.Text = "1 %";
                }
                else
                {
                    if (nfiTray.Visible)
                    {
                        FaceTray();
                    }
                    FaceDead();
                }
                return;
            }
            else if (health >= 100)
            {
                if (nfiTray.Visible)
                {
                    FaceTray();
                }
                FaceInvincible();
                return;
            }
            else if (health > lastHealth)
            {
                if ((health - lastHealth) > 10)
                {
                    FaceSmile();
                    return;
                }
            }
            else if (health < lastHealth)
            {
                if ((lastHealth - health) > 20)
                {
                    FaceShocked();
                    return;
                }
                else if ((lastHealth - health) > 5)
                {
                    FaceHurt();
                    return;
                }
            }
            lastHealth = health;

            if (nfiTray.Visible)
            {
                FaceTray();
            }
            FaceLook();
        }

        private void tmrMeasurement_Tick(object sender, EventArgs e)
        {
            if (!randomHealth)
            {
                health = maxHealth - (int)cpuCounter.NextValue();

                if (health > 100)
                {
                    health = 100;
                }
                else if (health < 0)
                {
                    health = 0;
                }
            }
            else
            {
                health = rnd.Next(1, 100);
            }

            this.Text = health.ToString() + " %";

            if (health > 80)
            {
                face = 100;
            }
            else if (health > 60)
            {
                face = 80;
            }
            else if (health > 40)
            {
                face = 60;
            }
            else if (health > 20)
            {
                face = 40;
            }
            else
            {
                face = 20;
            }
        }

        #endregion

        #region Face effect related methods

        private void FaceDead()
        {
            pbMain.Image = imlFaces.Images["face_dead"];
            lastHealth = health;
        }

        private void FaceHurt()
        {
            if (maxHealth > 0)
            {
                switch (dir)
                {
                    case 1:
                        pbMain.Image = imlFaces.Images["face_hurt_left_" + face.ToString()];
                        break;

                    case 2:
                        pbMain.Image = imlFaces.Images["face_hurt_right_" + face.ToString()];
                        break;

                    default:
                        pbMain.Image = imlFaces.Images["face_hurt_center_" + face.ToString()];
                        break;
                }
                lastHealth = health;
            }
        }

        private void FaceInvincible()
        {
            pbMain.Image = imlFaces.Images["face_invincible"];
            lastHealth = health;
        }

        private void FaceLook()
        {
            if (maxHealth > 0)
            {
                switch (dir)
                {
                    case 1:
                        pbMain.Image = imlFaces.Images["face_look_left_" + face.ToString()];
                        break;

                    case 2:
                        pbMain.Image = imlFaces.Images["face_look_right_" + face.ToString()];
                        break;

                    default:
                        pbMain.Image = imlFaces.Images["face_look_center_" + face.ToString()];
                        break;
                }
            }
        }
        
        private void FaceShocked()
        {
            if (maxHealth > 0)
            {
                pbMain.Image = imlFaces.Images["face_shock_" + face.ToString()];
                lastHealth = health;
            }
        }

        private void FaceSmile()
        {
            if (maxHealth > 0)
            {
                pbMain.Image = imlFaces.Images["face_smile_" + face.ToString()];
                lastHealth = health;
            }
        }

        #endregion

        #region Mood related methods

        private void FreakOut(bool enabled)
        {
            if (enabled)
            {
                freakOut = true;

                tsmFaceInvincible.Enabled = !enabled;
                tsmMax0.Enabled = !enabled;
                tmrFace.Interval = 360;
            }
            else
            {
                freakOut = false;

                tsmFaceInvincible.Enabled = !enabled;
                tsmMax0.Enabled = !enabled;
                tmrFace.Interval = 480;
            }
        }

        #endregion

        #region Percentage ("health") related methods

        private void RandomHealth()
        {
            randomHealth = true;
            tsmFaceInvincible.Enabled = false;
        }

        #endregion

        #region Tray icon related

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private void FaceTray()
        {
            if (pbMain.Image == null)
            {
                return;
            }

            Bitmap myBitmap = new Bitmap(pbMain.Image);
            IntPtr Hicon = myBitmap.GetHicon();
            Icon newIcon = Icon.FromHandle(Hicon);

            nfiTray.Icon = newIcon;
            nfiTray.Text = this.Text;

            if (canDestroyIcon)
            {
                try
                {
                    DestroyIcon(newIcon.Handle);
                }
                catch (System.DllNotFoundException)
                {
                    canDestroyIcon = false;
                }
            }
        }

        private void tsmTrayIcon_Click(object sender, EventArgs e)
        {
            if (tsmTrayIcon.Checked)
            {
                nfiTray.Visible = false;
                tsmTrayIcon.Checked = false;
            }
            else
            {
                nfiTray.Visible = true;
                tsmTrayIcon.Checked = true;
            }
        }

        #endregion

        #region Right-click menu event handlers

        private void tsmFreakOut_Click(object sender, EventArgs e)
        {
            FreakOut(tsmFreakOut.Checked);
        }

        private void tsmRandomHealth_Click(object sender, EventArgs e)
        {
            RandomHealth();
        }

        private void tsmFaceShocked_Click(object sender, EventArgs e)
        {
            tmrFace.Enabled = false;
            FaceShocked();
            tmrFace.Enabled = true;
        }

        private void tsmFaceHurt_Click(object sender, EventArgs e)
        {
            tmrFace.Enabled = false;
            FaceHurt();
            tmrFace.Enabled = true;
        }

        private void tsmFaceSmile_Click(object sender, EventArgs e)
        {
            tmrFace.Enabled = false;
            FaceSmile();
            tmrFace.Enabled = true;
        }

        private void tsmFaceInvincible_Click(object sender, EventArgs e)
        {
            tmrFace.Enabled = false;
            FaceInvincible();
            tmrFace.Enabled = true;
        }

        private void tsmMax100_Click(object sender, EventArgs e)
        {
            ResetTimers();

            tsmFaceEffects.Enabled = true;
            tsmFaceInvincible.Enabled = true;
            tsmRandomHealth.Enabled = true;
            tsmMood.Enabled = true;

            maxHealth = 100;
            randomHealth = false;
        }

        private void tsmMax80_Click(object sender, EventArgs e)
        {
            ResetTimers();

            tsmFaceEffects.Enabled = true;
            tsmFaceInvincible.Enabled = false;
            tsmRandomHealth.Enabled = true;
            tsmMood.Enabled = true;

            maxHealth = 80;
            randomHealth = false;
        }

        private void tsmMax60_Click(object sender, EventArgs e)
        {
            ResetTimers();

            tsmFaceEffects.Enabled = true;
            tsmFaceInvincible.Enabled = false;
            tsmRandomHealth.Enabled = true;
            tsmMood.Enabled = true;
            
            maxHealth = 60;
            randomHealth = false;
        }

        private void tsmMax40_Click(object sender, EventArgs e)
        {
            ResetTimers();

            tsmFaceEffects.Enabled = true;
            tsmFaceInvincible.Enabled = false;
            tsmRandomHealth.Enabled = true;
            tsmMood.Enabled = true;

            maxHealth = 40;
            randomHealth = false;
        }

        private void tsmMax20_Click(object sender, EventArgs e)
        {
            ResetTimers();

            tsmFaceEffects.Enabled = true;
            tsmFaceInvincible.Enabled = false;
            tsmRandomHealth.Enabled = true;
            tsmMood.Enabled = true;

            maxHealth = 20;
            randomHealth = false;
        }

        private void tsmMax0_Click(object sender, EventArgs e)
        {
            tsmFaceEffects.Enabled = false;
            tsmMood.Enabled = false;
            tsmRandomHealth.Enabled = false;

            maxHealth = 0;
            randomHealth = false;

            FaceDead();
            this.Text = "0 %";
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmRestoreSize_Click(object sender, EventArgs e)
        {
            this.Height = height;
            this.Width = width; 
        }

        private void tsmRestorePosition_Click(object sender, EventArgs e)
        {
            this.Left = xpos;
            this.Top = ypos;
        }

        #endregion

        #region About window

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion

    }
}

/* EOF */
