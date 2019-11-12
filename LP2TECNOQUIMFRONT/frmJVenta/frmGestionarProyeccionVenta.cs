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
                    btnBuscar.Enabled = false;
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
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estadoObj == Estado.Nuevo)
            {
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + cbMes.SelectedValue + "-01");
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
                proyeccionVenta.periodo = DateTime.Parse(cbAnio.SelectedValue + "-" + cbMes.SelectedValue + "-01");
                proyeccionVenta.proyecciones = lineas.ToArray();
                DBController.actualizarProyeccionVenta(proyeccionVenta);
                foreach (Service.lineaProyeccion l in lineas)
                {
                    DBController.eliminarLineaInsumo(l.id);
                    DBController.insertarLineaProyeccion(l, proyeccionVenta.id);
                }
                if (flagElim == 1)
                {
                    foreach (Service.lineaProyeccion l in lineasEliminadas)
                    {
                        DBController.eliminarLineaInsumo(l.id);
                    }
                }
                MessageBox.Show("Proyección Actualizada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            lineaProyeccion.producto = producto;
            lineaProyeccion.cantidad = int.Parse(txtCantidadP.Text);
            lineas.Add(lineaProyeccion);
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
    }
}
