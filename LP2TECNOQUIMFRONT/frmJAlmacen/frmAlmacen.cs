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

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmAlmacen : Form
    {
        public frmAlmacen(int cont = 0)
        {
            if (cont != 0)
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(2500);

                InitializeComponent();

                t.Abort();
            }
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.Visible = true;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProducto formProducto = new frmProducto();
            formProducto.Visible = true;
            this.Close();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmInsumo formInsumo = new frmInsumo();
            formInsumo.Visible = true;
            this.Close();
        }
    }
}
