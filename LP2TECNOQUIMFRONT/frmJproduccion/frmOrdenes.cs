﻿using System;
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

            dgvHistorialPlan.AutoGenerateColumns = false;
            dgvHistorialPlan.DataSource = DBController.listarOrdenesProduccionFecha("");
        }
        public Service.ordenProduccion OrdenSeleccionada { get => ordenSeleccionada; set => ordenSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvHistorialPlan.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado una Orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            frmGestionarOrden frmGestionarOrden = new frmGestionarOrden((Service.ordenProduccion)dgvHistorialPlan.CurrentRow.DataBoundItem);
            frmGestionarOrden.Visible = true;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cant;
            if (textBox1.Text == "")
            {
                MessageBox.Show("No se ha ingresado una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(textBox1.Text, out int canti))
            {
                cant = canti;
            }
            else
            {
                MessageBox.Show("No se ha ingresado una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvHistorialPlan.DataSource = DBController.listarOrdenesProduccionPlan(cant);
        }
        private void dgvOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.ordenProduccion OrdenFila = (Service.ordenProduccion)dgvHistorialPlan.Rows[e.RowIndex].DataBoundItem;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["FechaOrden"].Style.ForeColor = System.Drawing.Color.Black;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["Codigo"].Value = OrdenFila.id;
            dgvHistorialPlan.Rows[e.RowIndex].Cells["FechaOrden"].Value = OrdenFila.fecha.ToString("dd/MM/yy");
        }
    }
}
