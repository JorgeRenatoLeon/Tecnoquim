using LP2TECNOQUIMFRONT.frmJproduccion;
using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJMaquinaria
{
    public partial class frmJMaquinaria : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.maquinaria maquinaria;
        Service.detalleMaquinaria detalle;
        Service.ServicioClient DBController = new Service.ServicioClient();
        Estado estadoObj;

        int close;
        public frmJMaquinaria(int cont = 0, Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            if (cont != 0)
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));
                t.Start();
                Thread.Sleep(1250);
                InitializeComponent();

                MessageBox.Show("Bienvenido/a " + trabajador.nombres + " " + trabajador.apellidos);

                t.Abort();
            }
            estadoComponentes(Estado.Inicial);
            
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }
        

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formNot = new frmPerfil(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }


        private void frmJMaquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaquinaria formRegistro = new frmMaquinaria();
            formRegistro.Visible = true;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmMaquinaria formMaquinaria = new frmMaquinaria();
            if (formMaquinaria.ShowDialog(this) == DialogResult.OK)
            {
                maquinaria = formMaquinaria.MaquinariaSeleccionada;
                txtNOrden.Text = maquinaria.id.ToString();
                txtNombre.Text= maquinaria.nombre;
                txtTipo.Text=maquinaria.tipo;

                if (maquinaria.estado == true)
                {
                    rbActivo.Checked = true;
                }
                else
                {
                    rbInactivo.Checked = true;
                }
            }
            estadoComponentes(Estado.Buscar);
        }
        
        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            maquinaria = new Service.maquinaria();
            maquinaria.nombre = txtNombre.Text;
            maquinaria.tipo = txtTipo.Text;
            if (rbActivo.Enabled == true)
            {
                maquinaria.estado = true;
            }
            else
            {
                maquinaria.estado = false;
            }
            if (estadoObj == Estado.Nuevo)
            {
                int idMaq=DBController.insertarMaquinaria(maquinaria);
                MessageBox.Show("Maquinaria Registrada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObj == Estado.Modificar) 
            {
                maquinaria.id =int.Parse(txtNOrden.Text);
                DBController.actualizarMaquinaria(maquinaria);
                MessageBox.Show("Maquinaria Actualizada Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            maquinaria = new Service.maquinaria();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
            
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblCodigo.Enabled = false;
                    lblNombre.Enabled = false;
                    lblTipo.Enabled = false;
                    lblEstado.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtNOrden.Enabled = false;
                    txtNombre.Enabled = false;
                    txtTipo.Enabled = false;
                    rbActivo.Enabled = false;
                    rbInactivo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblCodigo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblTipo.Enabled = true;
                    lblEstado.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNOrden.Enabled = true;
                    txtNombre.Enabled = true;
                    txtTipo.Enabled = true;
                    rbActivo.Enabled = true;
                    rbInactivo.Enabled = true;
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
                    lblCodigo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblTipo.Enabled = true;
                    lblEstado.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNOrden.Enabled = true;
                    txtNombre.Enabled = true;
                    txtTipo.Enabled = true;
                    rbActivo.Enabled = true;
                    rbInactivo.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNOrden.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }


        
    }
}
