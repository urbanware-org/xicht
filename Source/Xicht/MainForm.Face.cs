/******************************************************************************
 * Xicht - Visual CPU load monitoring tool                                    *
 * Partial class for face effect related code                                 *
 * Copyright (C) 2020 by Ralf Kilian                                          *
 * Distributed under the MIT License (https://opensource.org/licenses/MIT)    *
 *                                                                            *
 * GitHub: https://github.com/urbanware-org/xicht                             *
 * GitLab: https://gitlab.com/urbanware-org/xicht                             *
 ******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xicht
{
    partial class MainForm
    {

        #region Look around effect

        private void FaceLook()
        {
            string currentFace;

            if (maxHealth > 0)
            {
                switch (dir)
                {
                    case 1:
                        currentFace = "face_look_left_" + face.ToString();
                        break;

                    case 2:
                        currentFace = "face_look_right_" + face.ToString();
                        break;

                    default:
                        currentFace = "face_look_center_" + face.ToString();
                        break;
                }

                pbMain.Image = imlFaces.Images[currentFace];
                SetTrayIcon(currentFace);

                lastHealth = health;
            }
        }

        #endregion

        #region Extraordinary effects

        private void FaceDead()
        {
            string currentFace = "face_dead";

            pbMain.Image = imlFaces.Images[currentFace];
            SetTrayIcon(currentFace);

            lastHealth = health;
        }

        private void FaceHurt()
        {
            // Baby don't hurt me
            // Don't hurt me
            // No more...

            string currentFace;

            if (maxHealth > 0)
            {
                switch (dir)
                {
                    case 1:
                        currentFace = "face_hurt_left_" + face.ToString();
                        break;

                    case 2:
                        currentFace = "face_hurt_right_" + face.ToString();
                        break;

                    default:
                        currentFace = "face_hurt_center_" + face.ToString();
                        break;
                }

                pbMain.Image = imlFaces.Images[currentFace];
                SetTrayIcon(currentFace);

                lastHealth = health;
            }
        }

        private void FaceInvincible()
        {
            string currentFace = "face_invincible";

            pbMain.Image = imlFaces.Images[currentFace];
            SetTrayIcon(currentFace);

            lastHealth = health;
        }

        private void FaceShocked()
        {
            string currentFace = "face_shock_" + face.ToString();

            if (maxHealth > 0)
            {
                pbMain.Image = imlFaces.Images[currentFace];
                SetTrayIcon(currentFace);
            }

            lastHealth = health;
        }

        private void FaceSmile()
        {
            string currentFace = "face_smile_" + face.ToString();

            if (maxHealth > 0)
            {
                pbMain.Image = imlFaces.Images[currentFace];
                SetTrayIcon(currentFace);
            }

            lastHealth = health;
        }

        #endregion

    }
}
