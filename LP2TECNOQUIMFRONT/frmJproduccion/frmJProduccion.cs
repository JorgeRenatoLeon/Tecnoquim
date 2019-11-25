using System;
using LP2TECNOQUIMFRONT.frmPrincipal;
using System.Threading;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmJProduccion : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        int not = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmJProduccion(int cont = 0, Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            if (cont != 0)
            {
                InitializeComponent();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(1250);

                InitializeComponent();

                MessageBox.Show("Bienvenido/a " + trabajador.nombres + " " + trabajador.apellidos);

                t.Abort();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
            btnPerfil.Text = trabajador.nombres + "\n" + trabajador.apellidos;
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void frmJProduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnPMS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPMS formPMS = new frmPMS(this.trabajador);
            formPMS.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrden formOrden = new frmOrden(this.trabajador);
            formOrden.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas(this.trabajador);
            formConsultas.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            btnReporte formPerfil = new btnReporte(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InsumosRestringidos formInsR = new InsumosRestringidos(this.trabajador);
            formInsR.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
