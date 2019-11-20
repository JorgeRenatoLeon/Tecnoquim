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



        public frmReportes()
        {
            InitializeComponent();
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

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnGenRepI_Click(object sender, EventArgs e)
        {

            //saveFileDialog1.ShowDialog();
            //byte[] arreglo1 = DBController.generarReporteInsumosRestringidosPDF(
            //    cbMesI.SelectedIndex + 1, int.Parse(cbAnioI.SelectedValue.ToString()));
            //File.WriteAllBytes(saveFileDialog1.FileName + ".pdf", arreglo1);


        }

        private void btnGenRepP_Click(object sender, EventArgs e)
        {

        }
    }
}
