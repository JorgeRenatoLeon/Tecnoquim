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

namespace LP2TECNOQUIMFRONT
{
    public partial class frmHistorialPlan : Form
    {
        public frmHistorialPlan()
        {
            InitializeComponent();
            dgvHistorialPlan.AutoGenerateColumns = false;;
        } 

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbMaximize_Click_1(object sender, EventArgs e)
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

        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formGerente = new frmGerente(1);
            formGerente.Visible = true;
            this.Close();
        }

        private void dgvHistorialPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerente formInicio = new frmGerente(1);
            formInicio.Visible = true;
            this.Close();
        }
    }
}
