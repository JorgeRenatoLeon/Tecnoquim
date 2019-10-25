using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJMaquinaria
{
    public partial class frmGestionarMaquinaria : Form
    {
        Service.maquinaria maquinaria = new Service.maquinaria();
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmGestionarMaquinaria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            maquinaria.nombre = txtNombre.Text;
            maquinaria.tipo = txtTipo.Text;
            if (rbActivo.Checked == true)
            {
                maquinaria.activo = 1;
            }
            else
                maquinaria.activo = 0;

            DBController.insertarMaquinaria(maquinaria);
        }
         
    }
}
