using System;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmBuscarPlanMaestro : Form
    {
        private Service.planMaestroProduccion pmpSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmBuscarPlanMaestro()
        {
            InitializeComponent();
            dgvHistorialPlan.AutoGenerateColumns = false;
            dgvHistorialPlan.DataSource = DBController.listarPMP("");
        }

        public Service.planMaestroProduccion PmpSeleccionado { get => pmpSeleccionado; set => pmpSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHistorialPlan.DataSource = DBController.listarPMP(txtNombre.Text);
        }

        private void dgvHistorialPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.planMaestroProduccion pmpFila = (Service.planMaestroProduccion)dgvHistorialPlan.Rows[e.RowIndex].DataBoundItem;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Value = pmpFila.id;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Periodo"].Value = pmpFila.periodo.AddHours(5).ToString("MM/yyyy");
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Responsable"].Value = pmpFila.responsable.nombres + " " + pmpFila.responsable.apellidos;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Estado"].Value = pmpFila.estado;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            PmpSeleccionado = (Service.planMaestroProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem;
            frmRevisarPlanMaestro frmRevisarPMP = new frmRevisarPlanMaestro(PmpSeleccionado, false);
            frmRevisarPMP.Visible = true;
        }
    }
}
