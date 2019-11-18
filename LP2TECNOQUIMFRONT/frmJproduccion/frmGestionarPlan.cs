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

        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.detalleMaquinaria[] lm;
        Service.maquinaria maquinaria;
        BindingList<Service.maquinaria> maquinarias;
        BindingList<Service.ordenProduccion> ordenes;
        private Service.planMaestroProduccion _pmp;
        Service.ordenProduccion ordenSeleccionada;
        Estado estado;

        public planMaestroProduccion PMP { get => _pmp; set => _pmp = value; }

        public frmGestionarPlan()
        {
            PMP = new planMaestroProduccion();
            InitializeComponent();
            estado = Estado.Inicial;
            estadoComponentes(estado);
            calOrdenProduccion.MaxSelectionCount = 1;
            dgvOrden.AutoGenerateColumns = false;
            dgvMaquinaria.AutoGenerateColumns = false;
            ordenSeleccionada = new ordenProduccion();
            maquinaria = new maquinaria();
            maquinarias = new BindingList<maquinaria>();
            ordenes = new BindingList<ordenProduccion>();
            Service.planMaestroProduccion[] pmpSel = DBController.listarPMPEstado(1);
            if (pmpSel != null)
            {
                llenarDatos(pmpSel[0]);
            }
        }

        private void llenarDatos(Service.planMaestroProduccion PMPSeleccionado)
        {
            PMP = PMPSeleccionado;
            lm = DBController.listarDetalleMaquinaria(PMP.id);
            foreach (Service.detalleMaquinaria item in lm)
            {
                Service.maquinaria[] maqs = DBController.listarMaquinaria(item.maquinaria.nombre);
                maquinarias.Add(maqs[0]);
            }
            if (lm != null)
            {
                PMP.maquinarias = maquinarias.ToArray();
                dgvMaquinaria.DataSource = maquinarias;
            }
            txtNOrden.Text = PMP.id.ToString();
            Service.ordenProduccion[] lo = DBController.listarOrdenesProduccionPlan(PMP.id);
            foreach (Service.ordenProduccion item in lo)
            {
                item.lineasOrden = DBController.listarLineaOrden(item.id);
            }
            PMP.ordenes = lo.ToArray();
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
                    break;
                default:
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
                maquinaria = form.MaquinariaSeleccionada;
                txtCodigo.Text = maquinaria.id.ToString();
                txtNombre.Text = maquinaria.nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
            dgvOrden.DataSource = new BindingList<ordenProduccion>();
            dgvMaquinaria.DataSource = new BindingList<detalleMaquinaria>();
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
                foreach (maquinaria m in PMP.maquinarias)
                {
                    detalleMaquinaria det = new detalleMaquinaria();
                    det.activo = true;
                    det.fecha = DateTime.Now;
                    det.fechaSpecified = true;
                    det.maquinaria = m;
                    DBController.insertarDetalleMaquinaria(det);
                }
                MessageBox.Show("Plan Maestro de Producción correctamente añadido.", "Mensaje Confirmacion", MessageBoxButtons.OK);

            }
            else if (estado == Estado.Modificar)
            {
                DBController.actualizarPMP(PMP);
                //foreach (Service.lineaOrden l in lineas)
                //{
                  //  DBController.eliminarLineaOrden(l.idLineaOrden);
                    //DBController.insertarLineaOrden(l, _orderProduccion.id);
                //}
               // if (flagElim == 1)
                //{
                  //  foreach (Service.lineaOrden l in lineasEliminadas)
                    //{
                      //  DBController.eliminarLineaOrden(l.idLineaOrden);
                    //}
               // }
                MessageBox.Show("Orden de Producción correctamente modificada.", "Mensaje Confirmacion", MessageBoxButtons.OK);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = Estado.Modificar;
            estadoComponentes(estado);
        }

        private void calOrdenProduccion_DateChanged(object sender, DateRangeEventArgs e)
        {
            int hubo = 0;
            if (PMP.ordenes != null)
            {
                foreach (Service.ordenProduccion item in PMP.ordenes)
                {
                    string a = item.fecha.AddHours(5).ToString("dd-MM-yyy");
                    string b = calOrdenProduccion.SelectionRange.Start.ToString("dd-MM-yyy");
                    if (a == b)
                    {
                        ordenSeleccionada = item;
                        dgvOrden.DataSource = item.lineasOrden;
                        hubo = 1;
                    }
                }
            }
            if (hubo == 0) dgvOrden.DataSource = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHistorialPMP form = new frmHistorialPMP();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
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
            Service.maquinaria maqFila = (Service.maquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Maquinaria"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Fecha"].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Codigo"].Value = maqFila.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells["Maquinaria"].Value = maqFila.nombre;
            string fecha="";
            foreach (Service.detalleMaquinaria item in lm)
            {
                if (maqFila.nombre == item.maquinaria.nombre)
                {
                    fecha = item.fecha.ToString("dd/MM/yyyy");
                }
            }
            dgvMaquinaria.Rows[e.RowIndex].Cells["Fecha"].Value = fecha;
        }

        private void btnEditarOrden_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formOrd = new frmGestionarOrden(ordenSeleccionada);
            if (formOrd.ShowDialog(this) == DialogResult.OK)
            {
                ordenSeleccionada = formOrd.OrderProduccion;
                dgvOrden.DataSource = ordenSeleccionada.lineasOrden;
            }
        }

        private void btnAgregarMaquinaria_Click(object sender, EventArgs e)
        {
            BindingList<maquinaria> lineasAg = new BindingList<maquinaria>();
            foreach (maquinaria item in maquinarias)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(maquinaria);
            maquinarias = lineasAg;
            PMP.maquinarias = maquinarias.ToArray();
            dgvMaquinaria.DataSource = maquinarias;
        }
    }
}
