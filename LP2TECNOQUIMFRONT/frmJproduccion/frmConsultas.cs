﻿
using LP2TECNOQUIMFRONT.frmJAlmacen;
using LP2TECNOQUIMFRONT.frmJVenta;
using System;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJproduccion
{
    public partial class frmConsultas : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        Service.proyeccionVenta proyeccionVenta = new Service.proyeccionVenta();
        int close = 0;
        int not = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmConsultas(Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            InitializeComponent();
            lblCantNotificaciones.Visible = false;
            if (not > 0)
            {
                lblCantNotificaciones.Visible = true;
                lblCantNotificaciones.Text = not.ToString();
            }
            btnPerfil.Text = trabajador.nombres + "\n" + trabajador.apellidos;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJProduccion fromJProd = new frmJProduccion(1, this.trabajador);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmJAlmacen.frmStocksP form = new frmStocksP(1);
            form.ShowDialog(this);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmStocksI form = new frmStocksI(1);
            form.ShowDialog(this);
        }

        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            frmMaquinaria formMaquinaria = new frmMaquinaria(1);
            formMaquinaria.ShowDialog(this);
        }

        private void btnPolitica_Click(object sender, EventArgs e)
        {
            frmPolitica formPolitica = new frmPolitica();
            formPolitica.ShowDialog(this);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            btnReporte formPerfil = new btnReporte(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InsumosRestringidos formInsR = new InsumosRestringidos(this.trabajador);
            formInsR.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            today = today.AddMonths(1);
            Service.proyeccionVenta[] pvs = DBController.listarProyeccionVenta(today.ToString("yyyy-MM"));
            if (pvs == null)
            {
                MessageBox.Show("No hay una Proyeccion de Venta para el mes siguiente", "Proyeccion de Venta existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                proyeccionVenta = pvs[pvs.Length - 1];
                frmGestionarProyeccionVenta formVenta = new frmGestionarProyeccionVenta(proyeccionVenta, false);
                formVenta.ShowDialog(this);
            }
        }
    }
}
