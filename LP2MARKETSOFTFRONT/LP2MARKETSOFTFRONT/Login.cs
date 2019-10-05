using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MARKETSOFTFRONT
{
    public partial class Login : Form
    {
        int cont = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Login()
        {
            InitializeComponent();
            this.LostFocus += new System.EventHandler(this.WaterMark_Toggel);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            cont += 1;
            if (cont == 1) { this.txtUsuario.Text = " "; }
            
        }
        private void WaterMark_Toggel(object sender, EventArgs args)
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
                DisbaleWaterMark();
        }

        private void EnableWaterMark()
        {
            if (this.txtUsuario.Text.Length <= 0) { this.txtUsuario.Text="Usuario"; }
            Refresh();
        }

        private void DisbaleWaterMark()
        {
            cont += 1;
            if (cont == 1) { this.txtUsuario.Text = " "; }
        }
    }
}
