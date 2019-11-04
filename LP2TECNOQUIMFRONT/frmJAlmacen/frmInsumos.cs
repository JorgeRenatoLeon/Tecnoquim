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
    public partial class frmInsumos : Form
    {
        private Service.insumo insumoSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmInsumos()
        {
            InitializeComponent();
            dgvInsumo.AutoGenerateColumns = false;
            dgvInsumo.DataSource = DBController.listarInsumo("");
        }

        public insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }
                            

        private void dgvInsumo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.insumo insumoFila = (Service.insumo)dgvInsumo.Rows[e.RowIndex].DataBoundItem;
            dgvInsumo.Rows[e.RowIndex].Cells["Nombre"].Value = insumoFila.nombre;
            dgvInsumo.Rows[e.RowIndex].Cells["Granularidad"].Value = insumoFila.granularidad.ToString();
            dgvInsumo.Rows[e.RowIndex].Cells["Color"].Value = insumoFila.color;
            dgvInsumo.Rows[e.RowIndex].Cells["Cantidad"].Value = insumoFila.cantidad;
            dgvInsumo.Rows[e.RowIndex].Cells["Unidad"].Value = insumoFila.unidad;
            if (insumoFila.restriccion)
            {
                dgvInsumo.Rows[e.RowIndex].Cells["Restriccion"].Value = "Si";
            }
            else
            {
                dgvInsumo.Rows[e.RowIndex].Cells["Restriccion"].Value = "No";
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvInsumo.DataSource = DBController.listarInsumo(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            InsumoSeleccionado = (Service.insumo)dgvInsumo.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
