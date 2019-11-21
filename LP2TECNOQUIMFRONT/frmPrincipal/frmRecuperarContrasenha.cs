using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2TECNOQUIMFRONT.frmPrincipal
{
    public partial class frmRecuperarContrasenha : Form
    {
        private Service.trabajador trabajador = new Service.trabajador();
        Service.ServicioClient DBController = new Service.ServicioClient();

        public frmRecuperarContrasenha(Service.trabajador trabajadors)
        {
            trabajador = trabajadors;
            InitializeComponent();
        }

        private void sendpassword(String password, String email)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("soporte.tecnoquim@gmail.com", "tecnoquim1234");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Olvido Contraseña ( TECNOQUIM )";
            msg.Body = "Querido/a " + trabajador.nombres + " " + trabajador.apellidos + ",\nTu Contraseña es  " + password + "\n\n\nSaludos Cordiales,\n\nEquipo Tecnoquim";
            string toaddress = email;
            msg.To.Add(toaddress);
            string fromaddress = "TECNOQUIM <soporte.tecnoquim@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text != "Usuario" && this.txtUsuario.Text != "")
            {
                bool count = false;
                BindingList<Service.trabajador> binding = new BindingList<Service.trabajador>(DBController.listarTrabajadores("%"));
                for (int i = 0; i < binding.Count; i++)
                {
                    if (binding[i].usuario.username == txtUsuario.Text)
                    {
                        trabajador = binding[i];
                        count = true;
                        break;
                    }
                }
                if (count)
                {
                    sendpassword(trabajador.usuario.password, trabajador.correo);
                    MessageBox.Show("Se envió tu contraseña al correo registrado. Verifica tu bandeja de correo");

                }
                else
                {
                    MessageBox.Show("Datos Inválidos");

                }
            }
            else
            {
                MessageBox.Show("Ingresa tu usuario para enviar la contraseña");
            }
        }
    }
}
