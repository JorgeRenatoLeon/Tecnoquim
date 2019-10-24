using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmOrden : Form
    {
        int close = 0;
        public frmOrden()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

       

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas();
            formConsultas.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formGestionarOrden = new frmGestionarOrden();
            formGestionarOrden.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHistorialOrden form = new frmHistorialOrden();
            form.Visible = true;
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

        private void frmOrden_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
