﻿using System;
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
        int idPMP = 0;
        int flagElim = 0;
        int flagEnv = 0;
        int flagHist = 0;
        private DateTime _periodoPlanMaestroProduccion;
        private int _idPlanMaestroProduccion;
        private Service.ordenProduccion _orderProduccion;
        private Service.lineaOrden lineaOrden;
        private Service.producto producto;
        BindingList<Service.lineaOrden> lineas;
        BindingList<Service.lineaOrden> lineasEliminadas;
        Service.ordenProduccion ordenRecivida;
        private Estado estadoFormulario;

        Service.ServicioClient DBController = new Service.ServicioClient();

        public ordenProduccion OrderProduccion { get => ordenRecivida; set => ordenRecivida = value; }

        public int Flag { get => flagEnv; set => flagEnv = value; }

        public frmGestionarOrden(Service.ordenProduccion ordenReciv = null, int id = 0, int flag=0)
        {
            flagHist = flag;
            InitializeComponent();
            idPMP = id;
            ordenRecivida = ordenReciv;
            estadoFormulario = Estado.Inicial;
            estadoComponentes(estadoFormulario);
            lineas = new BindingList<lineaOrden>();
            lineasEliminadas = new BindingList<lineaOrden>();
            lineaOrden = new lineaOrden();
            _orderProduccion = new ordenProduccion();
            dgvOrdenProduccion.AutoGenerateColumns = false;
            if (ordenRecivida != null)
            {
                if (ordenRecivida.id == 0)
                {
                    _orderProduccion = ordenRecivida;
                    dtpOrden.Value = _orderProduccion.fecha;
                    estadoFormulario = Estado.Nuevo;
                    estadoComponentes(estadoFormulario);
                }
                else
                { 
                    Flag = 2;
                    llenarDatos(ordenRecivida);
                    _orderProduccion = ordenRecivida;
                }
                dtpOrden.Enabled = false;
            }
        }

        private void llenarDatos(ordenProduccion orden)
        {
            txtNOrden.Text = orden.id.ToString();
            dtpOrden.Value = orden.fecha.AddHours(5);
            Service.lineaOrden[] l = DBController.listarLineaOrden(orden.id);
            if (l != null)
            {
                orden.lineasOrden = l.ToArray();
                lineas = new BindingList<lineaOrden>(l);
                dgvOrdenProduccion.DataSource = lineas;
            }
            else
            {
                flagEnv = 1;
            }
            estadoFormulario = Estado.Buscar;
            estadoComponentes(Estado.Buscar);
            if (flagHist == 2)
            {
                btnModificar.Visible = false;
                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                btnVerificar.Visible = true;
            }
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
                    dgvOrdenProduccion.Enabled = false;

                    //Grupos
                    gbDatosGenerales.Enabled = false;
                    gbDetalleOrden.Enabled = false;
                    gbDatosOrden.Enabled = true;
                    txtNOrden.Enabled = false;
                    dtpOrden.Enabled = false;
                    
                    if(flagHist == 0)
                    {
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    btnVerificar.Visible = false;
                    //Asignar el estado
                    estadoFormulario = estado;

                    break;
                case Estado.Nuevo:

                    //Botones
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
                    dgvOrdenProduccion.Enabled = true;

                    //Grupos
                    gbDatosGenerales.Enabled = true;
                    gbDetalleOrden.Enabled = true;
                    gbDatosOrden.Enabled = true;


                    if (flagHist == 0)
                    {
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    btnVerificar.Visible = false;

                    //Asignar el estado
                    estadoFormulario = estado;
                    break;
                case Estado.Buscar:

                    //Botones
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;

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
                    dgvOrdenProduccion.Enabled = false;

                    //Grupos
                    gbDatosGenerales.Enabled = false;
                    gbDetalleOrden.Enabled = false;
                    gbDatosOrden.Enabled = true;
                    txtNOrden.Enabled = false;
                    dtpOrden.Enabled = false;


                    if (flagHist == 0)
                    {
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    btnVerificar.Visible = false;

                    //Asignar el estado
                    estadoFormulario = estado;

                    break;
                case Estado.Modificar:

                    //Botones
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
                    dgvOrdenProduccion.Enabled = true;

                    //Grupos
                    gbDatosGenerales.Enabled = true;
                    gbDetalleOrden.Enabled = true;
                    gbDatosOrden.Enabled = true;



                    if (flagHist == 0)
                    {
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    btnVerificar.Visible = false;
                    break;
                default:
                    break;
            }
            txtNOrden.Enabled = false;
            txtCodigoProducto.Enabled = false;
            txtNombre.Enabled = false;
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
            dgvOrdenProduccion.DataSource = null;
            dgvOrdenProduccion.Rows.Clear();
            dgvOrdenProduccion.Refresh();
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
            if (ordenRecivida != null)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cant;
            if (producto == null || producto.idProducto == 0)
            {
                MessageBox.Show("No se ha seleccionado un Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("No se ha ingresado la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtCantidad.Text, out int canti))
            {
                cant = canti;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lineaOrden = new Service.lineaOrden();
            lineaOrden.cantProducto = cant;
            lineaOrden.producto = producto;
            BindingList<Service.lineaOrden> lineasAg = new BindingList<lineaOrden>();
            foreach (lineaOrden item in lineas)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(lineaOrden);
            lineas = lineasAg;
            _orderProduccion.lineasOrden = lineas.ToArray();
            dgvOrdenProduccion.DataSource = lineas;
            if(Flag == 2)
            {
                Flag = 1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string str = dgvOrdenProduccion.Rows[dgvOrdenProduccion.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.lineaOrden> lineasElim = new BindingList<lineaOrden>();
            foreach (lineaOrden item in lineas)
            {
                if (item.producto.nombre != str) lineasElim.Add(item);
                if (estadoFormulario == Estado.Modificar && item.producto.nombre == str)
                {
                    lineasEliminadas.Add(item);
                    flagElim = 1;
                    flagEnv = 1;
                }
            }
            lineas = lineasElim;
            dgvOrdenProduccion.DataSource = lineas;
            if (Flag == 2)
            {
                Flag = 1;
            }
        }
        private void dgvOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvOrdenProduccion.Rows[e.RowIndex].DataBoundItem;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Producto"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Producto"].Value = lineaOrdenFila.producto.nombre;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Codigo"].Value = lineaOrdenFila.producto.idProducto;
            dgvOrdenProduccion.Rows[e.RowIndex].Cells["Cantidad"].Value = lineaOrdenFila.cantProducto;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if(lineas.Count() == 0)
            {
                MessageBox.Show("No se han ingresado productos para la Orden de Producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _orderProduccion.fecha = dtpOrden.Value;
            if (ordenRecivida != null)
            {
                _orderProduccion.lineasOrden = lineas.ToArray();
                OrderProduccion = _orderProduccion;
                this.DialogResult = DialogResult.OK;
                Flag = flagEnv;
            }
            else
            {
                if (estadoFormulario == Estado.Nuevo)
                {
                    _orderProduccion.id = DBController.insertarOrdenProduccion(_orderProduccion, idPMP);
                    txtNOrden.Text = _orderProduccion.id.ToString();
                    foreach (Service.lineaOrden l in lineas)
                    {
                        DBController.insertarLineaOrden(l, _orderProduccion.id);
                    }
                    MessageBox.Show("Orden de Producción correctamente añadida.", "Mensaje Confirmacion", MessageBoxButtons.OK);

                }
                else if (estadoFormulario == Estado.Modificar)
                {
                    DBController.actualizarOrdenProduccion(_orderProduccion, 1);
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoFormulario = Estado.Modificar;
            estadoComponentes(estadoFormulario);
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmOrdenes formOrd = new frmOrdenes();
            if (formOrd.ShowDialog(this) == DialogResult.OK)
            {
                _orderProduccion = formOrd.OrdenSeleccionada;
                llenarDatos(_orderProduccion);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool disponible = DBController.verificarDisponibilidadInsumos(_orderProduccion);
            if (!disponible)
            {
                MessageBox.Show("No hay Insumos Suficientes para realizar la Orden. Se notificara a Almacen");
            }
            else
            {
                foreach (lineaOrden item in _orderProduccion.lineasOrden)
                {
                    item.estadoCalidad = estadoMaterial.Pendiente;
                    item.estadoCalidadSpecified = true;
                    DBController.actualizarLineaOrden(item);
                }
                MessageBox.Show("Se procedió a enviar la Orden a revisión de Calidad. Se revisarán los productos correspondientes","ORDEN ENVIADA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
