using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmModCalidadI : Form
    {

        BindingList<String> datoE = new BindingList<string>();
        Service.detalleAlmacenInsumo detalle = new Service.detalleAlmacenInsumo();
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmModCalidadI()
        {
            InitializeComponent();
            txtid.Enabled = false;
            txtNom.Enabled = false;
            txtStock.Enabled = false;
            txtLote.Enabled = false;
            

            datoE.Add("Rechazado");
            datoE.Add("Corregido");

            cbRol.DataSource = datoE;

            txtid.Enabled = false;
            txtLote.Enabled = false;
            txtNom.Enabled = false;
            txtStock.Enabled = false;
        }


        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmListaInsumo formListaInsumo = new frmListaInsumo();
            if (formListaInsumo.ShowDialog(this) == DialogResult.OK)
            {
                detalle = formListaInsumo.DetalleSeleccionada;
                txtid.Text = detalle.id.ToString();
                txtNom.Text = detalle.insumo.nombre.ToString();
                txtLote.Text = detalle.nLote.ToString();
                txtStock.Text = detalle.stock.ToString();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            string dato = cbRol.SelectedValue.ToString();

            if(txtid.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un lote de Insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dato == "Rechazado")
            {
                detalle.estado = Service.estadoMaterial.Bueno;
                detalle.estadoSpecified = true;
            }
            else if (dato == "Corregido")
            {
                detalle.estado = Service.estadoMaterial.Rechazado;
                detalle.estadoSpecified = true;
            }

            DBController.actualizarDetalleAlmacenInsumoEstado(detalle); 
            MessageBox.Show("Insumo Verificado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Text = "";
            txtLote.Text = "";
            txtNom.Text = "";
            txtStock.Text = "";
        }
    }
}
