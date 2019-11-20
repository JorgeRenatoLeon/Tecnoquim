using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{


    public partial class frmReportes : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close;
        int not = 0;

        public frmReportes(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            InitializeComponent();
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            byte[] arreglo1 = DBController.generarReporteInsumosCalidadPDF();
            if (arreglo1 == null)
            {
                MessageBox.Show("Ups, problema con el server", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.WriteAllBytes(saveFileDialog1.FileName + ".pdf", arreglo1);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            byte[] arreglo1 = DBController.generarReporteProductosCalidadPDF();
            if (arreglo1 == null)
            {
                MessageBox.Show("Ups, problema con el server", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.WriteAllBytes(saveFileDialog1.FileName + ".pdf", arreglo1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmControlCalidad formControlCalidad = new frmControlCalidad(1, this.trabajador);
            formControlCalidad.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas(this.trabajador);
            formConsultas.Visible = true;
            close = 1;
            this.Close();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmControlCalidad formControlCalidad = new frmControlCalidad(1, this.trabajador);
            formControlCalidad.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();

        }
    }
}
