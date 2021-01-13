using System.Data.SqlClient;
using System.Configuration;
namespace _02_Listado_clientes_usando_app_config
{
    public abstract class ClsConexion
    {
        public static SqlConnection getConexion()
        {
            return  new SqlConnection(ConfigurationManager.ConnectionStrings["DB_CONTRATO"].ConnectionString);        
        }
    }
}
