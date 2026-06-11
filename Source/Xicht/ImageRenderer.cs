/*
    Xicht - Visual CPU load monitoring tool
    Image rendering class
    Copyright (c) 2026 by Ralf Kilian
    Distributed under the MIT License (https://opensource.org/licenses/MIT)

    GitHub: https://github.com/urbanware-org/xicht
    GitLab: https://gitlab.com/urbanware-org/xicht
*/

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class SmoothImageRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
    {
        if (e.Image != null)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = e.ImageRectangle;
            g.DrawImage(e.Image, bounds);
        }
    }
}