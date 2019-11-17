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

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmListaOrden : Form
    {

        
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.lineaOrden lineaOrdenSeleccionada = new Service.lineaOrden();
        Service.ordenProduccion[] lineas;

        public lineaOrden LineaOrdenSeleccionada { get => lineaOrdenSeleccionada; set => lineaOrdenSeleccionada = value; }

        public frmListaOrden()
        {
            InitializeComponent();
            lineas =DBController.listarOrdenesProduccionFecha(DateTime.Now.ToString("yyyy-MM-dd"));
            
            dgvListaOrden.AutoGenerateColumns = false;
            dgvListaOrden.ReadOnly = true;
            if (lineas == null)
            {
                MessageBox.Show("No hay Ordenes pendientes por hoy", "Advertencia", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {

                dgvListaOrden.DataSource = DBController.listarLineaOrden(lineas[0].id);
                

            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvListaOrden.Rows[e.RowIndex].DataBoundItem;
            dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Style.ForeColor = System.Drawing.Color.Black;
            dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            if (lineaOrdenFila == null)
            {
                dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Value = '-';
                dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Value = '-';
                dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = '-';

                
                

            }
            else {
                dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Value = lineaOrdenFila.producto.nombre;
                dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Value = lineaOrdenFila.producto.idProducto;
                dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = lineaOrdenFila.cantProducto;
               

            }
            
        }


        private void dgvListaOrden_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            
            frmModCalidad formModCalidad = new frmModCalidad();
            formModCalidad.ShowDialog();
            this.Show();
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            LineaOrdenSeleccionada = (Service.lineaOrden)dgvListaOrden.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
