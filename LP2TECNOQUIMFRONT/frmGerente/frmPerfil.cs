using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
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

        private void frmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGerente = new frmGerente(1,this.trabajador);
            formGerente.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void lblBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            frmLogin formNot = new frmLogin();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
