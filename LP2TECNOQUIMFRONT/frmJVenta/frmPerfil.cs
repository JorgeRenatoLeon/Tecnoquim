﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmJVenta
{
    public partial class frmPerfil : Form
    {
        int close = 0;
        public frmPerfil()
        {
            InitializeComponent();
            txtDNI.Text = "65489";
            txtNombre.Text = "Alfredo";
            txtApellido.Text = "Alvarado";
            txtCorreo.Text = " ";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJVenta fromJProd = new frmJVenta(1);
            fromJProd.Visible = true;
            close = 1;
            this.Close();
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            close = 1;
            this.Close();
        }

        private void frmPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == 0) { Environment.Exit(0); }
        }
    }
}
