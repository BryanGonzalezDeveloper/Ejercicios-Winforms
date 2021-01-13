using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05_Condicionales___VENTA_DE_PRODUCTOS
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (cboArticulo.SelectedIndex == -1)
                epError.SetError(cboArticulo, "Elige una opcion.");
            if(cboFormaPago.SelectedIndex==-1)
                epError.SetError(cboFormaPago, "Elige una opcion.");
            ClsArticulo objArticulo = new ClsArticulo(cboArticulo.Text, cboFormaPago.Text, Convert.ToInt32(txtCantidadArticulos.Text));
            objArticulo.calcularTotal();
            foreach (ClsArticulo articulo in objArticulo.getLista())
                dgvInformacion.Rows.Add(objArticulo.Articulo, objArticulo.CantidadArticulos, objArticulo.Subtotal, objArticulo.Descuento, objArticulo.Total);
            limpiar();
        }

        void limpiar()
        {
            txtCantidadArticulos.ResetText();
            cboArticulo.ResetText();
            cboFormaPago.ResetText();
        }
        private void txtCantidadArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
