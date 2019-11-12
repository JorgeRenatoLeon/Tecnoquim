using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmOrden : Form
    {
        int close = 0;
        public frmOrden()
        {
            InitializeComponent();
        }        

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formGestionarOrden = new frmGestionarOrden();
            formGestionarOrden.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmHistorialOrden form = new frmHistorialOrden();
            form.ShowDialog(this);
        }

        private void frmOrden_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
