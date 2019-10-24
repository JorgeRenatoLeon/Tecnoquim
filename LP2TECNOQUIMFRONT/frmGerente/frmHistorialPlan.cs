using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmHistorialPlan : Form
    {
        int close = 0;
        public frmHistorialPlan()
        {
            InitializeComponent();
            dgvHistorialPlan.AutoGenerateColumns = false;;
        } 

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbMaximize_Click_1(object sender, EventArgs e)
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

        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGerente = new frmGerente(1);
            formGerente.Visible = true;
            close = 1;
            this.Close();
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

        private void frmHistorialPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
