using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmGestionPoliticaStock : Form
    {
        Service.politicaStock politicaStock;
        Service.producto productoSeleccionado;
        Service.ServicioClient DBController =  new Service.ServicioClient();
        public frmGestionPoliticaStock()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Seleccione un producto.");
            }
            else if (txtMin.Text == "")
            {
                MessageBox.Show("Inserte una cantidad minima de stock.");
            } else if (txtMax.Text == "")
            {
                MessageBox.Show("Inserte una cantidad maxima de stock.");
            } else
            {
                politicaStock = new Service.politicaStock();
                politicaStock.producto = productoSeleccionado;
                try
                {
                    politicaStock.cantMin = Int32.Parse(txtMin.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("La cantidad minima debe ser un numero entero.");
                    return;
                }
                try
                {
                    politicaStock.cantMax = Int32.Parse(txtMax.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("La cantidad maxima debe ser un numero entero.");
                    return;
                }

                if (politicaStock.cantMin > politicaStock.cantMax)
                {
                    MessageBox.Show("La cantidad minima no puede ser mayor que la maxima.");
                    return;
                }

                Service.politicaStock[] politicaPrevia = DBController.listarPoliticaStock(productoSeleccionado.nombre);
                if (politicaPrevia == null)
                    DBController.insertarPoliticaStock(politicaStock);
                else
                {
                    politicaStock.id = politicaPrevia[0].id;
                    DBController.actualizarPoliticaStock(politicaStock);
                }

                MessageBox.Show("Politica de Stock del producto " + productoSeleccionado.nombre + " registrada correctamente");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmProducto formProducto = new frmProducto();
            if (formProducto.ShowDialog(this) == DialogResult.OK)
            {
                this.productoSeleccionado = formProducto.ProductoSeleccionado;
                txtProducto.Text = this.productoSeleccionado.nombre;
            }
        }
    }
}
