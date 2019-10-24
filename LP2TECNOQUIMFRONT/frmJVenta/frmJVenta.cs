using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmJVenta : Form
    {
        int close = 0;
        public frmJVenta(int cont=0, string usuario = "")
        {
            if (cont != 0)
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(2500);

                InitializeComponent();

                MessageBox.Show("Bienvenido " + usuario);

                t.Abort();
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmJVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarProyeccionVenta formRegistro = new frmRegistrarProyeccionVenta();
            formRegistro.Visible = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmRegistrarProyeccionVenta formRegistro = new frmRegistrarProyeccionVenta();
            formRegistro.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvHistorialPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
