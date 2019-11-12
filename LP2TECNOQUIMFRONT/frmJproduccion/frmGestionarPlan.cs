using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmGestionarPlan : Form
    {
        public frmGestionarPlan()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOrdenes formOrdenes = new frmOrdenes();
            formOrdenes.ShowDialog(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPMS form = new frmPMS();
            form.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service.maquinaria maquinaria = new Service.maquinaria();
            frmMaquinaria form = new frmMaquinaria();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                maquinaria = form.MaquinariaSeleccionada;
                txtCodigo.Text = maquinaria.id.ToString();
                txtNombre.Text = maquinaria.nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
