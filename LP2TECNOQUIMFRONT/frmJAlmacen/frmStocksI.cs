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
    public partial class frmStocksI : Form
    {
        private Service.detalleAlmacenInsumo insumoSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmStocksI()
        {
            InitializeComponent();
            dgvInsumo.AutoGenerateColumns = false;
            dgvInsumo.DataSource = DBController.listarDetalleAlmacenInsumo("");
        }

        public Service.detalleAlmacenInsumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvInsumo.DataSource = DBController.listarDetalleAlmacenInsumo(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            InsumoSeleccionado = (Service.detalleAlmacenInsumo)dgvInsumo.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvInsumo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleAlmacenInsumo insumoFila = (Service.detalleAlmacenInsumo)dgvInsumo.Rows[e.RowIndex].DataBoundItem;
            dgvInsumo.Rows[e.RowIndex].Cells["Nombre"].Value = insumoFila.insumo.nombre;
            dgvInsumo.Rows[e.RowIndex].Cells["NoLote"].Value = insumoFila.nLote.ToString();
            //dgvInsumo.Rows[e.RowIndex].Cells["Color"].Value = insumoFila.insumo.color;
            dgvInsumo.Rows[e.RowIndex].Cells["Cantidad"].Value = insumoFila.insumo.cantidad;
            dgvInsumo.Rows[e.RowIndex].Cells["Unidad"].Value = insumoFila.insumo.unidad;
            if (insumoFila.insumo.restriccion)
            {
                dgvInsumo.Rows[e.RowIndex].Cells["Restriccion"].Value = "Si";
            }
            else
            {
                dgvInsumo.Rows[e.RowIndex].Cells["Restriccion"].Value = "No";
            }
            dgvInsumo.Rows[e.RowIndex].Cells["Stock"].Value = insumoFila.stock;
        }
    }
}
