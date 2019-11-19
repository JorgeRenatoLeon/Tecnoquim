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
        private Service.maquinaria maquinariaSeleccionada;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmMaquinaria(int cont = 0)
        {
            InitializeComponent();
            dgvMaquinaria.AutoGenerateColumns = false;
            maquinaria[] mqs = DBController.listarMaquinaria("");
            foreach(maquinaria item in mqs)
            {
                item.detallesMaquinaria = DBController.listarDetalleMaquinaria(item.id);
            }
            dgvMaquinaria.DataSource = mqs;
        }

        public maquinaria MaquinariaSeleccionada { get => maquinariaSeleccionada; set => maquinariaSeleccionada = value; }
               
        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.maquinaria maquinariaFila = (Service.maquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Nombre"].Value = maquinariaFila.nombre;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Value = maquinariaFila.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Tipo"].Value = maquinariaFila.tipo;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Fecha"].Value = maquinariaFila.detallesMaquinaria[0].fecha;
            if(maquinariaFila.detallesMaquinaria[0].activo == true)
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
            MaquinariaSeleccionada = (Service.maquinaria)dgvMaquinaria.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            maquinaria[] mqs = DBController.listarMaquinaria("");
            foreach (maquinaria item in mqs)
            {
                item.detallesMaquinaria = DBController.listarDetalleMaquinaria(item.id);
            }
            dgvMaquinaria.DataSource = mqs;
        }
    }
}
