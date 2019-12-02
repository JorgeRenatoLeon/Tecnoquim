using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmRegistrarMovimiento : Form
    {
        Service.levelUpMove movimiento;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmRegistrarMovimiento()
        {
            InitializeComponent();
            cboKind.DataSource = DBController.listarTodasCategorias();
            cboRange.DataSource = DBController.listarTodosRangos();
            cboTipo.DataSource = DBController.listarTodosTipos();
            cboKind.DisplayMember = "movementKind";
            cboRange.DisplayMember = "movementRange";
            cboTipo.DisplayMember = "name";
        }

        public Service.levelUpMove MovimientoSeleccionado { get => movimiento; set => movimiento = value; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            movimiento = new Service.levelUpMove();
            movimiento.levelOfLearning = int.Parse(txtLevel.Text);
            movimiento.moveName = txtName.Text;
            movimiento.type = (Service.type)cboTipo.SelectedValue;
            movimiento.kind = (Service.kind)cboKind.SelectedValue;
            movimiento.power = int.Parse(txtPoder.Text);
            movimiento.accuracy = int.Parse(txtPrecision.Text);
            movimiento.powerPoint = int.Parse(txtPuntosPoder.Text);
            movimiento.range = (Service.range)cboRange.SelectedValue;

            MovimientoSeleccionado = movimiento;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
