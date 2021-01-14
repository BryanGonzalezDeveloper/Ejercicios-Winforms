using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leer_Archivo_Csv
{
    public partial class FrmLeerCSV : Form
    {
        public FrmLeerCSV()
        {
            InitializeComponent();
        }

        private void btnElegirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCSV.DataSource = ClsLeer.getData(ClsLeer.setPath());
                lblContador.Text = "Total de registros: "+dgvCSV.RowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Seguro que desea salir?","CERRAR APLICACION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==DialogResult.Yes)
            this.Close();
        }
    }
}
