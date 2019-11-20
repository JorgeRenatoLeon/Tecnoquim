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
            

            datoE.Add("Bueno");
            datoE.Add("Pendiente");
            datoE.Add("Rechazado");

            cbRol.DataSource = datoE;

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


            if (dato == "Bueno")
            {
                detalle.estado = Service.estadoMaterial.Bueno;

            }
            else if (dato== "Pendiente")
            {
                detalle.estado = Service.estadoMaterial.Pendiente;
            }
            else if (dato == "Rechazado")
            {
                //detalle.estado = Service.estadoMaterial.Rechazado;
            }

            DBController.actualizarDetalleAlmacenInsumoEstado(detalle); 
            MessageBox.Show("Insumo Verificado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
