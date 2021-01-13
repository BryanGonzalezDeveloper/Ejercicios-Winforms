using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _11_Serializacion_binaria_con_imagenes
{
    public partial class FrmSerializacion : Form
    {
        public FrmSerializacion()
        {
            InitializeComponent();
        }

        private void btnEligir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files | *.jpg";
            if(op.ShowDialog()==DialogResult.OK)
            {
                pbFoto.ImageLocation= op.FileName;
            }
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            ClsCliente obj = new ClsCliente(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtCorreo.Text, (Bitmap)pbFoto.Image);
            ClsSerializar.serializar(obj);
            limpiar();
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = ClsSerializar.deserializar();
            txtNombre.Text = cliente.Nombre;
            txtPaterno.Text = cliente.Paterno;
            txtMaterno.Text = cliente.Materno;
            txtCorreo.Text = cliente.Correo;
            pbFoto.Image = cliente.Imagen;
        }
        void limpiar()
        {
            txtNombre.ResetText();
            txtPaterno.ResetText();
            txtMaterno.ResetText();
            txtCorreo.ResetText();
            pbFoto.Image = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
