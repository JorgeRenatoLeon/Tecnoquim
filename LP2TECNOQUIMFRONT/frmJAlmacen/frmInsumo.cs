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
    public partial class frmInsumo : Form
    {
        Service.insumo insumo;
        Service.detalleAlmacenInsumo detalle;
        Estado estadoObj;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmInsumo()
        {
            InitializeComponent();
            insumo = new Service.insumo();
            detalle = new Service.detalleAlmacenInsumo();
            estadoObj = Estado.Inicial;
            estadoComponentes(Estado.Inicial);
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblCodigo.Enabled = false;
                    lblNombre.Enabled = false;
                    lblCant.Enabled = false;
                    lblUnidad.Enabled = false;
                    lblGranu.Enabled = false;
                    lblColor.Enabled = false;
                    lblRestriccion.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtCant.Enabled = false;
                    txtGranu.Enabled = false;
                    txtUnidad.Enabled = false;
                    txtColor.Enabled = false;
                    rbSi.Enabled = false;
                    rbNo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblCodigo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblCant.Enabled = true;
                    lblUnidad.Enabled = true;
                    lblGranu.Enabled = true;
                    lblColor.Enabled = true;
                    lblRestriccion.Enabled = true;

                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombre.Enabled = true;
                    txtCant.Enabled = true;
                    txtGranu.Enabled = true;
                    txtUnidad.Enabled = true;
                    txtColor.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    lblCodigo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblCant.Enabled = true;
                    lblUnidad.Enabled = true;
                    lblGranu.Enabled = true;
                    lblColor.Enabled = true;
                    lblRestriccion.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = true;
                    txtNombre.Enabled = true;
                    txtCant.Enabled = true;
                    txtGranu.Enabled = true;
                    txtUnidad.Enabled = true;
                    txtColor.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCant.Text = "";
            txtGranu.Text = "";
            txtUnidad.Text = "";
            txtColor.Text = "";
            rbSi.Checked = false;
            rbNo.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            detalle = new Service.detalleAlmacenInsumo();
            insumo = new Service.insumo();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insumo = new Service.insumo();
            insumo.nombre = txtNombre.Text;
            insumo.cantidad = int.Parse(txtCant.Text);
            insumo.unidad = txtUnidad.Text;
            insumo.granularidad = float.Parse(txtGranu.Text);
            insumo.color = txtColor.Text;

            detalle.stock = 0;
            if (rbSi.Checked == true)
            {
                insumo.restriccion = true;
            }
            else
            {
                insumo.restriccion = false;
            }
            if (estadoObj == Estado.Nuevo)
            {
                int idInsumo=DBController.insertarInsumo(insumo);

                MessageBox.Show("Insumo Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObj == Estado.Modificar)
            {
                insumo.id = int.Parse(txtCodigo.Text);
                DBController.actualizarInsumo(insumo);

                MessageBox.Show("Insumo Actualizado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {

                insumo = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = insumo.id.ToString();
                txtNombre.Text = insumo.nombre;
                txtCant.Text = insumo.cantidad.ToString();
                txtUnidad.Text = insumo.unidad.ToString();
                txtGranu.Text = insumo.granularidad.ToString();
                txtColor.Text = insumo.color;
                if (insumo.restriccion)
                {
                    rbSi.Checked=true;
                }
                else
                {
                    rbNo.Checked = false;
                }
            }
            estadoComponentes(Estado.Buscar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBController.eliminarInsumo(int.Parse(txtCodigo.Text));
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(Estado.Inicial);
            MessageBox.Show("Insumo Eliminado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
