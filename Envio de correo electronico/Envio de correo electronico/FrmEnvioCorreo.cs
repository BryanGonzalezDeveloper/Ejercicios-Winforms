using System;
using System.Windows.Forms;

namespace Envio_de_correo_electronico
{
    public partial class FrmEnvioCorreo : Form
    {
        public FrmEnvioCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            FrmAutenticacion frm = new FrmAutenticacion(this);
            this.Hide();
            frm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiar()
        {
            txtRemitente.ResetText();
            txtAsunto.ResetText();
            txtDestino.ResetText();
            txtMsj.ResetText();

        }
    }
}
