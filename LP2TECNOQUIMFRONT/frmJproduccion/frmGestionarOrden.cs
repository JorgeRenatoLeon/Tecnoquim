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

        private DateTime _periodoPlanMaestroProduccion;
        private int _idPlanMaestroProduccion;
        private Service.ordenProduccion _orderProduccion;
        private Estado estadoFormulario;

        Service.ServicioClient DBController = new Service.ServicioClient();

        public ordenProduccion OrderProduccion { get => _orderProduccion; set => _orderProduccion = value; }

        public frmGestionarOrden()
        {
            InitializeComponent();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();

        }

        public void limpiarComponentes()
        {
            txtNOrden.Text = "";
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProducto formProducto = new frmProducto();
            formProducto.Visible = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrden formProducto = new frmOrden();
            formProducto.Visible = true;
            this.Close();
        }

        private void frmGestionarOrden_Load(object sender, EventArgs e)
        {

        }
    }
}
