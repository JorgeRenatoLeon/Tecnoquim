using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmBuscarEmpleado : Form
    {
        private Service.trabajador trabajadorSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBuscarEmpleado()
        {
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.DataSource = DBController.listarTrabajadores("");
        }

        public trabajador TrabajadorSeleccionado { get => trabajadorSeleccionado; set => trabajadorSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            TrabajadorSeleccionado = (Service.trabajador)dgvEmpleados.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = DBController.listarTrabajadores(txtNombre.Text);
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.trabajador empFila = (Service.trabajador)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
            dgvEmpleados.Rows[e.RowIndex].Cells["DNI"].Value = empFila.dni;
            dgvEmpleados.Rows[e.RowIndex].Cells["NombreCompleto"].Value = empFila.nombres + " " + empFila.apellidos;
            dgvEmpleados.Rows[e.RowIndex].Cells["Rol"].Value = empFila.rol.descripcion;
        }
    }
}
