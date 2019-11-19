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
    public partial class frmGestionarPlan : Form
    {
        int flagOrden = 0;
        int flagElim = 0;
        int flagHistorial = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        detalleMaquinaria det;
        BindingList<Service.detalleMaquinaria> detMaquinarias;
        BindingList<Service.ordenProduccion> ordenes;
        BindingList<Service.ordenProduccion> ordenesAg;
        BindingList<Service.ordenProduccion> ordenesMod;
        BindingList<Service.detalleMaquinaria> lineasEliminadas;
        trabajador trabajador;
        mensaje mensaje;
        private Service.planMaestroProduccion _pmp;
        Service.ordenProduccion ordenSeleccionada;
        Estado estado;

        public planMaestroProduccion PMP { get => _pmp; set => _pmp = value; }

        public frmGestionarPlan(Service.planMaestroProduccion pmpSelec = null, trabajador t = null)
        {
            trabajador = t;
            PMP = new planMaestroProduccion();
            InitializeComponent();
            estado = Estado.Inicial;
            estadoComponentes(estado);
            calOrdenProduccion.MaxSelectionCount = 1;
            dgvOrden.AutoGenerateColumns = false;
            dgvMaquinaria.AutoGenerateColumns = false;
            ordenSeleccionada = new ordenProduccion();
            det = new detalleMaquinaria();
            mensaje = new mensaje();
            detMaquinarias = new BindingList<detalleMaquinaria>();
            lineasEliminadas = new BindingList<detalleMaquinaria>();
            ordenes = new BindingList<ordenProduccion>();
            ordenesAg = new BindingList<ordenProduccion>();
            ordenesMod = new BindingList<ordenProduccion>();
            if (pmpSelec == null)
            {
                Service.planMaestroProduccion[] pmpSel = DBController.listarPMPEstado(1);
                if (pmpSel != null)
                {
                    llenarDatos(pmpSel[0]);
                }
            }
            else
            {
                flagHistorial = 1;
                llenarDatos(pmpSelec);
            }
        }

        private void llenarDatos(Service.planMaestroProduccion PMPSeleccionado)
        {
            PMP = PMPSeleccionado;
            detMaquinarias = new BindingList<detalleMaquinaria>(DBController.listarDetalleMaquinaria(PMP.id));
            if (detMaquinarias != null)
            {
                PMP.maquinarias = detMaquinarias.ToArray();
                dgvMaquinaria.DataSource = detMaquinarias;
            }
            txtNOrden.Text = PMP.id.ToString();
            Service.ordenProduccion[] lo = DBController.listarOrdenesProduccionPlan(PMP.id);
            PMP.ordenes = lo.ToArray();
            ordenes = new BindingList<Service.ordenProduccion>(PMP.ordenes);
            estado = Estado.Buscar;
            estadoComponentes(estado);
        }

        private void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:

                    // Botones
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditarOrden.Enabled = false;
                    btnBuscarMaquinaria.Enabled = false;
                    btnAgregarMaquinaria.Enabled = false;

                    // Etiquetas
                    lblCodigoMaquinaria.Enabled = false;
                    lblNombreMaquinaria.Enabled = false;
                    lblCodigoPMP.Enabled = false;

                    // Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNOrden.Enabled = false;

                    // Calendario
                    calOrdenProduccion.Enabled = false;
                    calOrdenProduccion.SetDate(new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1));

                    // Data Grid View
                    dgvMaquinaria.Enabled = false;
                    dgvOrden.Enabled = false;
                    if (flagHistorial == 1)
                    {
                        gbOrdenes.Enabled = true;
                        calOrdenProduccion.Enabled = true;
                        dgvOrden.Enabled = true;
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        gbDatosGenerales.Enabled = false;
                        dgvMaquinaria.Enabled = false;
                        btnEditarOrden.Enabled = false;
                    }
                    break;
                case Estado.Nuevo:

                    // Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditarOrden.Enabled = true;
                    btnBuscarMaquinaria.Enabled = true;
                    btnAgregarMaquinaria.Enabled = true;

                    // Etiquetas
                    lblCodigoMaquinaria.Enabled = true;
                    lblNombreMaquinaria.Enabled = true;
                    lblCodigoPMP.Enabled = true;

                    // Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNOrden.Enabled = true;

                    // Calendario
                    calOrdenProduccion.Enabled = true;
                    calOrdenProduccion.SetDate(new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1));

                    // Data Grid View
                    dgvMaquinaria.Enabled = true;
                    dgvOrden.Enabled = true;
                    if (flagHistorial == 1)
                    {
                        gbOrdenes.Enabled = true;
                        calOrdenProduccion.Enabled = true;
                        dgvOrden.Enabled = true;
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        gbDatosGenerales.Enabled = false;
                        dgvMaquinaria.Enabled = false;
                        btnEditarOrden.Enabled = false;
                    }

                    break;
                case Estado.Buscar:
                    // Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditarOrden.Enabled = false;
                    btnBuscarMaquinaria.Enabled = false;
                    btnAgregarMaquinaria.Enabled = false;

                    // Etiquetas
                    lblCodigoMaquinaria.Enabled = false;
                    lblNombreMaquinaria.Enabled = false;
                    lblCodigoPMP.Enabled = false;

                    // Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNOrden.Enabled = false;

                    // Calendario
                    calOrdenProduccion.Enabled = false;
                    DateTime date = PMP.periodo.AddHours(5);
                    calOrdenProduccion.SetDate(new DateTime(date.Year, date.Month, 1));

                    // Data Grid View
                    dgvMaquinaria.Enabled = false;
                    dgvOrden.Enabled = false;
                    if (flagHistorial == 1)
                    {
                        gbOrdenes.Enabled = true;
                        calOrdenProduccion.Enabled = true;
                        dgvOrden.Enabled = true;
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        gbDatosGenerales.Enabled = false;
                        dgvMaquinaria.Enabled = false;
                        btnEditarOrden.Enabled = false;
                    }

                    break;

                case Estado.Modificar:
                    // Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEditarOrden.Enabled = true;
                    btnBuscarMaquinaria.Enabled = true;
                    btnAgregarMaquinaria.Enabled = true;

                    // Etiquetas
                    lblCodigoMaquinaria.Enabled = true;
                    lblNombreMaquinaria.Enabled = true;
                    lblCodigoPMP.Enabled = true;

                    // Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNOrden.Enabled = true;

                    // Calendario
                    calOrdenProduccion.Enabled = true;

                    // Data Grid View
                    dgvMaquinaria.Enabled = true;
                    dgvOrden.Enabled = true;
                    if (flagHistorial == 1)
                    {
                        gbOrdenes.Enabled = true;
                        calOrdenProduccion.Enabled = true;
                        dgvOrden.Enabled = true;
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        gbDatosGenerales.Enabled = false;
                        dgvMaquinaria.Enabled = false;
                        btnEditarOrden.Enabled = false;
                    }
                    break;
                default:
                    if (flagHistorial == 1)
                    {
                        gbOrdenes.Enabled = true;
                        calOrdenProduccion.Enabled = true;
                        dgvOrden.Enabled = true;
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        gbDatosGenerales.Enabled = false;
                        dgvMaquinaria.Enabled = false;
                        btnEditarOrden.Enabled = false;
                    }
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formGestionarOrden = new frmGestionarOrden();
            formGestionarOrden.ShowDialog(this);
            PMP.ordenes[formGestionarOrden.OrderProduccion.fecha.Day] = formGestionarOrden.OrderProduccion;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPMS form = new frmPMS();
            form.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMaquinaria form = new frmMaquinaria();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                det = form.DetalleMaquinariaSeleccionada;
                txtCodigo.Text = det.maquinaria.id.ToString();
                txtNombre.Text = det.maquinaria.nombre;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _pmp = new Service.planMaestroProduccion();
            limpiarComponentes();
            estado = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtNOrden.Text = "";
            PMP = new planMaestroProduccion();
            ordenSeleccionada = new ordenProduccion();
            det = new detalleMaquinaria();
            detMaquinarias = new BindingList<detalleMaquinaria>();
            lineasEliminadas = new BindingList<detalleMaquinaria>();
            ordenes = new BindingList<ordenProduccion>();
            ordenesAg = new BindingList<ordenProduccion>();
            ordenesMod = new BindingList<ordenProduccion>();
            dgvOrden.DataSource = null;
            dgvMaquinaria.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == Estado.Nuevo)
            {
                PMP.periodo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                PMP.id = DBController.insertarPMP(PMP);
                txtNOrden.Text = PMP.id.ToString();
                foreach (ordenProduccion l in PMP.ordenes)
                {
                    DBController.insertarOrdenProduccion(l,PMP.id);
                }
                foreach (detalleMaquinaria m in PMP.maquinarias)
                {
                    DBController.insertarDetalleMaquinaria(m,PMP.id);
                }
                mensaje.descripcion = "VALIDAR PMP";
                mensaje.emisor = trabajador;
                mensaje.fechaEnvio = DateTime.Now;
                mensaje.fechaEnvioSpecified = true;
                trabajador[] trabajadores = DBController.listarTrabajadores("");
                foreach (trabajador tr in trabajadores)
                {
                    if (trabajador.rol.idRol == 2)
                    {
                        mensaje.receptor = tr;
                        break;
                    }
                }
                DBController.insertarMensaje(mensaje);
                MessageBox.Show("Plan Maestro de Producción correctamente añadido.", "Mensaje Confirmacion", MessageBoxButtons.OK);
            }
            else if (estado == Estado.Modificar)
            {
                foreach (ordenProduccion o in ordenesAg)
                {
                    o.id = DBController.insertarOrdenProduccion(o,PMP.id);
                    foreach (lineaOrden lo in o.lineasOrden)
                    {
                        DBController.insertarLineaOrden(lo, o.id);
                    }
                }
                foreach (ordenProduccion o in PMP.ordenes)
                {
                    if (o.lineasOrden != null)
                    {
                        foreach (lineaOrden lo in o.lineasOrden)
                        {
                            DBController.eliminarLineaOrden(o.id);
                            DBController.insertarLineaOrden(lo, o.id);
                        }
                    }
                }

                foreach (detalleMaquinaria m in PMP.maquinarias)
                {
                    DBController.eliminarDetalleMaquinaria(m.idDetalleM);
                    DBController.insertarDetalleMaquinaria(m,PMP.id);
                }
                if (flagElim == 1)
                {
                    foreach (Service.detalleMaquinaria l in lineasEliminadas)
                    {
                        DBController.eliminarDetalleMaquinaria(l.idDetalleM);
                    }
                }
                PMP.estado = Service.estado.Pendiente;
                DBController.actualizarPMP(PMP);
                mensaje.descripcion = "VALIDAR PMP";
                mensaje.emisor = trabajador;
                mensaje.fechaEnvio = DateTime.Now;
                mensaje.fechaEnvioSpecified = true;
                trabajador[] trabajadores = DBController.listarTrabajadores("");
                foreach(trabajador tr in trabajadores)
                {
                    if(tr.rol.idRol == 2)
                    {
                        mensaje.receptor = tr;
                        break;
                    }
                }
                DBController.insertarMensaje(mensaje);
                MessageBox.Show("Plan Maestro de Producción correctamente modificado.", "Mensaje Confirmacion", MessageBoxButtons.OK);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = Estado.Modificar;
            estadoComponentes(estado);
        }

        private void calOrdenProduccion_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(flagHistorial == 0)
            {
                if(estado == Estado.Nuevo)
                {
                    if(calOrdenProduccion.SelectionRange.Start.Month != DateTime.Now.Month )
                    {
                        calOrdenProduccion.SetDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
                    }
                }
                else
                {
                    if (calOrdenProduccion.SelectionRange.Start.Month != PMP.periodo.AddHours(5).Month)
                    {
                        calOrdenProduccion.SetDate(new DateTime(PMP.periodo.AddHours(5).Year, PMP.periodo.AddHours(5).Month, 1));
                    }
                }
            }
            else
            {
                if (calOrdenProduccion.SelectionRange.Start.Month != PMP.periodo.AddHours(5).Month)
                {
                    calOrdenProduccion.SetDate(new DateTime(PMP.periodo.AddHours(5).Year, PMP.periodo.AddHours(5).Month, 1));
                }
            }
            int hubo = 0;
            flagOrden = 0;
            if (PMP.ordenes != null)
            {
                foreach (Service.ordenProduccion item in PMP.ordenes)
                {
                    string a = item.fecha.AddHours(5).ToString("dd-MM-yyy");
                    string b = calOrdenProduccion.SelectionRange.Start.ToString("dd-MM-yyy");
                    if (a == b)
                    {
                        if (item.lineasOrden == null)
                        {
                            item.lineasOrden = DBController.listarLineaOrden(item.id);
                        }
                        ordenSeleccionada = item;
                        dgvOrden.DataSource = item.lineasOrden;
                        hubo = 1;
                    }
                }
            }
            if (hubo == 0)
            {
                ordenSeleccionada = new ordenProduccion();
                ordenSeleccionada.fecha = calOrdenProduccion.SelectionRange.Start;
                ordenSeleccionada.fechaSpecified = true;
                dgvOrden.DataSource = null;
                flagOrden = 1;
            }
        }

        private void dgvOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvOrden.Rows[e.RowIndex].DataBoundItem;
            dgvOrden.Rows[e.RowIndex].Cells["Producto"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["CodigoOrden"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells["Producto"].Value = lineaOrdenFila.producto.nombre;
            dgvOrden.Rows[e.RowIndex].Cells["CodigoOrden"].Value = lineaOrdenFila.producto.idProducto;
            dgvOrden.Rows[e.RowIndex].Cells["Cantidad"].Value = lineaOrdenFila.cantProducto;
        }
        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleMaquinaria maqFila = (Service.detalleMaquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Maquinaria"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Fecha"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Value = maqFila.maquinaria.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Maquinaria"].Value = maqFila.maquinaria.nombre;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Fecha"].Value = maqFila.fecha.AddHours(5);
        }

        private void btnEditarOrden_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formOrd = new frmGestionarOrden(ordenSeleccionada,PMP.id);
            if (formOrd.ShowDialog(this) == DialogResult.OK)
            {
                ordenSeleccionada = formOrd.OrderProduccion;
                dgvOrden.DataSource = ordenSeleccionada.lineasOrden;
                if (flagOrden == 1)
                {
                    ordenesAg.Add(ordenSeleccionada);
                    BindingList<ordenProduccion> lineasAg = new BindingList<ordenProduccion>();
                    foreach (ordenProduccion item in ordenes)
                    {
                        lineasAg.Add(item);
                    }
                    lineasAg.Add(ordenSeleccionada);
                    ordenes = lineasAg;
                    PMP.ordenes = ordenes.ToArray();
                    flagOrden = 0;
                }
            }
        }

        private void btnAgregarMaquinaria_Click(object sender, EventArgs e)
        {
            BindingList<detalleMaquinaria> lineasAg = new BindingList<detalleMaquinaria>();
            foreach (detalleMaquinaria item in detMaquinarias)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(det);
            detMaquinarias = lineasAg;
            PMP.maquinarias = detMaquinarias.ToArray();
            dgvMaquinaria.DataSource = detMaquinarias;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string str = dgvMaquinaria.Rows[dgvMaquinaria.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.detalleMaquinaria> lineasElim = new BindingList<detalleMaquinaria>();
            foreach (detalleMaquinaria item in detMaquinarias)
            {
                if (item.maquinaria.nombre != str) lineasElim.Add(item);
                if (estado == Estado.Modificar && item.maquinaria.nombre == str)
                {
                    lineasEliminadas.Add(item);
                    flagElim = 1;
                }
            }
            detMaquinarias = lineasElim;
            PMP.maquinarias = detMaquinarias.ToArray();
            dgvMaquinaria.DataSource = detMaquinarias;
        }
    }
}
