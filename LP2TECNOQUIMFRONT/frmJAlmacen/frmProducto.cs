using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{   
    public partial class frmProducto : Form
    {
        int flag=0;
        Service.producto producto;
        Service.lineaInsumo linea;
        Service.insumo insumo;
        Service.instructivo instructivo;
        BindingList<Service.lineaInsumo> lineas;
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
                    lblidProd.Enabled = false;
                    lblIdInstructivo.Enabled = false;
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
                    txtidinst.Enabled = false;
                    txtPres.Enabled = false;
                    txtGranu.Enabled = false;
                    txtAct.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtNomInsumo.Enabled = false;
                    txtCant.Enabled = false;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblidProd.Enabled = true;
                    lblIdInstructivo.Enabled = true;
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
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtNomInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
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
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtNomInsumo.Enabled = true;
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
            txtNomInsumo.Text = "";
            dgvInsumos.Rows.Clear();
            dgvInsumos.Refresh();
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
            instructivo.actividades = txtAct.Text;
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
                int idProd= DBController.insertarProducto(producto);
                int idInstru= DBController.insertarInstructivo(instructivo,idProd);
                foreach (Service.lineaInsumo l in lineas)
                {
                    DBController.insertarLineaInsumo(l,idInstru);
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
                txtAct.Text = producto.instructivo.actividades;
                dgvInsumos.DataSource = DBController.listarLineaInsumo(producto.instructivo.id);
            }
            estadoObj = Estado.Buscar;
            estadoComponentes(Estado.Buscar);
        }

        private void btnElimina_Click(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            linea = new Service.lineaInsumo();
            linea.insumo = new Service.insumo();
            linea.insumo = insumo;
            linea.cantInsumo = int.Parse(txtCant.Text);
            agregarTabla(linea);
            lineas.Add(linea);
        }

        private void agregarTabla(lineaInsumo l)
        {
            if (flag == 1)
            {
                dgvInsumos.Rows.Add(l.insumo.nombre, l.insumo.cantidad, l.insumo.unidad,
                l.insumo.granularidad, l.insumo.color, "Si");
            }
            else
            {
                dgvInsumos.Rows.Add(l.insumo.nombre, l.insumo.cantidad, l.insumo.unidad,
                l.insumo.granularidad, l.insumo.color, "No");
            }
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                insumo = formInsumos.InsumoSeleccionado;
                txtIdInsumo.Text = insumo.id.ToString();
                txtNomInsumo.Text = insumo.nombre;
                if (insumo.restriccion)
                {
                    flag = 1;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
