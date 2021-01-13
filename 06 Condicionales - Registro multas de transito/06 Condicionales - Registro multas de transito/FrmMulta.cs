using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06_Condicionales___Registro_multas_de_transito
{
    public partial class FrmMulta : Form
    {
        ClsMulta objMulta;
        public FrmMulta()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
             objMulta = new ClsMulta(txtPlaca.Text, Convert.ToDouble(txtVelocidad.Text), lblFecha.Text, lblHora.Text);
            objMulta.asignarMulta();         
            cargarDatos();
        }
       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {        
                if (MessageBox.Show("Seguro que desea eliminar todos los registros?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvInformacion.Rows.Clear();
                }          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        void limpiar()
        {
            txtPlaca.ResetText();
            txtVelocidad.ResetText();
        }
        void cargarDatos()
        {
          dgvInformacion.Rows.Add(objMulta.Placa, objMulta.Velocidad, objMulta.Fecha, objMulta.Hora, objMulta.Multa.ToString("C"));           
        }
    }
}
