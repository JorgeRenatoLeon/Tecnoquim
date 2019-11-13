using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmGestionarPlan : Form
    {

        Service.ServicioClient DBController = new Service.ServicioClient();
        BindingList<Service.maquinaria> maquinarias;
        BindingList<Service.ordenProduccion> ordenes;
        private Service.planMaestroProduccion _pmp;

        public planMaestroProduccion PMP { get => _pmp; set => _pmp = value; }

        public frmGestionarPlan()
        {
            InitializeComponent();
            PMP = new planMaestroProduccion();
            maquinarias = new BindingList<maquinaria>();
            ordenes = new BindingList<ordenProduccion>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarOrden formGestionarOrden = new frmGestionarOrden();
            formGestionarOrden.ShowDialog(this);
            PMP.ordenes[formGestionarOrden.OrderProduccion.fecha.Day] = formGestionarOrden.OrderProduccion;

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _pmp = new Service.planMaestroProduccion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void calOrdenProduccion_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHistorialPMP form = new frmHistorialPMP();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PMP = form.PMPSeleccionado;
                txtNOrden.Text = PMP.id.ToString();
                Service.maquinaria[] lm = PMP.maquinarias;
                Service.ordenProduccion[] lo = PMP.ordenes;
                if (lm != null)
                {
                    maquinarias = new BindingList<maquinaria>(lm);
                    dgvMaquinaria.DataSource = maquinarias;
                }
                if (lo != null)
                {
                    ordenes = new BindingList<ordenProduccion>(lo);
                }
                //estadoFormulario = Estado.Buscar;
                //estadoComponentes(Estado.Buscar);
            }
        }
    }
}
