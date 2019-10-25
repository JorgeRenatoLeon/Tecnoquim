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

namespace LP2TECNOQUIMFRONT.frmPrincipal
{
    public partial class frmLogin : Form
    {
        //private Service.usuario usuario;
        //Service.ServicioClient DBController = new Service.ServicioClient();
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
            if(this.txtUsuario.Text != "Usuario" && this.txtUsuario.Text != ""){
                if (this.txtContrasena.Text != "Contrasena" && this.txtContrasena.Text != "")
                {
                    //usuario.idUsuario = Int32.Parse(this.txtUsuario.Text);
                    //usuario.password = this.txtContrasena.Text;
                    //DBController.verificarUsuario(usuario);
                    if (this.txtUsuario.Text == "admin")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmGerente.frmGerente formGerente = new frmGerente.frmGerente(0,this.txtUsuario.Text);
                            formGerente.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else if (this.txtUsuario.Text == "prod")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmJproduccion.frmJProduccion formJProduccion = new frmJproduccion.frmJProduccion(0, this.txtUsuario.Text);
                            formJProduccion.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else if (this.txtUsuario.Text == "almacen")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmAlmacen formAlmacen = new frmAlmacen(0, this.txtUsuario.Text);
                            formAlmacen.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else if (this.txtUsuario.Text == "calidad")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmControlCalidad formAlmacen = new frmControlCalidad(0, this.txtUsuario.Text);
                            formAlmacen.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else if (this.txtUsuario.Text == "maquinaria")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmJMaquinaria.frmJMaquinaria formMaq = new frmJMaquinaria.frmJMaquinaria(0, this.txtUsuario.Text);
                            formMaq.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else if (this.txtUsuario.Text == "venta")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmJVenta.frmJVenta formVenta = new frmJVenta.frmJVenta(0, this.txtUsuario.Text);
                            formVenta.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto");
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
    }
}
