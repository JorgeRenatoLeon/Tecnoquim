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
    public partial class frmNotificaciones : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close = 0;
        int not = 0;
        public frmNotificaciones(Service.trabajador trabajadors = null)
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
            btnPerfil.Text = trabajador.nombres + "\n" + trabajador.apellidos;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1,this.trabajador);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            btnReporte formPerfil = new btnReporte(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas(this.trabajador);
            formConsultas.Visible = true;
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
            dgvNotificaciones.Rows[e.RowIndex].Cells["ID"].Value = ppFila.idMensaje;
            dgvNotificaciones.Rows[e.RowIndex].Cells["NombreEmisor"].Value = ppFila.emisor.nombres + " " + ppFila.emisor.apellidos;
            dgvNotificaciones.Rows[e.RowIndex].Cells["RolEmisor"].Value = ppFila.emisor.rol.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Descripcion"].Value = ppFila.descripcion;
            dgvNotificaciones.Rows[e.RowIndex].Cells["Fecha"].Value = ppFila.fechaEnvio;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InsumosRestringidos formInsR = new InsumosRestringidos(this.trabajador);
            formInsR.Visible = true;
            close = 1;
            this.Close();
        }

        private void dgvNotificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dgvNotificaciones.Rows[dgvNotificaciones.SelectedRows[0].Index].Cells[3].Value.ToString();
            int length = str.IndexOf(".");
            string sub = str.Substring(0, length);

            if (sub == "PLAN MAESTRO RECHAZADO")
            {
                DBController.leerMensaje(int.Parse(dgvNotificaciones.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                this.Visible = false;
                frmPMS formPMS = new frmPMS(this.trabajador,1);
                formPMS.Visible = true;
                close = 1;
                this.Close();
            }
        }
    }
}
