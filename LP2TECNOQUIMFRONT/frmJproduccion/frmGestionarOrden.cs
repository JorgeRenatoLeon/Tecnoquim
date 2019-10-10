using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmGestionarOrden : Form
    {
        public frmGestionarOrden()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();

        }

        public void limpiarComponentes()
        {
            txtNOrden.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProducto formProducto = new frmProducto();
            formProducto.Visible = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrden formProducto = new frmOrden();
            formProducto.Visible = true;
            this.Close();
        }

        private void frmGestionarOrden_Load(object sender, EventArgs e)
        {

        }
    }
}
