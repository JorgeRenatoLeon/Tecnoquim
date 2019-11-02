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
    public partial class frmProducto : Form
    {
        Service.producto producto;
        Service.instructivo instructivo;
        Service.ServicioClient DBController = new Service.ServicioClient();
        Estado estadoObj;

        public frmProducto()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lbl
                    lblNombre.Enabled = false;
                    lblPresentacion.Enabled = false;
                    lblGranu.Enabled = false;
                    lblAct.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    lblCantidad.Enabled = false;
                    lblInsumo.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtNomProd.Enabled = false;
                    txtPres.Enabled = false;
                    txtGranu.Enabled = false;
                    txtAct.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtCant.Enabled = false;
                    dgvInsumos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Enabled = true;
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNomProd.Text = "";
            txtPres.Text = "";
            txtGranu.Text = "";
            txtAct.Text = "";
            txtIdInsumo.Text = "";
            txtCant.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            producto = new Service.producto();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto = new Service.producto();
            producto.nombre = txtNomProd.Text;
            producto.presentacion = txtPres.Text;
            producto.granularidad = float.Parse(txtGranu.Text);
            instructivo = new Service.instructivo();
            producto.instructivo = instructivo;

            if (estadoObj == Estado.Nuevo)
            {
                MessageBox.Show("Producto Registrado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBController.insertarProducto(producto);
            }
            else if (estadoObj == Estado.Modificar)
            {
                DBController.actualizarProducto(producto);
                MessageBox.Show("Producto Actualizado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmProductos formProd = new frmProductos();
            if (formProd.ShowDialog() == DialogResult.OK)
            {
                producto = formProd.ProductoSeleccionado;
                txt.Text = maquinaria.id.ToString();
                txtNombre.Text = maquinaria.nombre;
                txtTipo.Text = maquinaria.tipo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }
    }
}
