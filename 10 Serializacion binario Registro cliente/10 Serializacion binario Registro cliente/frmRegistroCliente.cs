using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_Serializacion_binario_Registro_cliente
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!camposVacios())
                {
                    ClsCliente cliente = new ClsCliente(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtCorreo.Text);
                    ClsSerializar.serializar(cliente);
                    limpiar();
                }
                else
                    MessageBox.Show("Asegurese de llenar los campos correctamente.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCliente cliente=ClsSerializar.deserializar();
                txtNombre.Text= cliente.Nombre;
                txtPaterno.Text = cliente.Paterno;
                txtMaterno.Text = cliente.Materno;
                txtCorreo.Text = cliente.Email;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void limpiar()
        {
            txtNombre.ResetText();
            txtPaterno.ResetText();
            txtMaterno.ResetText();
            txtCorreo.ResetText();
        }
        bool camposVacios()
        {
            bool vacios = false;
            if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPaterno.Text) |
                string.IsNullOrEmpty(txtMaterno.Text) | string.IsNullOrEmpty(txtCorreo.Text))
                vacios = true;
            return vacios;

        }
    }
}
