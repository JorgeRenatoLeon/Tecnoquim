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
            datoE.Add("Rechazado");
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
            

            if(dato == "Rechazado")
            {
                lorden.estadoCalidad = Service.estadoMaterial.Rechazado;
                lorden.estadoCalidadSpecified = true;

            }
            else if (dato == "Corregido")
            {
                int descontar = 0;
                lorden.producto.instructivo.insumos = DBController.listarLineaInsumo(lorden.producto.instructivo.id);

                foreach (Service.lineaInsumo ins in lorden.producto.instructivo.insumos)
                {
                    descontar = ins.cantInsumo;
                    Service.detalleAlmacenInsumo[] stocks = DBController.listarDetalleAlmacenInsumo(ins.insumo.nombre);
                    BindingList<Service.detalleAlmacenInsumo> listaVerificada = new BindingList<Service.detalleAlmacenInsumo>();
                    foreach (Service.detalleAlmacenInsumo deta in stocks)
                    {
                        if (deta.estado == Service.estadoMaterial.Corregido) listaVerificada.Add(deta);
                    }
                    int i = 0;
                    while (descontar > 0)
                    {
                        if (i > listaVerificada.Count()-1) break;
                        if (listaVerificada[i].stock > descontar)
                        {
                            listaVerificada[i].stock = stocks[0].stock - descontar;
                            DBController.actualizarDetalleAlmacenInsumo(stocks[i]);
                            descontar = 0;
                        }
                        else
                        {
                            listaVerificada[i].stock = 0;
                            DBController.actualizarDetalleAlmacenInsumo(stocks[i]);
                            descontar = descontar - stocks[i].stock;
                            i = i + 1;
                        }
                    }
                }

                if(descontar >0)
                {
                    MessageBox.Show("Insumos Validados Insuficientes", "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                lorden.estadoCalidad = Service.estadoMaterial.Corregido;
                lorden.estadoCalidadSpecified = true;
                Service.detalleAlmacenProducto detalleNuevo = new Service.detalleAlmacenProducto();
                detalleNuevo.almacen = new Service.almacen();
                detalleNuevo.almacen.idAlmacen = 2; //producto
                detalleNuevo.estado = Service.estadoMaterial.Bueno;
                detalleNuevo.estadoSpecified = true;
                detalleNuevo.periodo = DateTime.Now;
                detalleNuevo.periodoSpecified = true;
                detalleNuevo.producto = lorden.producto;
                detalleNuevo.stock = lorden.cantProducto;
                DBController.insertarDetalleAlmacenProducto(detalleNuevo);
               
            }
            
            DBController.actualizarLineaOrden(lorden);

            

            MessageBox.Show("Producto Verificado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtidprod.Text = "";
            txtNomProd.Text = "";
            txtPres.Text = "";
        }
    }
}
