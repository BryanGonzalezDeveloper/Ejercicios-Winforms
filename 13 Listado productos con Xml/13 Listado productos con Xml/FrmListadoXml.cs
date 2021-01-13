using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13_Listado_productos_con_Xml
{
    public partial class FrmListadoXml : Form
    {
        public FrmListadoXml()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            try
            {
               var objProducto = ClsArregloProducto.leerXml();
                if(objProducto!=null)
                {
                    foreach (ClsProducto producto in objProducto.listaProductos)
                    {
                        int i = 0;
                        dgvListado.Rows.Add();
                        dgvListado.Rows[i].Cells[0].Value = producto.Descripcion;
                        dgvListado.Rows[i].Cells[1].Value = producto.Categoria;
                        dgvListado.Rows[i].Cells[2].Value = producto.Precio;
                        dgvListado.Rows[i].Cells[3].Value = producto.Cantidad;
                        dgvListado.Rows[i].Cells[4].Value = producto.Vencimiento;
                        i++;
                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
