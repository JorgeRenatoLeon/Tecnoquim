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
        frmListaOrden formListaOrden = new frmListaOrden();

        public frmModCalidad()
        {
            InitializeComponent();

            txtidprod.Enabled = false;
            txtNomProd.Enabled = false;
            txtPres.Enabled = false;
            datoE.Add("Bueno");
            datoE.Add("Pendiente");

            cbRol.DataSource = datoE;
            
            txtidprod.Text = formListaOrden.LineaOrdenSeleccionada.idLineaOrden.ToString();
            //txtNomProd.Text = formListaOrden.LineaOrdenSeleccionada.producto.nombre;
            txtPres.Text = formListaOrden.LineaOrdenSeleccionada.cantProducto.ToString();

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


    }
}
