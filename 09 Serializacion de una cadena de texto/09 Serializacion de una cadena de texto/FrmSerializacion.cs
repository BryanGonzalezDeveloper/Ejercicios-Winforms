using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09_Serializacion_de_una_cadena_de_texto
{
    public partial class FrmSerializacion : Form
    {
        public FrmSerializacion()
        {
            InitializeComponent();
        }

        private void MiSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsSerializacion.serializar(richSerializar.Text);
                richSerializar.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MiDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                richDeserializar.Text=ClsSerializacion.deserializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
