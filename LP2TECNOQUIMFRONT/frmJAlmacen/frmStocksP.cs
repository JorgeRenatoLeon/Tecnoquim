using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmStocksP : Form
    {
        private Service.detalleAlmacenProducto productoSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStocksP()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = DBController.listarDetalleAlmacenProducto("");
        }
        public detalleAlmacenProducto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }
        
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DBController.listarDetalleAlmacenProducto(txtNombre.Text);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProductoSeleccionado = (Service.detalleAlmacenProducto)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleAlmacenProducto productoFila = (Service.detalleAlmacenProducto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value = productoFila.producto.nombre;
            dgvProductos.Rows[e.RowIndex].Cells["NoLote"].Value = productoFila.nLote.ToString();
            //dgvInsumo.Rows[e.RowIndex].Cells["Color"].Value = insumoFila.insumo.color;
            dgvProductos.Rows[e.RowIndex].Cells["Presentacion"].Value = productoFila.producto.presentacion;
            dgvProductos.Rows[e.RowIndex].Cells["Granularidad"].Value = productoFila.producto.granularidad;
            if (productoFila.producto.restriccion)
            {
                dgvProductos.Rows[e.RowIndex].Cells["Restriccion"].Value = "Si";
            }
            else
            {
                dgvProductos.Rows[e.RowIndex].Cells["Restriccion"].Value = "No";
            }
            dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value = productoFila.stock;

        }
    }
}
