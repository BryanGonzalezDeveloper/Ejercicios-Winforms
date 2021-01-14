using System.Windows.Forms;

namespace _02_Listado_clientes_usando_app_config
{
    //Implementar una aplicación Windows Forms que permita listar los datos de los clientes
    //en un control DataGridView desde la base de datos Contrato.
    //Se tiene en cuenta lo siguiente:
    //Implementar en SQL Server un procedimiento almacenado que
    //permita listar los datos de los clientes.
    //Configurar la cadena de conexión en el archivo app.config.
    //Crear la clase Conexión e implementar el método getConexion, el cual permita asociarse
    //a la cadena de conexión especificada en el app.confi g.
    //Crear la clase ClsClientes e implementar el método listaClientes que permita
    //asociarse al procedimiento almacenado SP_LISTACLIENTE.
    //Usar el control DataGridView para listar los clientes.
    //Mostrar el total de clientes en un control Label.
    public partial class FrmListado : Form
    {

        ClsClientes objClientes = new ClsClientes();
        public FrmListado()
        {
            InitializeComponent();
            dgvListado.DataSource = objClientes.listadoClientes();
            lblContador.Text = "EXISTE UN TOTAL DE: " + dgvListado.RowCount + " REGISTROS EN LA TABLA CLIENTES";
        }
    }
}
