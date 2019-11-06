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
            formOrdenes.Visible = true;
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
            frmMaquinaria form = new frmMaquinaria();
            form.Visible = true;
        }

        private void frmGestionarPlan_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
