using LP2TECNOQUIMFRONT.frmJAlmacen;
using LP2TECNOQUIMFRONT.frmJControlCalidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace LP2TECNOQUIMFRONT.frmPrincipal
{
    public partial class frmLogin : Form
    {
        private Service.trabajador trabajador = new Service.trabajador();
        private Service.ServicioClient DBController = new Service.ServicioClient();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtUsuario.Text != "Usuario") txtUsuario.ForeColor = Color.Black;
            if (txtContrasena.Text != "Contrasena") txtContrasena.ForeColor = Color.Black;
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                txtContrasena.BackColor = Color.White;
                txtUsuario.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (trabajador==null)
            {
                trabajador = new Service.trabajador();
            }
            if(this.txtUsuario.Text != "Usuario" && this.txtUsuario.Text != ""){
                if (this.txtContrasena.Text != "Contrasena" && this.txtContrasena.Text != "")
                {
                    trabajador.usuario = new Service.usuario();
                    trabajador.usuario.username = this.txtUsuario.Text;
                    trabajador.usuario.password = this.txtContrasena.Text;
                    trabajador = DBController.verificarUsuario(trabajador.usuario);
                    if (trabajador != null)
                    {
                        if (trabajador.rol.descripcion == "GERENTE GENERAL")
                        {
                            frmGerente.frmGerente formGerente = new frmGerente.frmGerente(0, trabajador);
                            formGerente.Visible = true;
                        }
                        else if (trabajador.rol.descripcion == "JEFE DE PRODUCCION")
                        {
                            frmJproduccion.frmJProduccion formJProduccion = new frmJproduccion.frmJProduccion(0, trabajador);
                            formJProduccion.Visible = true;
                        }
                        else if (trabajador.rol.descripcion == "JEFE DE ALMACEN")
                        {
                            frmAlmacen formAlmacen = new frmAlmacen(0, trabajador);
                            formAlmacen.Visible = true;
                        }
                        else if (trabajador.rol.descripcion == "JEFE DE CONTROL DE CALIDAD")
                        {
                            frmControlCalidad formControlCalidad = new frmControlCalidad(0, trabajador);
                            formControlCalidad.Visible = true;
                        }
                        else if (trabajador.rol.descripcion == "JEFE DE MANTENIMIENTO")
                        {
                            frmJMaquinaria.frmJMaquinaria formMaq = new frmJMaquinaria.frmJMaquinaria(0, trabajador);
                            formMaq.Visible = true;
                        }
                        else if (trabajador.rol.descripcion == "JEFE DE VENTA")
                        {
                            frmJVenta.frmJVenta formVenta = new frmJVenta.frmJVenta(0, trabajador);
                            formVenta.Visible = true;
                        }
                    }
                    else
                    {
                        txtError.Text = "Datos de Ingreso Incorrectos";
                        this.Visible = true;
                    }
                }
                else
                {
                    txtContrasena.ForeColor = Color.Red;
                    txtContrasena.BackColor = Color.Orange;
                    txtError.Text = "Ingrese su contraseña";
                    this.Visible = true;
                }
            }
            else
            {
                txtUsuario.ForeColor = Color.Red;
                txtUsuario.BackColor = Color.Orange;
                txtError.Text = "Ingresa tu usuario";
                this.Visible = true;
            }
        }

        private void txtUsuarioEnter(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "Usuario")
            {
                this.txtUsuario.Text = "";
            }
        }

        private void txtContrasenaEnter(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (this.txtContrasena.Text != "")
            {
                this.txtContrasena.Text = "";
            }
        }

        private void txtContrasenaLeave(object sender, EventArgs e)
        {
            if (this.txtContrasena.Text == "")
            {
                this.txtContrasena.Text = "Contrasena";
                this.txtContrasena.ForeColor = Color.Silver;
                this.txtContrasena.BackColor = Color.White;
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblOlvidoContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtError.Text = "";
            frmRecuperarContrasenha frm = new frmRecuperarContrasenha(this.trabajador);
            frm.ShowDialog(this);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.txtUsuario.Text = "Usuario";
                this.txtUsuario.ForeColor = Color.Silver;
                this.txtUsuario.BackColor = Color.White;
            }
        }
    }
}
