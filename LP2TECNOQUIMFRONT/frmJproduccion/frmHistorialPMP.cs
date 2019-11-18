using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmHistorialPMP : Form
    {
        Service.planMaestroProduccion pmpSeleccionado = new Service.planMaestroProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmHistorialPMP()
        {
            InitializeComponent();
            dgvHistorialPlan.AutoGenerateColumns = false;
            dgvHistorialPlan.DataSource = DBController.listarPMP("");
        }

        public Service.planMaestroProduccion PMPSeleccionado { get => pmpSeleccionado; set => pmpSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGestionarPlan frmGestionarPlan = new frmGestionarPlan((Service.planMaestroProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem);
            frmGestionarPlan.Visible = true;
            this.Close();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHistorialPlan.DataSource = DBController.listarPMP(textBox1.Text);
        }
        private void dgvHistorialPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.planMaestroProduccion pmpFila = (Service.planMaestroProduccion)dgvHistorialPlan.Rows[e.RowIndex].DataBoundItem;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Responsable"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Fecha"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Estado"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Value = pmpFila.id;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Fecha"].Value = pmpFila.periodo;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Estado"].Value = pmpFila.estado;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Responsable"].Value = pmpFila.responsable.nombres +" "+ pmpFila.responsable.apellidos;
        }
    }
}
