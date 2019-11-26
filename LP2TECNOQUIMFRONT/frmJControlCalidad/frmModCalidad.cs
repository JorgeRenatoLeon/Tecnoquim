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
            datoE.Add("Corregido");
            cbRol.DataSource = datoE;

            txtidprod.Enabled = false;
            txtNomProd.Enabled = false;
            txtPres.Enabled = false;
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if(txtidprod.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dato = cbRol.SelectedValue.ToString();
            

            if(dato == "Bueno")
            {
                lorden.estadoCalidad = Service.estadoMaterial.Bueno;
                //lorden.estadoCalidadSpecified = true;

            }
            else if (dato == "Pendiente")
            {
                lorden.estadoCalidad = Service.estadoMaterial.Corregido;
                //lorden.estadoCalidadSpecified = true;
            }
            else if (dato == "Corregido")
            {
                lorden.estadoCalidad = Service.estadoMaterial.Pendiente;
                //lorden.estadoCalidadSpecified = true;
            }
            lorden.estadoCalidadSpecified = true;
            DBController.actualizarLineaOrden(lorden);

            if(dato=="Bueno")
            {
                //Service.detalleAlmacenProducto detalleNuevo = new Service.detalleAlmacenProducto();
                //detalleNuevo.almacen.idAlmacen = 2; //producto
                //detalleNuevo.estado = Service.estadoMaterial.Bueno;
                //detalleNuevo.estadoSpecified = true;
                //detalleNuevo.periodo = DateTime.Now;
                //detalleNuevo.periodoSpecified = true;
                //detalleNuevo.producto = lorden.producto;
                //detalleNuevo.stock = lorden.cantProducto;
                //DBController.actualizarDetalleAlmacenProducto(detalleNuevo);
            }



            MessageBox.Show("Producto Verificado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtidprod.Text = "";
            txtNomProd.Text = "";
            txtPres.Text = "";
        }
    }
}
