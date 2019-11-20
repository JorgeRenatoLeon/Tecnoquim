
using LP2TECNOQUIMFRONT.frmJAlmacen;
using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmConsultas : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        public frmConsultas(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1, this.trabajador);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmStocksP form = new frmStocksP();
            form.ShowDialog(this);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmStocksI form = new frmStocksI();
            form.ShowDialog(this);
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            frmMaquinaria formMaquinaria = new frmMaquinaria();
            formMaquinaria.ShowDialog(this);
        }

        private void btnPolitica_Click(object sender, EventArgs e)
        {
            frmPolitica formPolitica = new frmPolitica();
            formPolitica.ShowDialog(this);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            btnReporte formPerfil = new btnReporte(this.trabajador);
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

        private void frmConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InsumosRestringidos formInsR = new InsumosRestringidos();
            formInsR.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
