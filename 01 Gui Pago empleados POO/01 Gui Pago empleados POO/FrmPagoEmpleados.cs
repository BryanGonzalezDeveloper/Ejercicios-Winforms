using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Gui_Pago_empleados_POO
{
    public partial class FrmPagoEmpleados : Form
    {
        public FrmPagoEmpleados()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmpleado objEmpleado = new ClsEmpleado(txtNombre.Text,Convert.ToDouble(txtSueldoHora.Text),Convert.ToInt32(txtHoras.Text));
                objEmpleado.generarSueldoBase();
                objEmpleado.generarBonificacion();
                objEmpleado.generarSueldoBruto();
                objEmpleado.generarDeduccion();
                objEmpleado.generarSueldoNeto();
                lblEmpleado.Text = objEmpleado.Nombre;
                lblHoras.Text = objEmpleado.HorasTrab.ToString();
                lblSueldoBase.Text = objEmpleado.SueldoBase.ToString("C");
                lblBonificacion.Text = objEmpleado.Bonificacion.ToString("C");
                lblSueldoBruto.Text = objEmpleado.SueldoBruto.ToString("C");
                lblDeduccion.Text = objEmpleado.Deduccion.ToString("C");
                lblSueldoNeto.Text = objEmpleado.SueldoNeto.ToString("C");
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
            txtSueldoHora.ResetText();
            txtNombre.ResetText();
            txtHoras.ResetText();
            lblEmpleado.ResetText();
            lblHoras.ResetText();
            lblSueldoBase.ResetText();
            lblBonificacion.ResetText();
            lblSueldoBruto.ResetText();
            lblDeduccion.ResetText();
            lblSueldoNeto.ResetText();
        }
    }
}
