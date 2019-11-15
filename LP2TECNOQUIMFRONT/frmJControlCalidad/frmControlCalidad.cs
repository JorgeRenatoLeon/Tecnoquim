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
using LP2TECNOQUIMFRONT.frmJproduccion;

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmControlCalidad : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        public frmControlCalidad(int cont =0, Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            if (cont != 0)
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(1250);

                InitializeComponent();

                MessageBox.Show("Bienvenido/a " + trabajador.nombres + " " + trabajador.apellidos);

                t.Abort();
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmModCalidad formProducto = new frmModCalidad();
            formProducto.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmModCalidadI formInsumo = new frmModCalidadI();
            formInsumo.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmControlCalidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
