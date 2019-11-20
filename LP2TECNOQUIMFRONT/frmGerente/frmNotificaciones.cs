using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmNotificaciones : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close = 0;
        int not = 0;
        public frmNotificaciones(Service.trabajador trabajadors=null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            InitializeComponent();
            dgvNotificaciones.AutoGenerateColumns = false;
            dgvNotificaciones.DataSource = mensajes;
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
        }

        private void frmNotificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formHome = new frmGerente(1,this.trabajador);
            formHome.Visible = true;
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

        private void dgvNotificaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.mensaje ppFila = (Service.mensaje)dgvNotificaciones.Rows[e.RowIndex].DataBoundItem;
            dgvNotificaciones.Rows[e.RowIndex].Cells["ID"].Value = ppFila.idMensaje.ToString();
            dgvNotificaciones.Rows[e.RowIndex].Cells["NombreEmisor"].Value = ppFila.emisor.nombres+" "+ppFila.emisor.apellidos;
            dgvNotificaciones.Rows[e.RowIndex].Cells["RolEmisor"].Value = ppFila.emisor.rol.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Descripcion"].Value = ppFila.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Fecha"].Value = ppFila.fechaEnvio;
        }

        private void dgvNotificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dgvNotificaciones.Rows[dgvNotificaciones.SelectedRows[0].Index].Cells[3].Value.ToString();
            
            if (str == "VALIDAR PMP")
            {
                DBController.leerMensaje(int.Parse(dgvNotificaciones.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                this.Visible = false;
                frmGerente formHome = new frmGerente(2, this.trabajador);
                close = 1;
                this.Close();
            }

        }
    }
}
