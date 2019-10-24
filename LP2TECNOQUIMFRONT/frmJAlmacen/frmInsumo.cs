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
    public partial class frmInsumo : Form
    {
        int close = 0;
        public frmInsumo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlmacen formInicio = new frmAlmacen(1);
            formInicio.Visible = true;
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

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
