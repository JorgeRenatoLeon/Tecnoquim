using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmGestionarEmpleado : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Estado estadoObj;

        public frmGestionarEmpleado()
        {
            InitializeComponent();

            BindingList<Service.rol> roles = new BindingList<Service.rol>(DBController.listarRoles(""));

            //Enlazamos el ComboBox con las especialidades obtenidas
            cbRol.DataSource = roles;

            //Indicamos la Propiedad que debería visualizarse
            cbRol.DisplayMember = "Descripcion";
            cbRol.ValueMember = "IdRol";
            estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnEliminar.Enabled = false;
                    gbDatosGen.Enabled = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = true;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = false;
                    gbDatosGen.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    gbDatosGen.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            trabajador.nombres = txtNombres.Text;
            trabajador.apellidos = txtApellidos.Text;
            trabajador.dni = txtDNI.Text;
            trabajador.correo = " ";

            trabajador.rol = (Service.rol)cbRol.SelectedItem;

            if (estadoObj == Estado.Nuevo)
            {
                Service.usuario usuario = new Service.usuario();
                usuario.username = "Aux";
                usuario.password = "1234";
                DBController.insertarUsuario(usuario);
                BindingList<Service.usuario> usuarios = new BindingList<Service.usuario>(DBController.listarUsuarios(usuario.username));

                usuario = usuarios[0];

                trabajador.usuario = usuario;

                DBController.insertarTrabajador(trabajador);
                MessageBox.Show("Empleado Registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObj == Estado.Modificar)
            {
                DBController.actualizarTrabajador(trabajador);
                MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este trabajador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarTrabajador(int.Parse(txtCodigo.Text));
                MessageBox.Show("Trabajador Eliminado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarComponentes();
                estadoObj = Estado.Inicial;
                estadoComponentes(Estado.Inicial);
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscarEmpleado formBuscarEmpleado = new frmBuscarEmpleado();
            if (formBuscarEmpleado.ShowDialog() == DialogResult.OK)
            {
                trabajador = formBuscarEmpleado.TrabajadorSeleccionado;
                txtCodigo.Text = trabajador.id.ToString();
                txtDNI.Text = trabajador.dni;
                txtNombres.Text = trabajador.nombres;
                txtApellidos.Text = trabajador.apellidos;
                cbRol.SelectedValue = trabajador.rol.idRol;
                estadoComponentes(Estado.Buscar);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            trabajador = new Service.trabajador();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }
    }
}
