using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmGerente : Form
    {
        int close = 0;
        public frmGerente(int cont=0, string usuario="")
        {
            if (cont != 0)
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(2500);

                InitializeComponent();

                MessageBox.Show("Bienvenido "+usuario);

                t.Abort();
            }
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
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHistorialPlan formHistorial = new frmHistorialPlan();
            formHistorial.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmValidarPlan formValidacion = new frmValidarPlan();
            formValidacion.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
