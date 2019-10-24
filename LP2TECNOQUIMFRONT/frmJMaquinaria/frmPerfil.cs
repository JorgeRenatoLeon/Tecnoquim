using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJMaquinaria
{
    public partial class frmPerfil : Form
    {
        int close = 0;
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJMaquinaria formGerente = new frmJMaquinaria(1);
            formGerente.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
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
