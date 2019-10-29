using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmPerfil : Form
    {
        int close = 0;
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGerente = new frmGerente(1);
            formGerente.Visible = true;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }
    }
}
