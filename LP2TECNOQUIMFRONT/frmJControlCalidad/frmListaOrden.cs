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
        int count = 0;

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
                Service.lineaOrden[] lineasGen = DBController.listarLineaOrden(lineas[0].id);
                count = lineasGen.Count();
                BindingList<Service.lineaOrden> lineasVisualizar = new BindingList<lineaOrden>();
                foreach (lineaOrden l in lineasGen)
                {
                    if(l.estadoCalidad == estadoMaterial.Pendiente)
                    {
                        lineasVisualizar.Add(l);
                    }
                }
                count = lineasVisualizar.Count();
                dgvListaOrden.DataSource = lineasVisualizar;
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvListaOrden.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado un Lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LineaOrdenSeleccionada = (Service.lineaOrden)dgvListaOrden.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvListaOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvListaOrden.Rows[e.RowIndex].DataBoundItem;
            dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Style.ForeColor = System.Drawing.Color.Black;
            dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvListaOrden.Rows[e.RowIndex].Cells["Estado"].Style.ForeColor = System.Drawing.Color.Black;
            if (lineaOrdenFila == null && count == 0)
            {
                dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Value = '-';
                dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Value = '-';
                dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = '-';
                dgvListaOrden.Rows[e.RowIndex].Cells["Estado"].Value = '-';
            }
            else
            {
                dgvListaOrden.Rows[e.RowIndex].Cells["Producto"].Value = lineaOrdenFila.producto.nombre;
                dgvListaOrden.Rows[e.RowIndex].Cells["Codigo"].Value = lineaOrdenFila.producto.idProducto;
                dgvListaOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = lineaOrdenFila.cantProducto;
                dgvListaOrden.Rows[e.RowIndex].Cells["Estado"].Value = lineaOrdenFila.estadoCalidad;
            }
        }

        private void dgvListaOrden_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;

            frmModCalidad formModCalidad = new frmModCalidad();
            formModCalidad.ShowDialog();
            this.Show();

        }
    }
}
