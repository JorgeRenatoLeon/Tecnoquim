﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));

            t.Start();

            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

        }

        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
