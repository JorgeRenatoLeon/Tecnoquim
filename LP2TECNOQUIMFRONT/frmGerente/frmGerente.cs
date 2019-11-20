using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmGerente : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;
        int not = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmGerente(int cont = 0, Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if(mensajes !=null)
            {
                not = mensajes.Length;
            }
            if (cont == 1)
            {
                InitializeComponent();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
            else if (cont == 2)
            {
                this.Visible = false;
                frmGestionarPMP frmGestionarPlanM = new frmGestionarPMP(trabajador,1);
                frmGestionarPlanM.Visible = true;
                close = 1;
                this.Close();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(1250);

                InitializeComponent();

                MessageBox.Show("Bienvenido/a " + trabajador.nombres + " " + trabajador.apellidos);

                t.Abort();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void frmGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
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

        private void btnPMS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGestionarPMP frmGestionarPlanM = new frmGestionarPMP(trabajador);
            frmGestionarPlanM.Visible = true;
            close = 1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionarEmpleado frmGestionarEmpleado = new frmGestionarEmpleado();
            frmGestionarEmpleado.Visible = true;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmResumen formRes = new frmResumen(this.trabajador);
            formRes.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
