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
    public partial class frmListaOrden : Form
    {

        
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.ordenProduccion[] lineas;
        public frmListaOrden()
        {
            InitializeComponent();
            lineas =DBController.listarOrdenesProduccionFecha(DateTime.Now.ToString("yyyy-MM-dd"));
            
            if (lineas[0].lineasOrden == null)
            {
                MessageBox.Show("No hay Ordenes pendientes por hoy", "Advertencia", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                
                dgvListaOrden.DataSource = lineas[0].lineasOrden;
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

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvListaOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            frmModCalidad formModCalidad = new frmModCalidad();
            formModCalidad.ShowDialog();
            this.Show();



        }
    }
}
