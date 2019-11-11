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
        Service.planMaestroProduccion pmp = new Service.planMaestroProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.trabajador trabajador;
        Service.mensaje mensaje = new Service.mensaje();
        int cont;
        Estado estadoObj;

        public frmGestionarPlanMaestro(int cont=0)
        {
            BindingList<Service.planMaestroProduccion> pmps = new BindingList<Service.planMaestroProduccion>();
            if (cont == 1)
            {
                pmps = new BindingList<Service.planMaestroProduccion>(DBController.listarPMP("2019-01-01"));
            }
            InitializeComponent();
            pmp = pmps[0];
            txtCodigo.Text = pmp.id.ToString();
            txtPeriodo.Text = pmp.periodo.ToString("yyyy - MM - dd");
            txtComentario.Text = pmp.estado.ToString();
            if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
            else rbAprobado.Checked = true;
            txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
            estadoComponentes(Estado.Buscar);
        }

        public frmGestionarPlanMaestro(Service.trabajador gerente)
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            trabajador = gerente;
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    break;
                case Estado.Buscar:
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    gbEstado.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtCodigo.Text = "";
            txtPeriodo.Text = "";
            txtResponsable.Text = "";
            txtComentario.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbAprobado.Checked)
            {
                pmp.estado = Service.estado.Aprobado;
                mensaje.descripcion = "PLAN MAESTRO APROBADO. " + txtComentario;
            }
            else if (rbDesaprobado.Checked)
            {
                pmp.estado = Service.estado.Rechazado;
                mensaje.descripcion = "PLAN MAESTRO RECHAZADO. " + txtComentario;
            }
            DBController.actualizarPMP(pmp);

            mensaje.emisor = trabajador;
            mensaje.fechaEnvio = DateTime.Now;
            mensaje.receptor = pmp.responsable;
            DBController.insertarMensaje(mensaje);
            MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPlanMaestro formBuscarPlan = new frmBuscarPlanMaestro();
            if (formBuscarPlan.ShowDialog() == DialogResult.OK)
            {
                pmp = formBuscarPlan.PmpSeleccionado;
                txtCodigo.Text = pmp.id.ToString();
                txtPeriodo.Text = pmp.periodo.ToString("yyyy - MM - dd");
                txtComentario.Text = pmp.estado.ToString();
                if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
                else rbAprobado.Checked = true;
                txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }
    }
}
