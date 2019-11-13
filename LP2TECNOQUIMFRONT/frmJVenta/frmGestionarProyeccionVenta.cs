using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmGestionarProyeccionVenta : Form
    {
        int flagElim = 0;
        Service.proyeccionVenta proyeccionVenta;
        Service.producto producto;
        Service.lineaProyeccion lineaProyeccion;
        BindingList<Service.lineaProyeccion> lineas;
        BindingList<Service.lineaProyeccion> lineasEliminadas;
        Estado estadoObj;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmGestionarProyeccionVenta()
        {
            InitializeComponent();
            estadoObj = Estado.Inicial;
            BindingList<String> meses;
            meses = new BindingList<String>();
            meses.Add("Enero");
            meses.Add("Febrero");
            meses.Add("Marzo");
            meses.Add("Abril");
            meses.Add("Mayo");
            meses.Add("Junio");
            meses.Add("Julio");
            meses.Add("Agosto");
            meses.Add("Setiembre");
            meses.Add("Octubre");
            meses.Add("Noviembre");
            meses.Add("Diciembre");
            cbMes.DataSource = meses;

            BindingList<String> anios;
            anios = new BindingList<String>();
            anios.Add("2018");
            anios.Add("2019");
            anios.Add("2020");
            cbAnio.DataSource = anios;

            
            producto = new Service.producto();
            lineaProyeccion = new Service.lineaProyeccion();
            proyeccionVenta = new Service.proyeccionVenta();
            lineasEliminadas = new BindingList<Service.lineaProyeccion>();
            lineas = new BindingList<Service.lineaProyeccion>();
            estadoComponentes(estadoObj);
        }
        public void limpiarComponentes()
        {
            txtCodigoP.Text = "";
            txtNombreP.Text = "";
            txtCantidadP.Text = "";
            txtNOrden.Text = "";
            lineas = new BindingList<Service.lineaProyeccion>();
            lineasEliminadas = new BindingList<Service.lineaProyeccion>();
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
        }

        public void estadoComponentes(Estado estado) {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarP.Enabled = false;
                    btnEliminarP.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    gbDatosG.Enabled = false;
                    gbDatosP.Enabled = false;
                    dgvProductos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarP.Enabled = true;
                    btnEliminarP.Enabled = true;
                    btnBuscarProducto.Enabled = true;
                    gbDatosG.Enabled = true;
                    gbDatosP.Enabled = true;
                    dgvProductos.Enabled = true;
                    break;

                case Estado.Buscar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAgregarP.Enabled = false;
                    btnEliminarP.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    gbDatosG.Enabled = false;
                    gbDatosP.Enabled = false;
                    dgvProductos.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAgregarP.Enabled = true;
                    btnEliminarP.Enabled = true;
                    btnBuscarProducto.Enabled = true;
                    gbDatosG.Enabled = true;
                    gbDatosP.Enabled = true;
                    dgvProductos.Enabled = true;
                    break;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto formBuscarP = new frmBuscarProducto();
            if (formBuscarP.ShowDialog() == DialogResult.OK)
            {
                producto = formBuscarP.ProductoSeleccionado;
                txtCodigoP.Text = producto.idProducto.ToString();
                txtNombreP.Text = producto.nombre;
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObj = Estado.Nuevo;
            estadoComponentes(estadoObj);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estadoObj == Estado.Nuevo)
            {
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + (cbMes.SelectedIndex + 1) + "-01");
                proyeccionVenta.periodoSpecified = true;
                proyeccionVenta.proyecciones = lineas.ToArray();
                DBController.insertarProyeccionVenta(proyeccionVenta);
                foreach (Service.lineaProyeccion l in lineas)
                {
                    DBController.insertarLineaProyeccion(l, proyeccionVenta.id);
                }
                MessageBox.Show("Proyección Registrada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (estadoObj == Estado.Modificar)
            {
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + (cbMes.SelectedIndex+1) + "-01");
                proyeccionVenta.proyecciones = lineas.ToArray();
                DBController.actualizarProyeccionVenta(proyeccionVenta);
                foreach (Service.lineaProyeccion l in lineas)
                {
                    DBController.eliminarLineaProyeccion(l.id);
                    DBController.insertarLineaProyeccion(l, proyeccionVenta.id);
                }
                if (flagElim == 1)
                {
                    foreach (Service.lineaProyeccion l in lineasEliminadas)
                    {
                        DBController.eliminarLineaProyeccion(l.id);
                    }
                }
                MessageBox.Show("Proyección Actualizada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(estadoObj);
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            lineaProyeccion.producto = producto;
            lineaProyeccion.cantidad = int.Parse(txtCantidadP.Text);
            BindingList<Service.lineaProyeccion> lineasAg = new BindingList<Service.lineaProyeccion>();
            foreach (Service.lineaProyeccion item in lineas)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(lineaProyeccion);
            lineas = lineasAg;
            dgvProductos.DataSource = lineas;
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            string str = dgvProductos.Rows[dgvProductos.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.lineaProyeccion> lineasElim = new BindingList<Service.lineaProyeccion>();
            foreach (Service.lineaProyeccion item in lineas)
            {
                if (item.producto.nombre != str) lineasElim.Add(item);
                if (estadoObj == Estado.Modificar && item.producto.nombre == str)
                {
                    lineasEliminadas.Add(item);
                    flagElim = 1;
                }
            }
            lineas = lineasElim;
            dgvProductos.DataSource = lineas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProyeccionVenta formProd = new frmBuscarProyeccionVenta();
            if (formProd.ShowDialog() == DialogResult.OK)
            {
                proyeccionVenta = formProd.ProyeccionSeleccionada;
                txtNOrden.Text = proyeccionVenta.id.ToString();
                string anio = proyeccionVenta.periodo.ToString("yyyy");
                cbAnio.SelectedIndex = cbAnio.FindStringExact(anio);
                string mes = seleccionarMes(proyeccionVenta.periodo.AddDays(1).ToString("MM"));
                cbMes.SelectedIndex = cbMes.FindStringExact(mes);
                Service.lineaProyeccion[] l = DBController.listarLineaProyeccion(proyeccionVenta.id);
                if (l != null)
                {
                    lineas = new BindingList<Service.lineaProyeccion>(l);
                    dgvProductos.DataSource = lineas;
                }
                estadoObj = Estado.Buscar;
                estadoComponentes(estadoObj);
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaProyeccion pFila = (Service.lineaProyeccion)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
            dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Style.ForeColor = System.Drawing.Color.Black;
            dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value = pFila.producto.idProducto;
            dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value = pFila.producto.nombre;
            dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = pFila.cantidad;
        }

        private string seleccionarMes(string v)
        {
            switch (v)
            {
                case ("01"):
                    return "Enero";
                case ("02"):
                    return "Febrero";
                case ("03"):
                    return "Marzo";
                case ("04"):
                    return "Abril";
                case ("05"):
                    return "Mayo";
                case ("06"):
                    return "Junio";
                case ("07"):
                    return "Julio";
                case ("08"):
                    return "Agosto";
                case ("09"):
                    return "Setiembre";
                case ("10"):
                    return "Octubre";
                case ("11"):
                    return "Noviembre";
                case ("12"):
                    return "Diciembre";
                default:
                    return "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(estadoObj);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(estadoObj);
        }
    }
}
