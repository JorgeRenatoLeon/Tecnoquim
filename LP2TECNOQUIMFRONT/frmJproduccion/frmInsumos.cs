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
    public partial class frmInsumos : Form
    {
        private Service.insumo insumoSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmInsumos()
        {
            InitializeComponent();
            dgvInsumo.AutoGenerateColumns = false;
            //dgvInsumo.DataSource = DBController.listarInsumo();
        }

        public insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1);
            fromJProd.Visible = true;
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {        
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas();
            formConsultas.Visible = true;
            this.Close();
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvInsumo.DataSource = DBController.listarInsumo();
        }

        private void dgvInsumo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.insumo insumoFila = (Service.insumo)dgvInsumo.Rows[e.RowIndex].DataBoundItem;
            dgvInsumo.Rows[e.RowIndex].Cells["Nombre"].Value = insumoFila.nombre;
            dgvInsumo.Rows[e.RowIndex].Cells["Granularidad"].Value = insumoFila.granularidad.ToString();
            dgvInsumo.Rows[e.RowIndex].Cells["Color"].Value = insumoFila.color;
            dgvInsumo.Rows[e.RowIndex].Cells["Cantidad"].Value = insumoFila.cantidad;
            dgvInsumo.Rows[e.RowIndex].Cells["Unidad"].Value = insumoFila.unidad;

        }
    }
}
