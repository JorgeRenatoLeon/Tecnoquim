using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmPMS : Form
    {
        int close = 0;
        public frmPMS()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmGestionarPlan formGestionarPlan = new frmGestionarPlan();
            formGestionarPlan.Visible = true;
        }


        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas();
            formConsultas.Visible = true;
            close = 1;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHistorialPMP form = new frmHistorialPMP();
            form.Visible = true;
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

        private void frmPMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
