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
    public partial class frmGestionarProducto : Form
    {
        int flag = 0;
        Service.producto producto;
        Service.lineaInsumo linea;
        Service.insumo insumo;
        Service.instructivo instructivo;
        BindingList<Service.lineaInsumo> lineas;
        Service.ServicioClient DBController = new Service.ServicioClient();
        Estado estadoObj;

        public frmGestionarProducto()
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
                    lblidProd.Enabled = false;
                    lblIdInstructivo.Enabled = false;
                    lblNombre.Enabled = false;
                    lblPresentacion.Enabled = false;
                    lblGranu.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtNomProd.Enabled = false;
                    txtidinst.Enabled = false;
                    txtPres.Enabled = false;
                    txtGranu.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblidProd.Enabled = true;
                    lblIdInstructivo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
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
                    lblidProd.Enabled = true;
                    lblIdInstructivo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtidprod.Text = "";
            txtNomProd.Text = "";
            txtPres.Text = "";
            txtidinst.Text = "";
            txtGranu.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            producto = new Service.producto();
            instructivo = new Service.instructivo();
            lineas = new BindingList<Service.lineaInsumo>();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto = new Service.producto();
            producto.nombre = txtNomProd.Text;
            producto.presentacion = txtPres.Text;
            producto.granularidad = float.Parse(txtGranu.Text);

            instructivo = new Service.instructivo();
            //instructivo.actividades = txtAct.Text;
            instructivo.insumos = lineas.ToArray();
            producto.instructivo = instructivo;
            if (flag == 1)
            {
                producto.restriccion = true;
            }
            else
            {
                producto.restriccion = false;
            }
            if (estadoObj == Estado.Nuevo)
            {

                DBController.insertarProducto(producto);
                Service.producto auxProd = new Service.producto();
                DBController.insertarInstructivo(instructivo, producto.idProducto);
                //int idInstru = DBController.buscarIdInstru(instructivo);
                foreach (Service.lineaInsumo l in lineas)
                {
                    DBController.insertarLineaInsumo(l, instructivo.id);
                }
                MessageBox.Show("Producto Registrado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (estadoObj == Estado.Modificar)
            {
                producto.idProducto = int.Parse(txtidprod.Text);
                DBController.actualizarProducto(producto);
                MessageBox.Show("Producto Actualizado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmProductos formProd = new frmProductos();
            if (formProd.ShowDialog() == DialogResult.OK)
            {
                producto = formProd.ProductoSeleccionado;
                txtidprod.Text = producto.idProducto.ToString();
                txtNomProd.Text = producto.nombre;
                txtPres.Text = producto.presentacion;
                txtGranu.Text = producto.granularidad.ToString();
                txtidinst.Text = producto.instructivo.id.ToString();
            }
            estadoObj = Estado.Buscar;
            estadoComponentes(Estado.Buscar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBController.eliminarProducto(int.Parse(txtidprod.Text));
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(Estado.Inicial);
            MessageBox.Show("Producto Eliminado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmInstructivo form = new frmInstructivo();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //producto = form.ProductoSeleccionado;
                //txtidprod.Text = producto.idProducto.ToString();
                //txtNomProd.Text = producto.nombre;
                //txtPres.Text = producto.presentacion;
                //txtGranu.Text = producto.granularidad.ToString();
                //txtidinst.Text = producto.instructivo.id.ToString();
            }
            estadoObj = Estado.Buscar;
            estadoComponentes(Estado.Buscar);
        }
    }
}
