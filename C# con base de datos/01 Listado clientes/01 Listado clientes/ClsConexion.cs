using System;
using System.Data;
using System.Data.SqlClient;

namespace _01_Listado_clientes
{
    class ClsConexion
    {
        /*
Implementar una aplicación que permita listar los datos de los clientes desde la base de
datos Contrato. Al fi nal, presentar el total de clientes mostrados.
Se tiene en cuenta lo siguiente:
La cadena de conexión debe implementarse en el mismo formulario.
Implementar en SQL Server un procedimiento almacenado que permita listar los
datos de los clientes.
Usar el control DataGridView para listar los clientes.
Mostrar el total de clientes en un control Label.
 */
        static SqlConnection conexion =
            new SqlConnection("SERVER=LAPTOP-6CKP0UE0;DATABASE=CONTRATO;INTEGRATED SECURITY=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

       public DataTable listadoClientes()
        {
            try
            {
                cmd = new SqlCommand("SP_ListadoClientes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                conexion.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("ERROR: " + ex.Message);
                return dt;
            }
            finally
            {
                conexion.Close();
                
            }

        }
    }
}
