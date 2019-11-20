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
    public partial class frmInstructivo : Form
    {
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmInstructivo()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = DBController.listarProductos("");
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Service.instructivo instFila = (Service.instructivo)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            Service.producto prodFila = (Service.producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells["Id"].Value = prodFila.instructivo.id;
            dgvProductos.Rows[e.RowIndex].Cells["Actividades"].Value = prodFila.instructivo.actividades;
            dgvProductos.Rows[e.RowIndex].Cells["Producto"].Value = prodFila.nombre;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DBController.listarProductos(txtNombre.Text);
        }
    }
}
