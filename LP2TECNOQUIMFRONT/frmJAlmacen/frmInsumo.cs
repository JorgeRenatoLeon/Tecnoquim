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
        Estado estadoObj;
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmInsumo()
        {
            InitializeComponent();
            insumo = new Service.insumo();
            BindingList<string> unidades = new BindingList<string>();
            unidades.Add("'SELECCIONAR UNA UNIDAD'");
            unidades.Add("GR");
            unidades.Add("ML");
            unidades.Add("KG");
            unidades.Add("L");
            cbUnidades.DataSource = unidades;
            cbUnidades.DisplayMember = cbUnidades.SelectedText;
            cbUnidades.ValueMember = cbUnidades.SelectedText;
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
                    txtColor.Enabled = false;
                    rbSi.Enabled = false;
                    rbNo.Enabled = false;
                    cbUnidades.SelectedText = "";
                    cbUnidades.Enabled = false;
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
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtCant.Enabled = true;
                    txtGranu.Enabled = true;
                    txtColor.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    cbUnidades.SelectedText = "";
                    cbUnidades.Enabled = true;
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
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtCant.Enabled = true;
                    txtGranu.Enabled = true;
                    txtColor.Enabled = true;
                    rbSi.Enabled = true;
                    rbNo.Enabled = true;
                    cbUnidades.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCant.Text = "";
            txtGranu.Text = "";
            txtColor.Text = "";
            rbSi.Checked = false;
            rbNo.Checked = false;
            cbUnidades.SelectedText = "'SELECCIONAR UNA UNIDAD'";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
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
            float gran;
            int cant;
            if(txtNombre.Text == "")
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
            if (txtGranu.Text == "")
            {
                MessageBox.Show("No se ha ingresado la Granularidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(float.TryParse(txtGranu.Text,out float granu) && float.Parse(txtGranu.Text) >= 0 && float.Parse(txtGranu.Text) <= 5.0)
            {
                gran = granu;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número del 0 al 5 para la Granularidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtColor.Text == "")
            {
                MessageBox.Show("No se ha ingresado el color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbUnidades.SelectedItem.ToString()== "'SELECCIONAR UNA UNIDAD'")
            {
                MessageBox.Show("No se ha seleccionado su unidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            insumo = new Service.insumo();
            insumo.nombre = txtNombre.Text;
            insumo.cantidad = cant;
            insumo.unidad = cbUnidades.SelectedItem.ToString();
            insumo.granularidad = gran;
            insumo.color = txtColor.Text;
            
            if (rbSi.Checked == true)
            {
                insumo.restriccion = true;
            }
            else if(rbNo.Checked == true)
            {
                insumo.restriccion = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado si es Restringido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                cbUnidades.SelectedText= insumo.unidad;
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
            if (txtCodigo.Text != "")
            {
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ningun Insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
