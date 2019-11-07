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
    public partial class frmStockInsumo : Form
    {
        Service.insumo insumo;
        Service.detalleAlmacenInsumo almacenI;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStockInsumo()
        {
            InitializeComponent();
            BindingList<Service.almacen> almacens = new BindingList<Service.almacen>(DBController.listarAlmacen(""));
            cbAlmacen.DataSource = almacens;
            cbAlmacen.DisplayMember = "Tipo";
        }
        

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                insumo = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = insumo.id.ToString();
                txtNombre.Text = insumo.nombre;
                txtCant.Text = insumo.cantidad.ToString();
                txtUnidad.Text = insumo.unidad.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            almacenI = new Service.detalleAlmacenInsumo();
            insumo = new Service.insumo();
            insumo.id = int.Parse(txtCodigo.Text);

            almacenI.insumo = insumo;
            almacenI.stock = int.Parse(txtAct.Text);

            DBController.actualizarDetalleAlmacenInsumo(almacenI);
            MessageBox.Show("Se actualizo el stock Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
