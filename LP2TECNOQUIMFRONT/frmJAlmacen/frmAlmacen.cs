using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.Visible = true;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProducto formProducto = new frmProducto();
            formProducto.Visible = true;
            this.Close();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmInsumo formInsumo = new frmInsumo();
            formInsumo.Visible = true;
            this.Close();
        }
    }
}
