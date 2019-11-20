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
        Service.proyeccionVenta proyeccionVenta = new Service.proyeccionVenta();
        Service.producto producto;
        BindingList<Service.lineaProyeccion> lineas;
        Estado estadoObj;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmGestionarProyeccionVenta(Service.proyeccionVenta thispv, bool save)
        {
            InitializeComponent();
            proyeccionVenta = thispv;
            estadoObj = Estado.Inicial;
            txtNOrden.Text = proyeccionVenta.id.ToString();
            txtPeriodo.Text = proyeccionVenta.periodo.AddHours(5).ToString("MMMM, yyyy");
            proyeccionVenta.proyecciones = DBController.listarLineaProyeccion(proyeccionVenta.id);
            if (proyeccionVenta.proyecciones != null)
            {
                lineas = new BindingList<Service.lineaProyeccion>(proyeccionVenta.proyecciones.ToList());
            }
            else
            {
                lineas = new BindingList<Service.lineaProyeccion>();
            }
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = lineas; gbDatosP.Enabled = false;
            gbDatosP.Enabled = true;

            if (!save)
            {
                gbDatosP.Enabled = false;
                btnGuardar.Visible = false;
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proyeccionVenta.proyecciones = lineas.ToArray();
            DBController.actualizarProyeccionVenta(proyeccionVenta);
            MessageBox.Show("Proyección Actualizada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
