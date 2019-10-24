using LP2TECNOQUIMFRONT.frmPrincipal;
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

namespace LP2TECNOQUIMFRONT.frmJMaquinaria
{
    public partial class frmJMaquinaria : Form
    {
        int close = 0;
        public frmJMaquinaria(int cont = 0)
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

                t.Abort();
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formNot = new frmPerfil();
            formNot.Visible = true;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maquinaria Registrada Satisfactoriamente");
        }

        private void frmJMaquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
