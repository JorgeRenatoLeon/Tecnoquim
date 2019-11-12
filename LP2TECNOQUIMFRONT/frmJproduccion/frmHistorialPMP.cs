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
            dgvHistorialPlan.DataSource = DBController.listarPMP("%");
        }

        public Service.planMaestroProduccion PMPSeleccionado { get => pmpSeleccionado; set => pmpSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PMPSeleccionado = (Service.planMaestroProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHistorialPlan.DataSource = DBController.listarMaquinaria(textBox1.Text);
        }
    }
}
