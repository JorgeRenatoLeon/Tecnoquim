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
        Service.planMaestroProduccion first_pmp = new Service.planMaestroProduccion();
        Service.ServicioClient DBController = new Service.ServicioClient();
        Service.trabajador trabajador;
        Service.mensaje mensaje = new Service.mensaje();
        Estado estadoObj;

        public frmRevisarPlanMaestro(Service.planMaestroProduccion pmp)
        {
            InitializeComponent();
            first_pmp = pmp;
            txtCodigo.Text = pmp.id.ToString();
            txtPeriodo.Text = pmp.periodo.AddHours(5).ToString("MMMM , yyyy");
            txtComentario.Text = pmp.estado.ToString();
            if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
            else if (pmp.estado == Service.estado.Aprobado) rbAprobado.Checked = true;
            txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
            dgvOrden.DataSource = pmp.ordenes;
            dgvMaquinaria.DataSource = pmp.maquinarias;
            estadoObj = Estado.Inicial;
        }

        public frmRevisarPlanMaestro(Service.trabajador gerente)
        {
            InitializeComponent();
            trabajador = gerente;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {   
            if (rbAprobado.Checked)
            {
                first_pmp.estado = Service.estado.Aprobado;
                mensaje.descripcion = "PLAN MAESTRO APROBADO. " + txtComentario.Text;
            }
            else if (rbDesaprobado.Checked)
            {
                first_pmp.estado = Service.estado.Rechazado;
                mensaje.descripcion = "PLAN MAESTRO RECHAZADO. " + txtComentario.Text;
            }
            DBController.actualizarPMP(first_pmp);

            mensaje.emisor = trabajador;
            mensaje.fechaEnvio = DateTime.Now;
            mensaje.receptor = first_pmp.responsable;
            DBController.insertarMensaje(mensaje);
            MessageBox.Show("Se ha actualizado correctamente el plan de maestro de producción", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrden_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.ordenProduccion ordenFila = (Service.ordenProduccion)dgvOrden.Rows[e.RowIndex].DataBoundItem;
            dgvOrden.Rows[e.RowIndex].Cells[0].Value = ordenFila.id;
            //dgvOrden.Rows[e.RowIndex].Cells[1].Value = ordenFila.lineasOrden.ToArray().Length;
            dgvOrden.Rows[e.RowIndex].Cells[2].Value = ordenFila.fecha.ToString("dd/MM/yyyy");
        }

        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.maquinaria fila = (Service.maquinaria)dgvOrden.Rows[e.RowIndex].DataBoundItem;
            dgvOrden.Rows[e.RowIndex].Cells[0].Value = fila.id;
            dgvOrden.Rows[e.RowIndex].Cells[1].Value = fila.nombre;
            dgvOrden.Rows[e.RowIndex].Cells[2].Value = fila.tipo;
        }
    }
}
