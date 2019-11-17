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
    public partial class frmModCalidadI : Form
    {

        BindingList<String> datoE = new BindingList<string>();
        public frmModCalidadI()
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
            frmListaInsumo formListaInsumo = new frmListaInsumo();
            if (formListaInsumo.ShowDialog(this) == DialogResult.OK)
            {
                //lorden = formListaInsumo.LineaOrdenSeleccionada;
                //txtidprod.Text = formListaInsumo.idLineaOrden.ToString();
                //txtNomProd.Text = formListaInsumo.LineaOrdenSeleccionada.producto.nombre;
                //txtPres.Text = formListaInsumo.cantProducto.ToString();
            }

        }
    }
}
