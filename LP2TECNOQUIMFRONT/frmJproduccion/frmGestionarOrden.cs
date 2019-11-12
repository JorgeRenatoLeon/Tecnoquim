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

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmGestionarOrden : Form
    {

        int flagElim = 0;
        private DateTime _periodoPlanMaestroProduccion;
        private int _idPlanMaestroProduccion;
        private Service.ordenProduccion _orderProduccion;
        private Service.lineaOrden lineaOrden;
        private Service.producto producto;
        BindingList<Service.lineaOrden> lineas;
        BindingList<Service.lineaOrden> lineasEliminadas;
        private Estado estadoFormulario;

        Service.ServicioClient DBController = new Service.ServicioClient();

        public ordenProduccion OrderProduccion { get => _orderProduccion; set => _orderProduccion = value; }

        public frmGestionarOrden()
        {
            InitializeComponent();
            estadoFormulario = Estado.Inicial;
            estadoComponentes(estadoFormulario);
            lineas = new BindingList<lineaOrden>();
            lineasEliminadas = new BindingList<lineaOrden>();
            lineaOrden = new lineaOrden();
            _orderProduccion = new ordenProduccion();
            dgvOrden.AutoGenerateColumns = false;
        }

        public frmGestionarOrden(DateTime periodoPlanMaestroProduccion, int idPlanMaestroProduccion)
        {
            InitializeComponent();
            _periodoPlanMaestroProduccion = periodoPlanMaestroProduccion;
            _idPlanMaestroProduccion = idPlanMaestroProduccion;
        }

        private void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    //Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;

                    // Cajas de texto
                    txtNOrden.Enabled = false;
                    txtNombre.Enabled = false;
                    txtCodigoProducto.Enabled = false;
                    txtCantidad.Enabled = false;

                    //Etiquetas
                    lblFecha.Enabled = false;
                    lblCodigoProducto.Enabled = false;
                    lblCantidadDetalle.Enabled = false;
                    lblNombreProducto.Enabled = false;
                    lblNOrden.Enabled = false;

                    //DataGridView
                    dgvOrden.Enabled = false;

                    //Grupos
                    gbDatosGenerales.Enabled = false;
                    gbDetalleOrden.Enabled = false;
                    gbDatosOrden.Enabled = false;

                    //Asignar el estado
                    estadoFormulario = estado;

                    break;
                case Estado.Nuevo:

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;

                    // Cajas de texto
                    txtNOrden.Enabled = false;
                    txtNombre.Enabled = true;
                    txtCodigoProducto.Enabled = false;
                    txtCantidad.Enabled = true;

                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblCodigoProducto.Enabled = true;
                    lblCantidadDetalle.Enabled = true;
                    lblNombreProducto.Enabled = true;
                    lblNOrden.Enabled = true;

                    //DataGridView
                    dgvOrden.Enabled = true;

                    //Grupos
                    gbDatosGenerales.Enabled = true;
                    gbDetalleOrden.Enabled = true;
                    gbDatosOrden.Enabled = true;

                    //Asignar el estado
                    estadoFormulario = estado;
                    break;
                case Estado.Buscar:

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;

                    // Cajas de texto
                    txtNOrden.Enabled = false;
                    txtNombre.Enabled = true;
                    txtCodigoProducto.Enabled = false;
                    txtCantidad.Enabled = true;

                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblCodigoProducto.Enabled = true;
                    lblCantidadDetalle.Enabled = true;
                    lblNombreProducto.Enabled = true;
                    lblNOrden.Enabled = true;

                    //DataGridView
                    dgvOrden.Enabled = true;

                    //Grupos
                    gbDatosGenerales.Enabled = true;
                    gbDetalleOrden.Enabled = true;
                    gbDatosOrden.Enabled = true;

                    break;
                case Estado.Modificar:

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;

                    // Cajas de texto
                    txtNOrden.Enabled = false;
                    txtNombre.Enabled = true;
                    txtCodigoProducto.Enabled = false;
                    txtCantidad.Enabled = true;

                    //Etiquetas
                    lblFecha.Enabled = true;
                    lblCodigoProducto.Enabled = true;
                    lblCantidadDetalle.Enabled = true;
                    lblNombreProducto.Enabled = true;
                    lblNOrden.Enabled = true;

                    //DataGridView
                    dgvOrden.Enabled = true;

                    //Grupos
                    gbDatosGenerales.Enabled = true;
                    gbDetalleOrden.Enabled = true;
                    gbDatosOrden.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((_periodoPlanMaestroProduccion.Month == dtpOrden.Value.Month) && (_periodoPlanMaestroProduccion.Year == dtpOrden.Value.Year))
            {
                _orderProduccion = new Service.ordenProduccion();
                _orderProduccion.fecha = dtpOrden.Value;
                _orderProduccion.lineasOrden = (lineaOrden[])dgvOrden.DataSource; // No sé si esto funcione

                if (estadoFormulario == Estado.Nuevo)
                {
                    DBController.insertarOrdenProduccion(_orderProduccion, _idPlanMaestroProduccion);

                    foreach (lineaOrden l in _orderProduccion.lineasOrden)
                    {
                        DBController.insertarLineaOrden(l, _orderProduccion.id);
                    }
                    MessageBox.Show("Orden de Producción correctamente añadida.", "Mensaje Confirmacion", MessageBoxButtons.OK);
                }
                else if (estadoFormulario == Estado.Modificar)
                {
                    DBController.actualizarOrdenProduccion(_orderProduccion, _idPlanMaestroProduccion);

                    foreach (lineaOrden l in _orderProduccion.lineasOrden)
                    {
                        DBController.actualizarLineaOrden(l, _orderProduccion.id);
                    }
                    MessageBox.Show("Orden de Producción correctamente modificada.", "Mensaje Confirmacion", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El mes y/o el año de la Orden de Producción no coincide con el del Plan Maestro de Producción.", "Mensaje Error", MessageBoxButtons.OK);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoFormulario = Estado.Nuevo;
            estadoComponentes(estadoFormulario);
        }

        public void limpiarComponentes()
        {
            txtNOrden.Text = "";
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            lineas = new BindingList<lineaOrden>();
            lineasEliminadas = new BindingList<lineaOrden>();
            lineaOrden = new lineaOrden();
            _orderProduccion = new ordenProduccion();
            dgvOrden.DataSource = null;
            dgvOrden.Rows.Clear();
            dgvOrden.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProducto formProducto = new frmProducto();
            if (formProducto.ShowDialog(this) == DialogResult.OK)
            {
                producto = formProducto.ProductoSeleccionado;
                txtCodigoProducto.Text = producto.idProducto.ToString();
                txtNombre.Text = producto.nombre;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoFormulario = Estado.Inicial;
            estadoComponentes(estadoFormulario);
        }

        private void frmGestionarOrden_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lineaOrden = new Service.lineaOrden();
            lineaOrden.cantProducto = int.Parse(txtCantidad.Text);
            lineaOrden.producto = producto;
            BindingList<Service.lineaOrden> lineasAg = new BindingList<lineaOrden>();
            foreach (lineaOrden item in lineas)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(lineaOrden);
            lineas = lineasAg;
            _orderProduccion.lineasOrden = lineas.ToArray();
            dgvOrden.DataSource = lineas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string str = dgvOrden.Rows[dgvOrden.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.lineaOrden> lineasElim = new BindingList<lineaOrden>();
            foreach (lineaOrden item in lineas)
            {
                if (item.producto.nombre != str) lineasElim.Add(item);
                if (estadoFormulario == Estado.Modificar && item.producto.nombre == str)
                {
                    lineasEliminadas.Add(item);
                    flagElim = 1;
                }
            }
            lineas = lineasElim;
            dgvOrden.DataSource = lineas;
        }
        private void dgvOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvOrden.Rows[e.RowIndex].DataBoundItem;
            dgvOrden.Rows[e.RowIndex].Cells["Producto"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["Producto"].Value = lineaOrdenFila.producto.nombre;
            dgvOrden.Rows[e.RowIndex].Cells["Codigo"].Value = lineaOrdenFila.producto.idProducto;
            dgvOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = lineaOrdenFila.cantProducto;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            _orderProduccion.fecha = dtpOrden.Value;
            if (estadoFormulario == Estado.Nuevo)
            {
                _orderProduccion.id = DBController.insertarOrdenProduccion(_orderProduccion,1);
                txtNOrden.Text = _orderProduccion.id.ToString();
                foreach (Service.lineaOrden l in lineas)
                {
                    DBController.insertarLineaOrden(l, _orderProduccion.id);
                }
                MessageBox.Show("Orden de Producción correctamente añadida.", "Mensaje Confirmacion", MessageBoxButtons.OK);

            }
            else if (estadoFormulario == Estado.Modificar)
            {
                DBController.actualizarOrdenProduccion(_orderProduccion,1);
                DBController.actualizarInstructivo(producto.instructivo, producto.idProducto);
                foreach (Service.lineaOrden l in lineas)
                {
                    DBController.eliminarLineaOrden(l.idLineaOrden);
                    DBController.insertarLineaOrden(l, _orderProduccion.id);
                }
                if (flagElim == 1)
                {
                    foreach (Service.lineaOrden l in lineasEliminadas)
                    {
                        DBController.eliminarLineaOrden(l.idLineaOrden);
                    }
                }
                MessageBox.Show("Orden de Producción correctamente modificada.", "Mensaje Confirmacion", MessageBoxButtons.OK);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoFormulario = Estado.Modificar;
            estadoComponentes(estadoFormulario);
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenes formOrd = new frmOrdenes();
            if (formOrd.ShowDialog() == DialogResult.OK)
            {
                _orderProduccion = formOrd.OrdenSeleccionada;
                txtNOrden.Text = _orderProduccion.id.ToString();
                dtpOrden.Value = _orderProduccion.fecha;
                lineas = new BindingList<lineaOrden>(DBController.listarLineaOrden(_orderProduccion.id));
                dgvOrden.DataSource = lineas;
            }
            estadoFormulario = Estado.Buscar;
            estadoComponentes(Estado.Buscar);
        }
    }
}
