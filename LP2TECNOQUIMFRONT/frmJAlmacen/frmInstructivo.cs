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
        public frmInstructivo()
        {
            InitializeComponent();
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
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtNomProd.Enabled = false;
                    txtidinst.Enabled = false;
                    txtPres.Enabled = false;
                    txtGranu.Enabled = false;
                    txtAct.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtNomInsumo.Enabled = false;
                    txtCant.Enabled = false;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Nuevo:
                    //Etiquetas
                    lblidProd.Enabled = true;
                    lblIdInstructivo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtIdInsumo.Enabled = true;
                    txtNomInsumo.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
                case Estado.Modificar:
                    //Etiquetas
                    lblidProd.Enabled = true;
                    lblIdInstructivo.Enabled = true;
                    lblNombre.Enabled = true;
                    lblPresentacion.Enabled = true;
                    lblGranu.Enabled = true;
                    lblAct.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    lblCantidad.Enabled = true;
                    lblInsumo.Enabled = true;
                    lblNomInsumo.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnBuscar.Enabled = false;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtidinst.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
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
            txtNomProd.Text = "";
            txtPres.Text = "";
            txtGranu.Text = "";
            txtAct.Text = "";
            txtIdInsumo.Text = "";
            txtCant.Text = "";
            txtNomInsumo.Text = "";
            dgvInsumos.Rows.Clear();
            dgvInsumos.Refresh();
        }


    }
}
