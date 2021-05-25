using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Listado_de_equipos
{
    public partial class FrmListadoEquipos : Form
    {
        /*
Implementar una aplicación Windows Forms que permita listar los datos de los equipos
en un control DataGridView desde la base de datos Contrato.
Se tiene en cuenta lo siguiente:
Implementar en SQL Server un procedimiento almacenado SP_LISTAEQUIPO que
permita listar los datos de los equipos, además de mostrar la descripción del estado y
del tipo de equipo.
Configurar la cadena de conexión en el archivo app.config.
Crear la clase Conexión e implementar el método getConecta, el cual permita asociarse
a la cadena de conexión especificada en el app.config.
Crear la clase LogicaNegocio e implementar el método listaEquipos que permita asociarse
al procedimiento almacenado SP_LISTAEQUIPO usando la clase DataView.*/
        public FrmListadoEquipos()
        {
            ClsListadoEquipos objEquipos;
            InitializeComponent();
            try
            {
                objEquipos = new ClsListadoEquipos();
                dgvEquipos.DataSource = objEquipos.listaEquipos();
                lblTotalRegistros.Text += dgvEquipos.RowCount;
            }
            catch (Exception ex)
            {

                msjError(ex.Message);
            }
        }

        public void msjError(string error)
        {
             MessageBox.Show("OCURRIO UN ERROR:\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
