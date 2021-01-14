using System;
using System.Windows.Forms;

namespace _03_Listado_de_contratistas_con_dataset
{
    public partial class FrmListadoContratistas : Form
    {
        //        Implementar una aplicación Windows Forms que permita listar los datos de los
        //contratistas en un control DataGridView desde la base de datos Contrato.
        //Se tiene en cuenta lo siguiente:
        //Implementar en SQL Server un procedimiento almacenado 
        //que permita listar los datos completos de los contratistas.
        //Confi gurar la cadena de conexión en el archivo app.config.
        //Crear la clase ClsConexión e implementar el método getConexion, que permita asociarse
        //a la cadena de conexión especificada en el app.confi g.
        //Crear la clase ClsContratistas e implementar el método listadoContratista, que
        //permita asociarse al procedimiento almacenado  usando DATASET.
        public FrmListadoContratistas()
        {
            ClsContratistas objContratista = new ClsContratistas();
            InitializeComponent();
            try
            {
                dgvListadoContratistas.DataSource = objContratista.listadoContratistas().Tables["CONTRATISTA"];
                lblContador.Text = "LA TABLA DE CONTRATISTAS CUENTA CON: " + dgvListadoContratistas.RowCount + " REGISTROS";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


    }
}
