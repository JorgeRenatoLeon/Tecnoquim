using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmInstructivo : Form
    {
        Estado estadoObj;
        Service.instructivo instructivo;
        BindingList<Service.lineaInsumo> lineas;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmInstructivo()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }
            
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblIdInstructivo.Enabled = false;
                    lblAct.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    lblCantidad.Enabled = false;
                    lblInsumo.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    //Botones
                    btnGuardar.Enabled = false;
                    //Campos de Texto
                    txtidinst.Enabled = false;
                    txtAct.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtNomInsumo.Enabled = false;
                    txtCant.Enabled = false;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblIdInstructivo.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnGuardar.Enabled = true;
                    //Campos de Texto
                    txtidinst.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtNomInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Buscar:
                    //Botones
                    btnGuardar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    lblIdInstructivo.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnGuardar.Enabled = true;
                    //Campos de Texto
                    txtidinst.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtNomInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtAct.Text = "";
            txtIdInsumo.Text = "";
            txtCant.Text = "";
            txtNomInsumo.Text = "";
            dgvInsumos.Rows.Clear();
            dgvInsumos.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            instructivo = new Service.instructivo();
            instructivo.actividades = txtAct.Text;
            lineas = new BindingList<Service.lineaInsumo>();
            instructivo.insumos = lineas.ToArray();

            foreach (Service.lineaInsumo l in lineas)
            {
                DBController.insertarLineaInsumo(l, instructivo.id);
            }
            MessageBox.Show("Producto Registrado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
