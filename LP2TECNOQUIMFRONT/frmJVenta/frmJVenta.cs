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

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmJVenta : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.proyeccionVenta proyeccionVenta = new Service.proyeccionVenta();

        int close = 0;
        int not = 0;
        public frmJVenta(int cont=0, Service.trabajador trabajadors = null)
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

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
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

        private void frmJVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnPMS_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            today = today.AddMonths(1);
            Service.proyeccionVenta[] pvs = DBController.listarProyeccionVenta(today.ToString("yyyy-MM"));
            if (pvs == null)
            {
                proyeccionVenta.periodo = today;
                proyeccionVenta.periodoSpecified = true;
                DBController.insertarProyeccionVenta(proyeccionVenta);
                Service.proyeccionVenta[] pvs2 = DBController.listarProyeccionVenta(today.ToString("yyyy-MM"));
                proyeccionVenta = pvs2[pvs2.Length - 1];
            }
            else {
                proyeccionVenta = pvs[pvs.Length - 1];
            }
            frmGestionarProyeccionVenta formRegistro = new frmGestionarProyeccionVenta(proyeccionVenta, true);
            formRegistro.Visible = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmBuscarProyeccionVenta frmBuscarPV = new frmBuscarProyeccionVenta();
            frmBuscarPV.Visible = true;
        }
    }
}
