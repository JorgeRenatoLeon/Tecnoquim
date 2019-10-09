using LP2TECNOQUIMFRONT.frmJAlmacen;
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

namespace LP2TECNOQUIMFRONT
{
    public partial class frmLogin : Form
    {
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
                    if (this.txtUsuario.Text == "admin")
                    {
                        if (this.txtContrasena.Text == "1234")
                        {
                            frmGerente formGerente = new frmGerente();
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
                            frmJProduccion formJProduccion = new frmJProduccion();
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
                            frmAlmacen formAlmacen = new frmAlmacen();
                            formAlmacen.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                            this.Visible = true;
                        }
                    }
                    else
                    {
                        frmHome formHome = new frmHome();
                        formHome.Visible = true;
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
