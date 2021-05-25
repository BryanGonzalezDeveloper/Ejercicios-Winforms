using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _04_Listado_de_equipos
{
    class ClsConexion
    {
        public static readonly SqlConnection conexion = new SqlConnection
            (ConfigurationManager.ConnectionStrings["DB_CONTRATO"].ConnectionString);
    }
}
