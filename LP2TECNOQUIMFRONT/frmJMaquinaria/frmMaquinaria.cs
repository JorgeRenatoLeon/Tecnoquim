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

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmMaquinaria : Form
    {
        private Service.detalleMaquinaria detalleMaquinariaSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmMaquinaria(int cont = 0)
        {
            InitializeComponent();
            dgvMaquinaria.AutoGenerateColumns = false;
            if (cont != 0)
            {
                dgvMaquinaria.DataSource = DBController.listarDetalleMaquinaria(cont);
            }
            else
            {
                dgvMaquinaria.DataSource = DBController.listarDetalleMaquinariaTodos("");
            }
        }

        public detalleMaquinaria DetalleMaquinariaSeleccionada { get => detalleMaquinariaSeleccionada; set => detalleMaquinariaSeleccionada = value; }
               

        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleMaquinaria maquinariaFila = (Service.detalleMaquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Nombre"].Value = maquinariaFila.maquinaria.nombre;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Value = maquinariaFila.maquinaria.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Tipo"].Value = maquinariaFila.maquinaria.tipo;
            if(maquinariaFila.activo == true)
            {
                dgvMaquinaria.Rows[e.RowIndex].Cells["Estado"].Value = "ACTIVO";
            }
            else
            {
                dgvMaquinaria.Rows[e.RowIndex].Cells["Estado"].Value = "INACTIVO";
            }
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            DetalleMaquinariaSeleccionada = (Service.detalleMaquinaria)dgvMaquinaria.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMaquinaria.DataSource = DBController.listarDetalleMaquinariaTodos(txtNombre.Text);
        }
    }
}
