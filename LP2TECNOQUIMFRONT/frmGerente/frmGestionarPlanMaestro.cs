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
    public partial class frmGestionarPlanMaestro : Form
    {
        public frmGestionarPlanMaestro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPlanMaestro formBuscarPlanM = new frmBuscarPlanMaestro();
            formBuscarPlanM.Visible = true;
        }
    }
}
