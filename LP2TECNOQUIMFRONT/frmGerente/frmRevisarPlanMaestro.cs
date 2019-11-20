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
        //Estado estadoObj;

        public frmRevisarPlanMaestro(Service.planMaestroProduccion firstpmp, bool save)
        {
            InitializeComponent();
            pmp = firstpmp;
            txtCodigo.Text = pmp.id.ToString();
            txtPeriodo.Text = pmp.periodo.AddHours(5).ToString("MMMM , yyyy");
            txtComentario.Text = pmp.estado.ToString();
            if (pmp.estado == Service.estado.Rechazado) rbDesaprobado.Checked = true;
            else if (pmp.estado == Service.estado.Aprobado) rbAprobado.Checked = true;
            txtResponsable.Text = pmp.responsable.nombres + " " + pmp.responsable.apellidos;
            calOrdenProduccion.MaxSelectionCount = 1;
            dgvOrden.AutoGenerateColumns = false;
            dgvMaquinaria.AutoGenerateColumns = false;
            pmp.maquinarias = DBController.listarDetalleMaquinaria(pmp.id);
            pmp.ordenes = DBController.listarOrdenesProduccionPlan(pmp.id);
            setOrden();

            dgvMaquinaria.DataSource = pmp.maquinarias;
            //estadoObj = Estado.Inicial;
            if (!save) {
                gbEstado.Enabled = false;
                btnGuardar.Visible = false;
            }
            DateTime date = pmp.periodo.AddHours(5);
            calOrdenProduccion.SetDate(new DateTime(date.Year, date.Month, 1));
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
            Service.trabajador[] trabajadores = DBController.listarTrabajadores("");
            foreach (Service.trabajador tr in trabajadores)
            {
                if (tr.rol.idRol == 1)
                {
                    mensaje.receptor = tr;
                }
            }
            DBController.insertarMensaje(mensaje);
            MessageBox.Show("Se ha actualizado correctamente el plan de maestro de producción", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgvMaquinaria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.detalleMaquinaria maqFila = (Service.detalleMaquinaria)dgvMaquinaria.Rows[e.RowIndex].DataBoundItem;
            dgvMaquinaria.Rows[e.RowIndex].Cells[0].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells[1].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells[2].Style.ForeColor = System.Drawing.Color.Black;
            dgvMaquinaria.Rows[e.RowIndex].Cells[0].Value = maqFila.maquinaria.id;
            dgvMaquinaria.Rows[e.RowIndex].Cells[1].Value = maqFila.maquinaria.nombre;
            dgvMaquinaria.Rows[e.RowIndex].Cells[2].Value = maqFila.fecha.AddHours(5);
        }

        private void setOrden()
        {
            if (pmp.ordenes != null)
            {
                foreach (Service.ordenProduccion item in pmp.ordenes)
                {
                    string a = item.fecha.AddHours(5).ToString("dd-MM-yyy");
                    string b = calOrdenProduccion.SelectionRange.Start.ToString("dd-MM-yyy");
                    if (a == b)
                    {
                        if (item.lineasOrden == null)
                        {
                            item.lineasOrden = DBController.listarLineaOrden(item.id);
                        }
                        dgvOrden.DataSource = item.lineasOrden;
                    }
                }
            }
            else
            {
                dgvOrden.DataSource = null;
            }
        }
        private void calOrdenProduccion_DateChanged(object sender, DateRangeEventArgs e)
        {
            setOrden();
        }

        private void dgvOrden_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaOrden lineaOrdenFila = (Service.lineaOrden)dgvOrden.Rows[e.RowIndex].DataBoundItem;
            dgvOrden.Rows[e.RowIndex].Cells[0].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells[1].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells[2].Style.ForeColor = System.Drawing.Color.Black;
            dgvOrden.Rows[e.RowIndex].Cells[0].Value = lineaOrdenFila.producto.nombre;
            dgvOrden.Rows[e.RowIndex].Cells[1].Value = lineaOrdenFila.producto.idProducto;
            dgvOrden.Rows[e.RowIndex].Cells[2].Value = lineaOrdenFila.cantProducto;
        }
    }
}
