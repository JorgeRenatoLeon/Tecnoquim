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
    public partial class frmRevisarPlanMaestro : Form
    {
        Service.planMaestroProduccion pmp = new Service.planMaestroProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.trabajador trabajador;
        Service.mensaje mensaje = new Service.mensaje();
        Estado estadoObj;

        public frmRevisarPlanMaestro(Service.planMaestroProduccion pmp)
        {
            InitializeComponent();
            txtCodigo.Text = pmp.id.ToString();
            txtPeriodo.Text = pmp.periodo.ToString("MMMM , yyyy");
            txtComentario.Text = pmp.estado.ToString();
            if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
            else rbAprobado.Checked = true;
            txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
            estadoObj = Estado.Inicial;
        }

        public frmRevisarPlanMaestro(Service.trabajador gerente)
        {
            InitializeComponent();
            trabajador = gerente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbAprobado.Checked)
            {
                pmp.estado = Service.estado.Aprobado;
                mensaje.descripcion = "PLAN MAESTRO APROBADO. " + txtComentario.Text;
            }
            else if (rbDesaprobado.Checked)
            {
                pmp.estado = Service.estado.Rechazado;
                mensaje.descripcion = "PLAN MAESTRO RECHAZADO. " + txtComentario.Text;
            }
            DBController.actualizarPMP(pmp);

            mensaje.emisor = trabajador;
            mensaje.fechaEnvio = DateTime.Now;
            mensaje.receptor = pmp.responsable;
            DBController.insertarMensaje(mensaje);
            MessageBox.Show("Se han actualizado los datos", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {   /*
            txtCodigo.Text = pmp.id.ToString();
            txtPeriodo.Text = pmp.periodo.ToString("yyyy - MM - dd");
            txtComentario.Text = pmp.estado.ToString();
            if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
            else rbAprobado.Checked = true;
            txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
            */
            if (rbAprobado.Checked)
            {
                pmp.estado = Service.estado.Aprobado;
                mensaje.descripcion = "PLAN MAESTRO APROBADO. " + txtComentario.Text;
            }
            else if (rbDesaprobado.Checked)
            {
                pmp.estado = Service.estado.Rechazado;
                mensaje.descripcion = "PLAN MAESTRO RECHAZADO. " + txtComentario.Text;
            }
            DBController.actualizarPMP(pmp);

            mensaje.emisor = trabajador;
            mensaje.fechaEnvio = DateTime.Now;
            mensaje.receptor = pmp.responsable;
            DBController.insertarMensaje(mensaje);
            MessageBox.Show("Se ha actualizado correctamente el plan de maestro de producción", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
