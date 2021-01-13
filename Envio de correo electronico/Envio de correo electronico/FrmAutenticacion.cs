using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envio_de_correo_electronico
{
    public partial class FrmAutenticacion : Form
    {
        FrmEnvioCorreo frm;
        public FrmAutenticacion(FrmEnvioCorreo frmCorreo)
        {
            frm = frmCorreo;
            InitializeComponent();
        }
        public static string pass="";
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text)||string.IsNullOrEmpty(txtConfirmPass.Text))
                MessageBox.Show("INGRESA TU CONTRASEÑA.");
            else
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    pass = txtPassword.Text;
                    ClsEnvioCorreo.Pass = pass;                 
                    ClsEnvioCorreo objEnvio = new ClsEnvioCorreo
                        (frm.txtRemitente.Text, frm.txtDestino.Text, frm.txtAsunto.Text );
                    objEnvio.enviar(frm.txtMsj.Text);
                    this.Close();
                    frm.limpiar();
                    frm.Show();
                   
                }
                else
                    MessageBox.Show("Rectifica tu contraseña.");
            }
        }
        public static String getPassword()
        {
            return pass;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbOcultar.Visible = false;
            pbMostrar.Visible = true;
            txtPassword.PasswordChar = '*';
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.Visible = true;
            pbMostrar.Visible = false;
            txtPassword.PasswordChar = '\0';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                pbVerificacion.Visible = true;
                btnEnviar.Enabled = true;
            }
            else
                pbVerificacion.Visible = false;
        }
    }
}
