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
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlmacen formInicio = new frmAlmacen();
            formInicio.Visible = true;
            this.Close();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }
    }
}
