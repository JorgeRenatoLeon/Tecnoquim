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
    public partial class frmPolitica : Form
    {
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmPolitica()
        {
            InitializeComponent();
            dgvPolitica.AutoGenerateColumns = false;
            dgvPolitica.DataSource = DBController.listarPoliticaStock("");
        }
        private void dgvPolitica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.politicaStock PoliticaFila = (Service.politicaStock)dgvPolitica.Rows[e.RowIndex].DataBoundItem;
            dgvPolitica.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvPolitica.Rows[e.RowIndex].Cells["Nombre"].Style.ForeColor = System.Drawing.Color.Black;
            dgvPolitica.Rows[e.RowIndex].Cells["Cantidad_Maxima"].Style.ForeColor = System.Drawing.Color.Black;
            dgvPolitica.Rows[e.RowIndex].Cells["Cantidad_Minima"].Style.ForeColor = System.Drawing.Color.Black;
            dgvPolitica.Rows[e.RowIndex].Cells["Codigo"].Value = PoliticaFila.id;
            dgvPolitica.Rows[e.RowIndex].Cells["Nombre"].Value = PoliticaFila.producto.nombre;
            dgvPolitica.Rows[e.RowIndex].Cells["Cantidad_Maxima"].Value = PoliticaFila.cantMax;
            dgvPolitica.Rows[e.RowIndex].Cells["Cantidad_Minima"].Value = PoliticaFila.cantMin;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPolitica.DataSource = DBController.listarPoliticaStock("");
        }
    }
}
