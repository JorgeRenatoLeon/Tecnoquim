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
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJVenta fromJProd = new frmJVenta(1);
            fromJProd.Visible = true;
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmNotificaciones formNot = new frmNotificaciones();
            formNot.Visible = true;
            this.Close();
        }
    }
}