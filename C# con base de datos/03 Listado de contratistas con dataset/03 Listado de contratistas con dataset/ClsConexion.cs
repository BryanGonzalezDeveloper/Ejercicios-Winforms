using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace _03_Listado_de_contratistas_con_dataset
{
   abstract  class ClsConexion
    {
        public static SqlConnection getConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DB_CONTRATO"].ConnectionString);
        }
    }
}
