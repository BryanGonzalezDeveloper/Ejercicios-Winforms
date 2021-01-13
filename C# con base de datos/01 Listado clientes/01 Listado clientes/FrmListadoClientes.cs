using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Listado_clientes
{
    public partial class FrmListadoClientes : Form
    {
        ClsConexion objDB = new ClsConexion();
        public FrmListadoClientes()
        {
            InitializeComponent();
            dgvListado.DataSource = objDB.listadoClientes();
            lblTotalRegistros.Text = "Total de clientes:" + dgvListado.RowCount;
        }
    }
}
