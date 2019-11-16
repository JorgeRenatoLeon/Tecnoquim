using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmGestionarPMP : Form
    {
        Service.planMaestroProduccion pmp = new Service.planMaestroProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        public frmGestionarPMP(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente frmHome = new frmGerente(1, this.trabajador);
            frmHome.Visible = true;
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

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnRevisarPMP_Click(object sender, EventArgs e)
        {
            BindingList<Service.planMaestroProduccion> pmps = new BindingList<Service.planMaestroProduccion>(DBController.listarPMP(""));
            pmp = pmps[0];
            frmRevisarPlanMaestro frmGestionarPlanM = new frmRevisarPlanMaestro(pmp);
            frmGestionarPlanM.Visible = true;
        }

        private void btnHistorialPMP_Click(object sender, EventArgs e)
        {
            frmBuscarPlanMaestro frmBuscarPMP = new frmBuscarPlanMaestro();
            frmBuscarPMP.Visible = true;
        }

        private void frmGestionarPMP_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
