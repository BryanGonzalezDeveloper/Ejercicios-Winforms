using System;
using System.Data;
using System.Data.SqlClient;
namespace _06Transacciones_sql
{
    class ClsConexion
    {
        static string cadenaConexion = @"server=.;Database=db_telefonos;integrated security=true";
        SqlConnection objConexion = new SqlConnection(cadenaConexion);
        SqlCommand orden;
        public void updateTelefono(string telViejo, string telNuevo)
        {
            SqlTransaction tran = null;

            try
            {

                string consulta = "sp_modificarTel";
                orden = new SqlCommand(consulta, objConexion);
                orden.CommandType = CommandType.StoredProcedure;
                orden.Parameters.AddWithValue("@tfnNuevo", telNuevo);
                orden.Parameters.AddWithValue("@tfnViejo", telViejo);
                objConexion.Open();
                //Iinicia la transaccion
                tran = objConexion.BeginTransaction();
                orden.Transaction = tran;
                //Se ejecuta la instruccion sql:
                orden.ExecuteNonQuery();
                //Finaliza la transaccion:
                tran.Commit();
            }
            catch (Exception)
            {
                //Se vuelve al estado en el que estaba la base de datos antes de iniciar el conjunto de instrucciones
                //que generaron el error:
                tran.Rollback();
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
