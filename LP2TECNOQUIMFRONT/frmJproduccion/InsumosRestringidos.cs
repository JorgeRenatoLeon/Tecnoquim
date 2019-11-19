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

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class InsumosRestringidos : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        int close;
        public InsumosRestringidos(Service.trabajador trabajadors = null)
        {
            InitializeComponent();
            this.trabajador = trabajadors;
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
            BindingList<String> mesesP;
            mesesP = new BindingList<String>();
            mesesP.Add("Enero");
            mesesP.Add("Febrero");
            mesesP.Add("Marzo");
            mesesP.Add("Abril");
            mesesP.Add("Mayo");
            mesesP.Add("Junio");
            mesesP.Add("Julio");
            mesesP.Add("Agosto");
            mesesP.Add("Setiembre");
            mesesP.Add("Octubre");
            mesesP.Add("Noviembre");
            mesesP.Add("Diciembre");
            cbMesP.DataSource = mesesP;

            BindingList<String> anios;
            anios = new BindingList<String>();
            anios.Add("2018");
            anios.Add("2019");
            anios.Add("2020");
            cbAnioI.DataSource = anios;
            BindingList<String> aniosP;
            aniosP = new BindingList<String>();
            aniosP.Add("2018");
            aniosP.Add("2019");
            aniosP.Add("2020");
            cbAnioP.DataSource = aniosP;
        }

        private void btnGenRepI_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            byte[] arreglo1 = DBController.generarReporteInsumosRestringidosPDF(
                cbMesI.SelectedIndex+1, int.Parse(cbAnioI.SelectedValue.ToString()));
            File.WriteAllBytes(saveFileDialog1.FileName+ ".pdf", arreglo1);
        }

        private void btnGenRepP_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
            byte[] arreglo = DBController.generarReporteProductosRestringidosPDF(
                cbMesP.SelectedIndex+1, int.Parse(cbAnioP.SelectedValue.ToString()));
            File.WriteAllBytes(saveFileDialog2.FileName+ ".pdf", arreglo);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas formConsultas = new frmConsultas(this.trabajador);
            formConsultas.Visible = true;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1, this.trabajador);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
