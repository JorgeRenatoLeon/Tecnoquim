using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT
{
    public partial class frmJProduccion : Form
    {
        public frmJProduccion(int cont = 0)
        {
<<<<<<< HEAD
            if (cont != 0)
=======
            if(cont != 0)
>>>>>>> b35b610c4da1b709520f45951abb6d2ea6e131ea
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(5000);

                InitializeComponent();

                t.Abort();
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

<<<<<<< HEAD
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbMinimize_Click(object sender, EventArgs e)
=======


        private void btnPMS_Click(object sender, EventArgs e)
        {

        }

        private void pbMinimize_Click_1(object sender, EventArgs e)
>>>>>>> b35b610c4da1b709520f45951abb6d2ea6e131ea
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

<<<<<<< HEAD
        private void btnPMS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPMS formPMS = new frmPMS();
            formPMS.Visible = true;
            this.Close();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrden formOrden = new frmOrden();
            formOrden.Visible = true;
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas();
            formConsultas.Visible = true;
            this.Close();
=======
        private void pbMaximize_Click_1(object sender, EventArgs e)
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
>>>>>>> b35b610c4da1b709520f45951abb6d2ea6e131ea
        }
    }
}
