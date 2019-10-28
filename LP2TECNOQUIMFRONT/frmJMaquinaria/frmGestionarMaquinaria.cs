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
            BindingList<Service.maquinaria> maquinarias =
                new BindingList<Service.maquinaria>(DBController.listarMaquinaria());

            dgvMaquinaria.DataSource = DBController.listarMaquinaria();
        }
        

        
    }
}
