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
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace LP2TECNOQUIMFRONT.frmPrincipal
{
    public partial class frmLogin : Form
    {
        private Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();
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
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
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
                        MessageBox.Show("Datos de Ingreso Incorrectos");
                        this.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa una contraseña");
                    this.Visible = true;
                }
            }
            else {
                MessageBox.Show("Ingresa tu usuario");
                this.Visible = true;
            }
        }

        private void txtUsuarioEnter(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "Usuario")
            {
                this.txtUsuario.Text = "";
                this.txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuarioLeave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.txtUsuario.Text = "Usuario";
                this.txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContrasenaEnter(object sender, EventArgs e)
        {
            if (this.txtContrasena.Text != "")
            {
                this.txtContrasena.Text = "";
                this.txtContrasena.ForeColor = Color.Black;
            }
        }

        private void txtContrasenaLeave(object sender, EventArgs e)
        {
            if (this.txtContrasena.Text == "")
            {
                this.txtContrasena.Text = "Contrasena";
                this.txtContrasena.ForeColor = Color.Silver;
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

            if (this.txtUsuario.Text != "Usuario" && this.txtUsuario.Text != "")
            {
                bool count = false;
                BindingList<Service.trabajador> binding = new BindingList<Service.trabajador>(DBController.listarTrabajadores("%"));
                for (int i = 0; i < binding.Count; i++)
                {
                    if (binding[i].usuario.username == txtUsuario.Text)
                    {
                        trabajador = binding[i];
                        count = true;
                        break;
                    }
                }
                if (count)
                {
                    sendpassword(trabajador.usuario.password, trabajador.correo);
                    MessageBox.Show("Se envió tu contraseña al correo registrado. Verifica tu bandeja de correo");

                }
                else
                {
                    MessageBox.Show("Datos Inválidos");

                }
            }
            else
            {
                MessageBox.Show("Ingresa tu usuario para enviar la contraseña");
            }
        }
        private void sendpassword(String password, String email)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("soporte.tecnoquim@gmail.com", "tecnoquim1234");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Olvido Contraseña ( TECNOQUIM )";
            msg.Body = "Querido/a " + trabajador.nombres+" "+trabajador.apellidos + ",\nTu Contraseña es  " + password + "\n\n\nSaludos Cordiales,\n\nEquipo Tecnoquim";
            string toaddress = email;
            msg.To.Add(toaddress);
            string fromaddress = "TECNOQUIM <soporte.tecnoquim@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }
        
    }
}
