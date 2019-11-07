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

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmBuscarProducto : Form
    {
        private Service.producto productoSeleccionado;


        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmBuscarProducto()
        {
            
            InitializeComponent();
            dgvHistorialPlan.AutoGenerateColumns = false;
            dgvHistorialPlan.DataSource = DBController.listarProductos("");
        }

        public producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        private void dgvHistorialPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.producto productoFila = (Service.producto)dgvHistorialPlan.Rows[e.RowIndex].DataBoundItem;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Nombre"].Value = productoFila.nombre;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Presentacion"].Value = productoFila.presentacion;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Granularidad"].Value = productoFila.granularidad;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Restriccion"].Value = productoFila.restriccion;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHistorialPlan.DataSource = DBController.listarProductos(txtNombre.Text);


        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            productoSeleccionado = (Service.producto)dgvHistorialPlan.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
