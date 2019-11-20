using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmOrden : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        int not = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmOrden(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            InitializeComponent();
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
        }        

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formGestionarOrden = new frmGestionarOrden();
            formGestionarOrden.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmOrdenes form = new frmOrdenes();
            form.ShowDialog(this);
        }

        private void frmOrden_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1, this.trabajador);
            fromJProd.Visible = true;
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

        private void button4_Click(object sender, EventArgs e)
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InsumosRestringidos formInsR = new InsumosRestringidos(this.trabajador);
            formInsR.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
