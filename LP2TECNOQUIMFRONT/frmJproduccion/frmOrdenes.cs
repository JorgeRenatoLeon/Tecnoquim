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
    public partial class frmOrdenes : Form
    {
        Service.ordenProduccion ordenSeleccionada = new Service.ordenProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmOrdenes()
        {
            InitializeComponent();
            dgvHistorialPlan.DataSource = DBController.listarOrdenesProduccionPlan(0);
        }
        public Service.ordenProduccion OrdenSeleccionada { get => ordenSeleccionada; set => ordenSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OrdenSeleccionada = (Service.ordenProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHistorialPlan.DataSource = DBController.listarOrdenesProduccionPlan(Int32.Parse(textBox1.Text));
        }
    }
}
