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
    public partial class frmModCalidad : Form
    {
        BindingList<String> datoE = new BindingList<string>();
        Service.ServicioClient DBController = new Service.ServicioClient();
        //frmListaOrden formListaOrden = new frmListaOrden();
        Service.lineaOrden lorden;

        public frmModCalidad()
        {
            InitializeComponent();

            txtidprod.Enabled = false;
            txtNomProd.Enabled = false;
            txtPres.Enabled = false;
            datoE.Add("Bueno");
            datoE.Add("Pendiente");

            cbRol.DataSource = datoE;
                      
                

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmListaOrden formListaOrden = new frmListaOrden();
            if (formListaOrden.ShowDialog(this) == DialogResult.OK)
            {
                lorden = formListaOrden.LineaOrdenSeleccionada;
                txtidprod.Text = lorden.idLineaOrden.ToString();
                txtNomProd.Text = formListaOrden.LineaOrdenSeleccionada.producto.nombre;
                txtPres.Text = lorden.cantProducto.ToString();
            }

        }
    }
}
