using LP2TECNOQUIMFRONT.Service;
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
    public partial class frmProductos : Form
    {
        private Service.producto productoSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmProductos()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = DBController.listarProductos("");
        }

        public producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            ProductoSeleccionado = (Service.producto)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
        
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DBController.listarProductos(txtNombre.Text);
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.producto prodFila = (Service.producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value = prodFila.nombre;
            dgvProductos.Rows[e.RowIndex].Cells["Presentacion"].Value = prodFila.presentacion;
            dgvProductos.Rows[e.RowIndex].Cells["Granularidad"].Value = prodFila.granularidad;
            if (prodFila.restriccion)
            {
                dgvProductos.Rows[e.RowIndex].Cells["Restriccion"].Value = "Si";
            }
            else
            {
                dgvProductos.Rows[e.RowIndex].Cells["Restriccion"].Value = "No";
            }
            
        }

        
    }
}
