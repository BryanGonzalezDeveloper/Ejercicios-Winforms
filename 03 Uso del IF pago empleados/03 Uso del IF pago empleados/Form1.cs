using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Uso_del_IF_pago_empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richResultados.Text = "";
                ClsEmpleado objEmpleado = new ClsEmpleado(txtNombre.Text, cboPuestos.Text);
                objEmpleado.AsignarSueldoNeto();
                richResultados.Text += objEmpleado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        void limpiar()
        {
            txtNombre.ResetText();
            richResultados.ResetText();
            txtNombre.Focus();
        }

    }
}
