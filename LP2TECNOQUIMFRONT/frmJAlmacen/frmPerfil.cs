using LP2TECNOQUIMFRONT.frmPrincipal;
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
    public partial class frmPerfil : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close = 0;
        public frmPerfil(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            InitializeComponent();
            txtNombre.Text = trabajador.nombres;
            txtApellido.Text = trabajador.apellidos;
            txtDNI.Text = trabajador.dni;
            txtCorreo.Text = trabajador.correo;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlmacen formInicio = new frmAlmacen(1, this.trabajador);
            formInicio.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmLogin formNot = new frmLogin();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            trabajador.dni = txtDNI.Text;
            trabajador.nombres = txtNombre.Text;
            trabajador.apellidos = txtApellido.Text;
            trabajador.correo = txtCorreo.Text;
            DBController.actualizarTrabajador(trabajador);
            MessageBox.Show("Correo cambiado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
