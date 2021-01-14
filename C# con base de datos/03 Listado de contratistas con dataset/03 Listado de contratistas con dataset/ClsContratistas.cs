using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _03_Listado_de_contratistas_con_dataset
{
    class ClsContratistas:ClsConexion
    {
        SqlConnection conexion=getConexion();
        SqlDataAdapter da;
        DataSet dsContratistas;
        public DataSet listadoContratistas()
        {
            try
            {
                using(da=new SqlDataAdapter("SP_ListadoContratistas",conexion))
                {
                    dsContratistas = new DataSet();
                    da.Fill(dsContratistas, "CONTRATISTA");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dsContratistas;
        }
    }
}
