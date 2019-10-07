using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MARKETSOFTFRONT
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
    }
}
