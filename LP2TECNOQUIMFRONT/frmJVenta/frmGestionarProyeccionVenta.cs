using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmGestionarProyeccionVenta : Form
    {
        public frmGestionarProyeccionVenta()
        {
            InitializeComponent();
            BindingList<String> meses;
            meses = new BindingList<String>();
            meses.Add("Enero");
            meses.Add("Febrero");
            meses.Add("Marzo");
            meses.Add("Abril");
            meses.Add("Mayo");
            meses.Add("Junio");
            meses.Add("Julio");
            meses.Add("Agosto");
            meses.Add("Setiembre");
            meses.Add("Octubre");
            meses.Add("Noviembre");
            meses.Add("Diciembre");
            cbMes.DataSource = meses;

            BindingList<String> anios;
            anios = new BindingList<String>();
            anios.Add("2018");
            anios.Add("2019");
            anios.Add("2020");
            cbAnio.DataSource = anios;

            estadoComponentes(Estado.Inicial);
        }
        public void limpiarComponentes()
        {
            txtCodigoP.Text = "";
            txtNombreP.Text = "";
            txtCantidadP.Text = "";
        }

        public void estadoComponentes(Estado estado) {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarP.Enabled = false;
                    btnEliminarP.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    gbDatosG.Enabled = false;
                    gbDatosP.Enabled = false;
                    dgvProductos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnAgregarP.Enabled = true;
                    btnEliminarP.Enabled = true;
                    btnBuscarProducto.Enabled = true;
                    gbDatosG.Enabled = true;
                    gbDatosP.Enabled = true;
                    dgvProductos.Enabled = true;
                    break;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto formBuscarP = new frmBuscarProducto();
            formBuscarP.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
