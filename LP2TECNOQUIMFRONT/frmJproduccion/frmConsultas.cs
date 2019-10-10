using LP2TECNOQUIMFRONT.frmJproduccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT
{
    public partial class frmConsultas : Form
    {
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
            frmProductos formProducto = new frmProductos();
            formProducto.Visible = true;
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            formInsumos.Visible = true;
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            frmMaquinarias formMaquinaria = new frmMaquinarias();
            formMaquinaria.Visible = true;
        }

        private void btnPolitica_Click(object sender, EventArgs e)
        {
            frmPolitica formPolitica = new frmPolitica();
            formPolitica.Visible = true;
        }
    }
}
