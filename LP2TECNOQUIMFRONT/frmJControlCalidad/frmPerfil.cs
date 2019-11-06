using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmPerfil : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
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
            frmControlCalidad formInicio = new frmControlCalidad(1,this.trabajador);
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
    }
}
