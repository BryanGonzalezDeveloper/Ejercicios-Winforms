using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_Listado_clientes
{
    public partial class FrmListadoClientes : Form
    {
        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONTRATODataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cONTRATODataSet.CLIENTE);
            lblTotalRegistros.Text = "TOTAL DE CLIENTES EN LA BASE DE DATOS: " + dataGridView1.Rows.Count;

        }
    }
}
