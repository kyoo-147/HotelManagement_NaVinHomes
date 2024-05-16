﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.CTControls
{
    public partial class CTMaximize : UserControl
    {
        private bool mouseHover = false;
        private bool mouseMove = false;
        private bool mouseLeave = false;
        public CTMaximize()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void maximize_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouseHover = false;
            mouseLeave = false;
            this.Invalidate();
        }

        private void maximize_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (mouseHover || mouseMove)
            {
                Bitmap bitmap = Properties.Resources.fixedMaxResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
            else if (mouseLeave)
            {
                Bitmap bitmap = Properties.Resources.fixedGreenResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
        }

        private void maximize_MouseHover(object sender, EventArgs e)
        {
            mouseMove = false;
            mouseHover = true;
            mouseLeave = false;
            this.Invalidate();
        }

        private void maximize_MouseLeave(object sender, EventArgs e)
        {
            mouseMove = false;
            mouseHover = false;
            mouseLeave = true;
            this.Invalidate();
        }
        public void turnOn()
        {
            mouseMove = true;
            mouseHover = true;
            this.Invalidate();
        }

        public void turnOff()
        {
            mouseMove = false;
            mouseHover = false;
            mouseLeave = true;
            this.Invalidate();
        }

        private void CTMaximize_Load(object sender, EventArgs e)
        {

        }
    }
}
