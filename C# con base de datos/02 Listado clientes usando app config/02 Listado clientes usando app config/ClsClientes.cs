using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _02_Listado_clientes_usando_app_config
{
    class ClsClientes:ClsConexion
    {
        SqlConnection objConexion = getConexion();
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dtClientes;
        public  DataTable listadoClientes()
        {
            try
            {
                cmd = new SqlCommand("SP_ListadoClientes", objConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                objConexion.Open();
                dr = cmd.ExecuteReader();
                dtClientes = new DataTable();
                dtClientes.Load(dr);
                return dtClientes;
            }
            catch (Exception ex)
            {
                return dtClientes;
                MessageBox.Show("ERROR: " +ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
