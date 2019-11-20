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
    public partial class frmResumen : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close=0;
        int not = 0;

        public frmResumen(Service.trabajador trabajadors = null)
        {
            InitializeComponent();
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
            BindingList<String> meses;
            meses = new BindingList<String>();
            meses.Add("Enero");
            meses.Add("Febrero");
            meses.Add("Marzo");
            meses.Add("Abril");
            meses.Add("Mayo");
            meses.Add("Junio");
            meses.Add("Julio");
            meses.Add("Agosto");
            meses.Add("Setiembre");
            meses.Add("Octubre");
            meses.Add("Noviembre");
            meses.Add("Diciembre");
            cbMesI.DataSource = meses;

            BindingList<String> anios;
            anios = new BindingList<String>();
            anios.Add("2018");
            anios.Add("2019");
            anios.Add("2020");
            cbAnioI.DataSource = anios;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formHome = new frmGerente(1, this.trabajador);
            formHome.Visible = true;
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

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnGenRepI_Click(object sender, EventArgs e)
        {

        }
    }
}
