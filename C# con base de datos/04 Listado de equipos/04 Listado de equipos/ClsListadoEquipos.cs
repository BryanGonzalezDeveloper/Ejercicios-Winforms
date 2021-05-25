using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _04_Listado_de_equipos
{
    class ClsListadoEquipos:ClsConexion
    {
        SqlCommand cmd;
        DataView dv;
        SqlDataReader dr;
        DataTable dt;
        public DataView listaEquipos()
        {
            try
            {
                cmd = new SqlCommand("SP_ListaEquipo",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                dr = cmd.ExecuteReader();
                dt = new DataTable("LISTA_EQUIPOS");
                dt.Load(dr);
                dv = new DataView();
                dv.Table = dt;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();              
            }
            return dv;
        }
    }
}
