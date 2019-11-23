﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2TECNOQUIMFRONT.Service;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{   
    public partial class frmProducto : Form
    {
        int flag=0;
        int flagElim = 0;
        Service.producto producto;
        Service.insumo insumo;
        Service.lineaInsumo linea;
        Service.instructivo instructivo;
        BindingList<Service.lineaInsumo> lineas;
        BindingList<Service.lineaInsumo> lineasEliminadas;
        Service.ServicioClient DBController = new Service.ServicioClient();
        Estado estadoObj;

        public frmProducto()
        {
            InitializeComponent();
            lineas = new BindingList<lineaInsumo>();
            lineasEliminadas = new BindingList<lineaInsumo>();
            txtidprod.Enabled = false;
            txtIdInsumo.Enabled = false;
            txtidinst.Enabled = false;
            txtNomInsumo.Enabled = false;
            estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    //Etiquetas
                    lblidProd.Enabled = false;
                    lblIdInstructivo.Enabled = false;
                    lblNombre.Enabled = false;
                    lblPresentacion.Enabled = false;
                    lblGranu.Enabled = false;
                    lblAct.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    lblCantidad.Enabled = false;
                    lblInsumo.Enabled = false;
                    lblNomInsumo.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnElimina.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnBuscarInsumo.Enabled = false;
                    btnBuscar.Enabled = true;
                    //Campos de Texto
                    txtIdInsumo.Enabled = false;
                    txtNomProd.Enabled = false;
                    txtPres.Enabled = false;
                    txtGranu.Enabled = false;
                    txtAct.Enabled = false;
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
                    btnElimina.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnBuscarInsumo.Enabled = true;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Rows.Clear();
                    dgvInsumos.Refresh();
                    break;
                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnElimina.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnBuscarInsumo.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
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
                    btnElimina.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnBuscarInsumo.Enabled = true;
                    //Campos de Texto
                    txtNomProd.Enabled = true;
                    txtPres.Enabled = true;
                    txtGranu.Enabled = true;
                    txtAct.Enabled = true;
                    txtCant.Enabled = true;
                    dgvInsumos.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtidprod.Text = "";
            txtidinst.Text = "";
            txtNomProd.Text = "";
            txtPres.Text = "";
            txtGranu.Text = "";
            txtAct.Text = "";
            txtIdInsumo.Text = "";
            txtCant.Text = "";
            txtNomInsumo.Text = "";
            flag = 0;
            flagElim = 0;
            producto = new producto();
            insumo = new insumo();
            lineas = new BindingList<lineaInsumo>();
            lineasEliminadas = new BindingList<lineaInsumo>();
            dgvInsumos.DataSource = null;
            dgvInsumos.Rows.Clear();
            dgvInsumos.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            producto = new Service.producto();
            instructivo = new Service.instructivo();
            lineas = new BindingList<Service.lineaInsumo>();
            estadoObj = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObj = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float gran;
            if (txtNomProd.Text == "")
            {
                MessageBox.Show("No se ha ingresado el Nombre del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtGranu.Text == "")
            {
                MessageBox.Show("No se ha ingresado la Granularidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (float.TryParse(txtGranu.Text, out float granu))
            {
                gran = granu;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para la Granularidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPres.Text == "")
            {
                MessageBox.Show("No se ha ingresado la presentación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAct.Text == "")
            {
                MessageBox.Show("No se han ingresado las actividades del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lineas.Count() == 0)
            {
                MessageBox.Show("No se han ingresado insumos que formen el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (estadoObj == Estado.Nuevo)
            {
                producto = new Service.producto();
                producto.nombre = txtNomProd.Text;
                producto.presentacion = txtPres.Text;
                producto.granularidad = gran;

                instructivo = new Service.instructivo();
                instructivo.actividades = txtAct.Text;
                instructivo.insumos = lineas.ToArray();
                producto.instructivo = instructivo;
                if (flag == 1)
                {
                    producto.restriccion = true;
                }
                else
                {
                    producto.restriccion = false;
                }
                int idProd= DBController.insertarProducto(producto);
                int idInstru= DBController.insertarInstructivo(instructivo,idProd);
                foreach (Service.lineaInsumo l in lineas)
                {
                    DBController.insertarLineaInsumo(l,idInstru);
                }
                MessageBox.Show("Producto Registrado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (estadoObj == Estado.Modificar)
            {
                producto = new Service.producto();
                producto.idProducto = int.Parse(txtidprod.Text);
                producto.nombre = txtNomProd.Text;
                producto.presentacion = txtPres.Text;
                producto.granularidad = float.Parse(txtGranu.Text);
                instructivo = new Service.instructivo();
                instructivo.id = int.Parse(txtidinst.Text);
                instructivo.actividades = txtAct.Text;
                instructivo.insumos = lineas.ToArray();
                producto.instructivo = instructivo;

                DBController.actualizarProducto(producto);
                DBController.actualizarInstructivo(producto.instructivo, producto.idProducto);
                foreach (Service.lineaInsumo l in lineas)
                {
                    DBController.eliminarLineaInsumo(l.idLineaI);
                    DBController.insertarLineaInsumo(l, producto.instructivo.id);
                }
                if (flagElim==1)
                {
                    foreach (Service.lineaInsumo l in lineasEliminadas)
                    {
                        DBController.eliminarLineaInsumo(l.idLineaI);
                    }
                }
                MessageBox.Show("Producto Actualizado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmProductos formProd = new frmProductos();
            if (formProd.ShowDialog() == DialogResult.OK)
            {
                producto = formProd.ProductoSeleccionado;
                txtidprod.Text = producto.idProducto.ToString();
                txtNomProd.Text = producto.nombre;
                txtPres.Text = producto.presentacion;
                txtGranu.Text = producto.granularidad.ToString();
                txtidinst.Text = producto.instructivo.id.ToString();
                txtAct.Text = producto.instructivo.actividades;
                lineas = new BindingList<lineaInsumo>(DBController.listarLineaInsumo(producto.instructivo.id));
                producto.instructivo.insumos = lineas.ToArray();
                dgvInsumos.DataSource = lineas;
            }
            if (txtidprod.Text != "")
            {
                estadoObj = Estado.Buscar;
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if(txtidprod.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ningun Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBController.eliminarProducto(int.Parse(txtidprod.Text));
            limpiarComponentes();
            estadoObj = Estado.Inicial;
            estadoComponentes(Estado.Inicial);
            MessageBox.Show("Producto Eliminado Satisfactoriamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cant;
            if (insumo == null || insumo.id == 0)
            {
                MessageBox.Show("No se ha seleccionado un insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCant.Text == "")
            {
                MessageBox.Show("No se ha ingresado la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.TryParse(txtCant.Text, out int canti))
            {
                cant = canti;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un número para la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            linea = new Service.lineaInsumo();
            linea.insumo = insumo;
            linea.cantInsumo = cant;
            BindingList<Service.lineaInsumo> lineasAg = new BindingList<lineaInsumo>();
            foreach (lineaInsumo item in lineas)
            {
                lineasAg.Add(item);
            }
            lineasAg.Add(linea);
            lineas = lineasAg;
            agregarTabla(linea);
        }

        private void agregarTabla(lineaInsumo l)
        {
            dgvInsumos.DataSource = lineas;
        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmInsumos formInsumos = new frmInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
                insumo = formInsumos.InsumoSeleccionado;
                txtIdInsumo.Text = insumo.id.ToString();
                txtNomInsumo.Text = insumo.nombre;
                if (insumo.restriccion)
                {
                    flag = 1;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string str = dgvInsumos.Rows[dgvInsumos.SelectedRows[0].Index].Cells[0].Value.ToString();

            BindingList<Service.lineaInsumo> lineasElim = new BindingList<lineaInsumo>();
            foreach (lineaInsumo item in lineas)
            {
                if (item.insumo.nombre != str) lineasElim.Add(item);
                if (estadoObj == Estado.Modificar && item.insumo.nombre==str)
                {
                    lineasEliminadas.Add(item);
                    flagElim = 1;
                }
            }
            lineas = lineasElim;
            dgvInsumos.DataSource = lineas;
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.lineaInsumo insumoFila = (Service.lineaInsumo)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
            dgvInsumos.Rows[e.RowIndex].Cells["Nombre"].Style.ForeColor = System.Drawing.Color.Black;
            dgvInsumos.Rows[e.RowIndex].Cells["Granularidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvInsumos.Rows[e.RowIndex].Cells["Color"].Style.ForeColor = System.Drawing.Color.Black;
            dgvInsumos.Rows[e.RowIndex].Cells["Cantidad"].Style.ForeColor = System.Drawing.Color.Black;
            dgvInsumos.Rows[e.RowIndex].Cells["Presentacion"].Style.ForeColor = System.Drawing.Color.Black;
            dgvInsumos.Rows[e.RowIndex].Cells["Restriccion"].Style.ForeColor = System.Drawing.Color.Black;

            dgvInsumos.Rows[e.RowIndex].Cells["Nombre"].Value = insumoFila.insumo.nombre;
            dgvInsumos.Rows[e.RowIndex].Cells["Granularidad"].Value = insumoFila.insumo.granularidad.ToString();
            dgvInsumos.Rows[e.RowIndex].Cells["Color"].Value = insumoFila.insumo.color;
            dgvInsumos.Rows[e.RowIndex].Cells["Cantidad"].Value = insumoFila.cantInsumo.ToString();
            dgvInsumos.Rows[e.RowIndex].Cells["Presentacion"].Value = insumoFila.insumo.cantidad+" "+ insumoFila.insumo.unidad;
            if (insumoFila.insumo.restriccion)
            {
                dgvInsumos.Rows[e.RowIndex].Cells["Restriccion"].Value = "Si";
            }
            else
            {
                dgvInsumos.Rows[e.RowIndex].Cells["Restriccion"].Value = "No";
            }
        }
    }
}
