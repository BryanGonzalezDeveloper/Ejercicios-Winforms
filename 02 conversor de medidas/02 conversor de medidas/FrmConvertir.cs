using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_conversor_de_medidas
{
    public partial class FrmConvertir : Form
    {
        public FrmConvertir()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                lsMedidas.Items.Clear();
                double metros = Convert.ToDouble(txtCantidad.Text);
                ClsConvetir objConvertir = new ClsConvetir(metros);
                double centimetros = objConvertir.MetroCentimetro();
                double pulgadas = objConvertir.MetroPulgada();
                double pies = objConvertir.MetroPie();
                double yardas = objConvertir.MetroYarda();
                lsMedidas.Items.Add("****************CONVERSOR DE MEDIDAS*****************");
                lsMedidas.Items.Add("CANTIDAD DE METROS:" + metros);
                lsMedidas.Items.Add("___________________________________________");
                lsMedidas.Items.Add("CENTIMETROS:" + centimetros.ToString("0.00"));
                lsMedidas.Items.Add("PULGADAS:" + pulgadas.ToString("0.00"));
                lsMedidas.Items.Add("PIES:" + pies.ToString("0.00"));
                lsMedidas.Items.Add("YARDAS:" + yardas.ToString("0.00"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void limpiar()
        {
            txtCantidad.ResetText();
            lsMedidas.Items.Clear();
            txtCantidad.Focus();
        }

        //Valida que solo se presionen digitos y que se pueda introducir solo un punto decimal.
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)||e.KeyChar=='.')
            {
                if (e.KeyChar == '.' && txtCantidad.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
