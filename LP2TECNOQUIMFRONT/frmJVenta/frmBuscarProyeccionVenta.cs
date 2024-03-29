﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmBuscarProyeccionVenta : Form
    {
        private Service.proyeccionVenta proyeccionSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBuscarProyeccionVenta()
        {
            InitializeComponent();
            dgvProyeccion.AutoGenerateColumns = false;
            dgvProyeccion.DataSource = DBController.listarProyeccionVenta("");
        }

        public Service.proyeccionVenta ProyeccionSeleccionada { get => proyeccionSeleccionada; set => proyeccionSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProyeccion.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado una Proyección de Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProyeccionSeleccionada = (Service.proyeccionVenta)dgvProyeccion.CurrentRow.DataBoundItem;
            frmGestionarProyeccionVenta frmPv = new frmGestionarProyeccionVenta(ProyeccionSeleccionada, false);
            frmPv.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProyeccion.DataSource = DBController.listarProyeccionVenta(textBox1.Text);
        }

        private void dgvProyeccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.proyeccionVenta proyFila = (Service.proyeccionVenta)dgvProyeccion.Rows[e.RowIndex].DataBoundItem;
            dgvProyeccion.Rows[e.RowIndex].Cells["Codigo"].Value = proyFila.id;
            dgvProyeccion.Rows[e.RowIndex].Cells["Periodo"].Value = proyFila.periodo.AddHours(5).ToString("MM/yyyy");
        }
    }
}
