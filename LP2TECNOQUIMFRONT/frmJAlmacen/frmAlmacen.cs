﻿using LP2TECNOQUIMFRONT.frmPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJAlmacen
{
    public partial class frmAlmacen : Form
    {
        Service.trabajador trabajador = new Service.trabajador();
        int close = 0;

        int not = 0;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmAlmacen(int cont = 0, Service.trabajador trabajadors = null)
        {
            this.trabajador = trabajadors;
            Service.mensaje[] mensajes = DBController.listarMensaje(trabajador.id);
            if (mensajes != null)
            {
                not = mensajes.Length;
            }
            if (cont != 0)
            {
                InitializeComponent();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashStart));

                t.Start();

                Thread.Sleep(1250);

                InitializeComponent();

                MessageBox.Show("Bienvenido/a " + trabajador.nombres + " " + trabajador.apellidos);

                t.Abort();
                lblCantNotificaciones.Visible = false;
                if (not > 0)
                {
                    lblCantNotificaciones.Visible = true;
                    lblCantNotificaciones.Text = not.ToString();
                }
            }
            btnPerfil.Text = trabajador.nombres + "\n" + trabajador.apellidos;
        }
        public void SplashStart()
        {
            Application.Run(new frmSplash());
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones(this.trabajador);
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProducto formProducto = new frmProducto();
            formProducto.ShowDialog();
            this.Show();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmInsumo formInsumo = new frmInsumo();
            formInsumo.ShowDialog();
            this.Show(); 
        }

        private void frmAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmStockProd formStockP = new frmStockProd();
            formStockP.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmStockInsumo formStockI = new frmStockInsumo();
            formStockI.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPerfil formPerfil = new frmPerfil(this.trabajador);
            formPerfil.Visible = true;
            close = 1;
            this.Close();
        }
    }
}
