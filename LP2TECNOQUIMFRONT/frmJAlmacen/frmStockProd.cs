using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmStockProd : Form
    {
        Service.producto producto;
        Service.detalleAlmacenProducto almacenP;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStockProd()
        {
            InitializeComponent();
            BindingList<Service.almacen> almacens = new BindingList<Service.almacen>(DBController.listarAlmacen(""));
            cbAlmacen.DataSource = almacens;
            cbAlmacen.DisplayMember = "Tipo";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            almacenP = new Service.detalleAlmacenProducto();
            producto = new Service.producto();
            producto.idProducto = int.Parse(txtidprod.Text);

            almacenP.producto = producto;
            almacenP.nLote= int.Parse(txtLote.Text);
            almacenP.stock = int.Parse(txtAct.Text);

            DBController.actualizarDetalleAlmacenProducto(almacenP);
            MessageBox.Show("Se actualizo el stock Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmStocksP formProd = new frmStocksP();
            if (formProd.ShowDialog() == DialogResult.OK)
            {
                almacenP = formProd.ProductoSeleccionado;
                txtidprod.Text = almacenP.producto.idProducto.ToString();
                txtNomProd.Text = almacenP.producto.nombre;
                txtPres.Text = almacenP.producto.presentacion;
                txtLote.Text = almacenP.nLote.ToString();
                txtAct.Text = almacenP.stock.ToString();
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
