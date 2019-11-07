using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmNotificaciones : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close = 0;
        public frmNotificaciones(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            InitializeComponent();
            dgvNotificaciones.AutoGenerateColumns = false;
            dgvNotificaciones.DataSource = DBController.listarMensaje(trabajador.id);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlmacen formInicio = new frmAlmacen(1, this.trabajador);
            formInicio.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmNotificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void dgvNotificaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.mensaje ppFila = (Service.mensaje)dgvNotificaciones.Rows[e.RowIndex].DataBoundItem;
            dgvNotificaciones.Rows[e.RowIndex].Cells["NombreEmisor"].Value = ppFila.emisor.nombres + " " + ppFila.emisor.apellidos;
            dgvNotificaciones.Rows[e.RowIndex].Cells["RolEmisor"].Value = ppFila.emisor.rol.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Descripcion"].Value = ppFila.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Fecha"].Value = ppFila.fechaEnvio;
        }
    }
}
