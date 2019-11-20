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
    public partial class frmConsultas : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        public frmConsultas(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmInstructivo formInstructivo = new frmInstructivo();
            formInstructivo.ShowDialog(this);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmControlCalidad formControlCalidad = new frmControlCalidad(1, this.trabajador);
            formControlCalidad.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReportes formReportes = new frmReportes();
            formReportes.Visible = true;
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
    }
}
