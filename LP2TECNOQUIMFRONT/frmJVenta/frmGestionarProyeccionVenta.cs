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
        Service.proyeccionVenta proyeccionVenta;
        Service.producto producto;
        BindingList<Service.lineaProyeccion> lineas;
        Estado estadoObj;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmGestionarProyeccionVenta()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
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

            estadoComponentes(estadoObj);
        }
        public void limpiarComponentes()
        {
            txtCodigoP.Text = "";
            txtNombreP.Text = "";
            txtCantidadP.Text = "";
            txtNOrden.Text = "";
            lineas = new BindingList<Service.lineaProyeccion>();
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
            producto = new Service.producto();
            proyeccionVenta = new Service.proyeccionVenta();
            lineas = new BindingList<Service.lineaProyeccion>();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = lineas;
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            Service.lineaProyeccion lp = new Service.lineaProyeccion();
            lp.producto = producto;
            lp.cantidad = int.Parse(txtCantidadP.Text);
            lineas.Add(lp);
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (lineas.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado una linea a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Service.lineaProyeccion linea = (Service.lineaProyeccion)dgvProductos.CurrentRow.DataBoundItem;
            lineas.Remove(linea);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProyeccionVenta formProy = new frmBuscarProyeccionVenta();
            if (formProy.ShowDialog() == DialogResult.OK)
            {
                proyeccionVenta = formProy.ProyeccionSeleccionada;
                txtNOrden.Text = proyeccionVenta.id.ToString();
                string anio = proyeccionVenta.periodo.AddHours(5).ToString("yyyy");
                cbAnio.SelectedIndex = cbAnio.FindStringExact(anio);
                string mes = seleccionarMes(proyeccionVenta.periodo.AddHours(5).ToString("MM"));
                cbMes.SelectedIndex = cbMes.FindStringExact(mes);
                if (proyeccionVenta.proyecciones != null)
                {
                    lineas = new BindingList<Service.lineaProyeccion>(proyeccionVenta.proyecciones.ToList());
                }
                else
                {
                    lineas = new BindingList<Service.lineaProyeccion>();
                }
                dgvProductos.AutoGenerateColumns = false;
                dgvProductos.DataSource = lineas;
                estadoObj = Estado.Buscar;
                estadoComponentes(estadoObj);
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                Service.lineaProyeccion pFila = (Service.lineaProyeccion)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Style.ForeColor = System.Drawing.Color.Black;
                dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Style.ForeColor = System.Drawing.Color.Black;
                dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
                dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value = pFila.producto.idProducto;
                dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value = pFila.producto.nombre;
                dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value = pFila.cantidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(estadoObj);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (estadoObj == Estado.Nuevo)
            {
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + (cbMes.SelectedIndex + 1) + "-01");
                proyeccionVenta.periodoSpecified = true;
                proyeccionVenta.proyecciones = lineas.ToArray();
                DBController.insertarProyeccionVenta(proyeccionVenta);
                MessageBox.Show("Proyección Registrada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (estadoObj == Estado.Modificar)
            {
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + (cbMes.SelectedIndex + 1) + "-01");
                proyeccionVenta.proyecciones = lineas.ToArray();
                DBController.actualizarProyeccionVenta(proyeccionVenta);
                MessageBox.Show("Proyección Actualizada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(estadoObj);

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(estadoObj);
        }
    }
}
