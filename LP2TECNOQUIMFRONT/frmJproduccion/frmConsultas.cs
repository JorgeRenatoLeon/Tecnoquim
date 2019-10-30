
using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmConsultas : Form
    {
        int close = 0;
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1);
            fromJProd.Visible = true;
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
            frmProducto formProducto = new frmProducto();
            formProducto.Visible = true;
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            formInsumos.Visible = true;
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            frmMaquinaria formMaquinaria = new frmMaquinaria();
            formMaquinaria.Visible = true;
        }

        private void btnPolitica_Click(object sender, EventArgs e)
        {
            frmPolitica formPolitica = new frmPolitica();
            formPolitica.Visible = true;
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

        private void frmConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
