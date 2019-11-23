using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmStockInsumo : Form
    {
        Estado estadoObj;
        Service.insumo insumo;
        Service.detalleAlmacenInsumo detalle;
        Service.almacen almacen;
        Service.detalleAlmacenInsumo almacenI;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStockInsumo()
        {
            InitializeComponent();
            BindingList<Service.almacen> almacens = new BindingList<Service.almacen>(DBController.listarAlmacen(""));
            cbAlmacen.DataSource = almacens;
            cbAlmacen.DisplayMember = "Tipo";
            txtCodigo.Enabled = false;
            txtCant.Enabled = false;
            txtNombre.Enabled = false;
            txtUnidad.Enabled = false;
            estadoComponentes(Estado.Inicial);
        }


        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    gbDatos.Enabled = false;
                    gbAlmacen.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    gbDatos.Enabled = true;
                    gbAlmacen.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    gbDatos.Enabled = true;
                    gbAlmacen.Enabled = true;
                    txtCodigo.Enabled = false;
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    gbDatos.Enabled = true;
                    gbAlmacen.Enabled = true;
                    txtCodigo.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCant.Text = "";
            txtLote.Text = "";
            txtStock.Text = "";
            cbAlmacen.Text = "";
            txtUnidad.Text = "";
        }

        

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {

                insumo = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = insumo.id.ToString();
                txtNombre.Text = insumo.nombre;
                txtCant.Text = insumo.cantidad.ToString();
                txtUnidad.Text = insumo.unidad;
            }
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            txtLote.Enabled = true;
            cbAlmacen.Enabled = true;
            frmStocksI formInsumos = new frmStocksI();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                detalle = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = detalle.insumo.id.ToString();
                txtNombre.Text = detalle.insumo.nombre;
                txtCant.Text = detalle.insumo.cantidad.ToString();
                txtUnidad.Text = detalle.insumo.unidad;
                txtLote.Text = detalle.nLote.ToString();
                txtStock.Text = detalle.stock.ToString();
                txtLote.Enabled = false;
                cbAlmacen.Enabled = false;
            }
            estadoComponentes(Estado.Nuevo);
            estadoObj = Estado.Buscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            detalle = new Service.detalleAlmacenInsumo();
            insumo = new Service.insumo();
            estadoComponentes(Estado.Nuevo);
            estadoObj = Estado.Nuevo;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            float gran;
            int cant;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No se ha ingresado el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCant.Text == "")
            {
                MessageBox.Show("No se ha ingresado la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtCant.Text, out int canti))
            {
                cant = canti;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            insumo = new Service.insumo();
            insumo.id = int.Parse(txtCodigo.Text);
            almacen = new Service.almacen();
            almacen.idAlmacen = 1;

            detalle.insumo = insumo;
            detalle.stock = int.Parse(txtStock.Text);
            detalle.nLote = int.Parse(txtLote.Text);
            detalle.almacen = almacen;
            detalle.periodoSpecified = true;
            detalle.periodo = DateTime.Today;

            if (estadoObj == Estado.Nuevo)
            {
                DBController.insertarDetalleAlmacenInsumo(detalle, int.Parse(txtCodigo.Text));
                MessageBox.Show("Insumo Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObj == Estado.Modificar)
            {
                insumo.id = int.Parse(txtCodigo.Text);
                DBController.actualizarDetalleAlmacenInsumo(detalle);

                MessageBox.Show("Insumo Actualizado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }
    }
}
