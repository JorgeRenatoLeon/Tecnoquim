using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJControlCalidad
{
    public partial class frmControlCalidad : Form
    {
        public frmControlCalidad()
        {
            InitializeComponent();
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
