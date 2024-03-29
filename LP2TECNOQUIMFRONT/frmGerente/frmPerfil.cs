﻿using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmPerfil : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close = 0;
        int not = 0;
        public frmPerfil(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            InitializeComponent();
            txtNombre.Text = trabajador.nombres;
            txtApellido.Text = trabajador.apellidos;
            txtDNI.Text = trabajador.dni;
            txtCorreo.Text = trabajador.correo;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
            btnPerfil.Text = trabajador.nombres + "\n" + trabajador.apellidos;
        }

        private void frmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void lblBack_MouseClick(object sender, MouseEventArgs e)
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
            MessageBox.Show("Perfil Actualizado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGerente = new frmGerente(1, this.trabajador);
            formGerente.Visible = true;
            close = 1;
            this.Close();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmResumen formNot = new frmResumen(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

    }
}
