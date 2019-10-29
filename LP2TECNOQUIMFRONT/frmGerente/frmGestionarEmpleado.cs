using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmGerente
{
    public partial class frmGestionarEmpleado : Form
    {
        public frmGestionarEmpleado()
        {
            InitializeComponent();
        }

        private void frmGestionarEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado formBuscarEmpleado = new frmBuscarEmpleado();
            formBuscarEmpleado.Visible = true;
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil();
            formPerfil.Visible = true;
            this.Close();
        }

        private void btnGestionarPlanM_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGestionarPlanM = new frmGerente();
            formGestionarPlanM.Visible = true;
            this.Close();
        }
    }
}
