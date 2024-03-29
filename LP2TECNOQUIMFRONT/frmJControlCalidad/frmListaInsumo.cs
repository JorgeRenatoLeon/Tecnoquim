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

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmListaInsumo : Form
    {
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.detalleAlmacenInsumo detalleSeleccionada = new Service.detalleAlmacenInsumo();

        public detalleAlmacenInsumo DetalleSeleccionada { get => detalleSeleccionada; set => detalleSeleccionada = value; }

        //Service.ordenProduccion[] lineas;


        public frmListaInsumo()
        {
            InitializeComponent();
            dgvListaOrden.AutoGenerateColumns = false;
            dgvListaOrden.ReadOnly = true;

            Service.detalleAlmacenInsumo[] lineasGen = DBController.listarDetalleAlmacenInsumo("");

            BindingList<Service.detalleAlmacenInsumo> lineasVisualizar = new BindingList<detalleAlmacenInsumo>();
            foreach (detalleAlmacenInsumo l in lineasGen)
            {
                if (l.estado == estadoMaterial.Pendiente)
                {
                    lineasVisualizar.Add(l);
                }
            }


            dgvListaOrden.DataSource= lineasVisualizar;
            //dgvListaOrden.DataSource = DBController.listarDetalleAlmacenInsumo("");
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvListaOrden.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado un Lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DetalleSeleccionada = (Service.detalleAlmacenInsumo)dgvListaOrden.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvListaOrden_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleAlmacenInsumo detFila = (Service.detalleAlmacenInsumo)dgvListaOrden.Rows[e.RowIndex].DataBoundItem;
            dgvListaOrden.Rows[e.RowIndex].Cells["Insumo"].Value = detFila.insumo.nombre;
            dgvListaOrden.Rows[e.RowIndex].Cells["Lote"].Value = detFila.nLote;
            dgvListaOrden.Rows[e.RowIndex].Cells["Periodo"].Value = detFila.periodo;
            dgvListaOrden.Rows[e.RowIndex].Cells["Stock"].Value = detFila.stock;
            dgvListaOrden.Rows[e.RowIndex].Cells["Estado"].Value = detFila.estado;

        }
    }
}
