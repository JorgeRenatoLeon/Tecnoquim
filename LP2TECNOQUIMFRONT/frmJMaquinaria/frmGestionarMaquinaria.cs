﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmJMaquinaria
{
    public partial class frmGestionarMaquinaria : Form
    {
        private Service.maquinaria maquinariaSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmGestionarMaquinaria()
        {
            InitializeComponent();
            dgvMaquinaria.AutoGenerateColumns = false;
            dgvMaquinaria.DataSource = DBController.listarMaquinaria();
        }

        public maquinaria MaquinariaSeleccionada { get => maquinariaSeleccionada; set => maquinariaSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MaquinariaSeleccionada = (Service.maquinaria)dgvMaquinaria.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMaquinaria.DataSource = DBController.listarMaquinaria();
        }

        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.maquinaria maquinariaFila = (Service.maquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Nombre"].Value = maquinariaFila.nombre;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Value = maquinariaFila.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Tipo"].Value = maquinariaFila.tipo;
        }
    }
}