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
        Service.detalleAlmacenInsumo detalle;
        Service.detalleAlmacenInsumo almacenI;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmStockInsumo()
        {
            InitializeComponent();
            BindingList<Service.almacen> almacens = new BindingList<Service.almacen>(DBController.listarAlmacen(""));
            cbAlmacen.DataSource = almacens;
            cbAlmacen.DisplayMember = "Tipo";
            txtCodigo.Enabled = false;
            txtCant.Enabled = false;
            txtNombre.Enabled = false;
            txtUnidad.Enabled = false;
        }
        

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            txtLote.Enabled = true;
            cbAlmacen.Enabled = true;
            frmStocksI formInsumos = new frmStocksI();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                detalle = formInsumos.InsumoSeleccionado;
                txtCodigo.Text = detalle.insumo.id.ToString();
                txtNombre.Text = detalle.insumo.nombre;
                txtCant.Text = detalle.insumo.cantidad.ToString();
                txtUnidad.Text = detalle.insumo.unidad.ToString();
                txtLote.Text = detalle.nLote.ToString();
                txtAct.Text = detalle.stock.ToString();
                txtLote.Enabled = false;
                cbAlmacen.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int lote;
            int cant;
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un Insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtLote.Text == "")
            {
                MessageBox.Show("No se ha ingresado el número de Lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtLote.Text, out int loteout))
            {
                lote = loteout;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para el Lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAct.Text == "")
            {
                MessageBox.Show("No se ha ingresado el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtAct.Text, out int canti))
            {
                cant = canti;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            almacenI = new Service.detalleAlmacenInsumo();
            insumo = new Service.insumo();
            insumo.id = int.Parse(txtCodigo.Text);

            almacenI.insumo = insumo;
            almacenI.stock = cant;
            almacenI.nLote = lote;
            DBController.actualizarDetalleAlmacenInsumo(almacenI);
            MessageBox.Show("Se actualizo el stock Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
