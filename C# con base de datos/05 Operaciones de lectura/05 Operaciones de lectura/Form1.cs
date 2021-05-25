using System;
using System.Windows.Forms;

namespace _05_Operaciones_de_lectura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsConexion objDB = new ClsConexion();


        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            foreach (var item in objDB.detalleTelefono())
            {
                richTextBox1.Text += item.nombre.PadRight(30, ' ') + item.telefono + "\n";
            }
        }

        private void btnIniciarConexion_Click(object sender, EventArgs e)
        {
            if (objDB.estadoConexion() == 1)
            {
                lblConexion.Text = "Desconectada";
                btnIniciarConexion.Text = "Abrir Conexion";
            }
            else
            {
                lblConexion.Text = "Conectada";
                btnIniciarConexion.Text = "Cerrar Conexion";
            }
        }

        private void txtNumeroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNumeroTelefonico_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroTelefonico.Text))
            {
                richTextBox1.ResetText();
                foreach (var item in objDB.consultaXtelefono(txtNumeroTelefonico.Text))
                    richTextBox1.Text += item.nombre.PadRight(30, ' ') + item.telefono + "\n";
            }

        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            foreach (var item in objDB.consultaSP(txtSP.Text))
                richTextBox1.Text += item.nombre.PadRight(30, ' ') + item.telefono + "\n";
        }
    }
}
