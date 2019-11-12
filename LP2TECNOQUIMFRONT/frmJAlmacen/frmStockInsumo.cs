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
    public partial class frmStockInsumo : Form
    {
        private int stock;
        Service.insumo insumo;
        Service.detalleAlmacenInsumo detalle;
        Service.detalleAlmacenInsumo almacenI;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStockInsumo()
        {
            InitializeComponent();
            BindingList<Service.almacen> almacens = new BindingList<Service.almacen>(DBController.listarAlmacen(""));
            cbAlmacen.DataSource = almacens;
            cbAlmacen.DisplayMember = "Tipo";
        }
        

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmStocksI formInsumos = new frmStocksI();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                detalle = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = detalle.insumo.id.ToString();
                txtNombre.Text = detalle.insumo.nombre;
                txtCant.Text = detalle.insumo.cantidad.ToString();
                txtUnidad.Text = detalle.insumo.unidad.ToString();
                txtLote.Text = detalle.nLote.ToString();
                txtAct.Text = detalle.stock.ToString();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            almacenI = new Service.detalleAlmacenInsumo();
            insumo = new Service.insumo();
            insumo.id = int.Parse(txtCodigo.Text);

            almacenI.insumo = insumo;
            almacenI.stock = int.Parse(txtAct.Text);
            almacenI.nLote = int.Parse(txtLote.Text);
            DBController.actualizarDetalleAlmacenInsumo(almacenI);
            MessageBox.Show("Se actualizo el stock Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
