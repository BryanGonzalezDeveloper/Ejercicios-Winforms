using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_Serializacion_XML
{
    public partial class FrmSerializacion : Form
    {
        public FrmSerializacion()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            dtpVencimiento.MinDate = DateTime.Now;
        }      
        private void tsGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProducto objProducto = new ClsProducto(txtDescripcion.Text, cboCategoria.Text, 
                    Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), dtpVencimiento.Value);
                ClsSerializar.Serializar(objProducto);
                limpiar();
                MessageBox.Show("Objeto serializado con exito!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProducto objProducto=ClsSerializar.deserealizar();
                txtDescripcion.Text = objProducto.Descripcion;
                cboCategoria.Text = objProducto.Categoria;
                txtPrecio.Text = objProducto.Precio.ToString();
                txtCantidad.Text = objProducto.Cantidad.ToString();
                dtpVencimiento.Value = objProducto.Vencimiento;
                MessageBox.Show("Objeto deserealizado con exito!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        void limpiar()
        {
            txtDescripcion.ResetText();
            txtPrecio.ResetText();
            txtCantidad.ResetText();
            dtpVencimiento.Value = DateTime.Now;
            cboCategoria.Text = "Seleccione una categoria.";
        }

    }
}
