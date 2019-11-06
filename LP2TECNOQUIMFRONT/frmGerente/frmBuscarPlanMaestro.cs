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
            //DateTime oDate = Convert.ToDateTime("");
            //dgvHistorialPlan.DataSource = DBController.listarPMP(oDate);
        }

        public planMaestroProduccion PmpSeleccionado { get => pmpSeleccionado; set => pmpSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PmpSeleccionado = (Service.planMaestroProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //DateTime oDate = Convert.ToDateTime(txtNombre.Text);
            //dgvHistorialPlan.DataSource = DBController.listarPMP(oDate);
        }

        private void dgvHistorialPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.planMaestroProduccion pmpFila = (Service.planMaestroProduccion)dgvHistorialPlan.Rows[e.RowIndex].DataBoundItem;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Value = pmpFila.id;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Periodo"].Value = pmpFila.periodo;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Responsable"].Value = pmpFila.responsable.nombres + " " + pmpFila.responsable.apellidos;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Estado"].Value = pmpFila.estado;
        }
    }
}
