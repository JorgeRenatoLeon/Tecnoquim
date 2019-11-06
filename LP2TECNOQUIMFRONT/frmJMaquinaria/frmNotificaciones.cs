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
    public partial class frmNotificaciones : Form
    {
        int close = 0;
        public frmNotificaciones()
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

        private void frmNotificaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formNot = new frmPerfil();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
