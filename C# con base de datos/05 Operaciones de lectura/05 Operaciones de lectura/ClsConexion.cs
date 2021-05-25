using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace _05_Operaciones_de_lectura
{
    class ClsConexion
    {
        static string cadenaConexion = @"Server=.;Database=db_telefonos; Integrated security=true";
        SqlConnection objConexion = new SqlConnection(cadenaConexion);
        SqlCommand ordenSql;
        SqlDataReader dr;
        public int estadoConexion()
        {
            if (objConexion.State == ConnectionState.Open)
            {
                objConexion.Close();
                return 1;
            }

            else
            {
                objConexion.Open();
                return 0;
            }

        }

        public List<Db_telefonos> detalleTelefono()
        {
            objConexion.Close();
            List<Db_telefonos> DatosTelefonicos = new List<Db_telefonos>();
            ordenSql = new SqlCommand("select nombre, telefono from tbl_telefono", objConexion);
            objConexion.Open();
            dr = ordenSql.ExecuteReader();
            while (dr.Read())
                DatosTelefonicos.Add(
                    new Db_telefonos
                    {
                        nombre = dr.GetString(0),
                        telefono = dr.GetString(1)
                    });
            dr.Close();
            objConexion.Close();
            return DatosTelefonicos;
        }
        public List<Db_telefonos> consultaXtelefono(string tlfn)
        {
            List<Db_telefonos> lista = new List<Db_telefonos>();
            string consulta = "select  nombre, telefono from tbl_telefono where telefono like '@tlf%'";
            try
            {
                ordenSql = new SqlCommand(consulta, objConexion);
                ordenSql.Parameters.AddWithValue("@tlf", tlfn);
                objConexion.Open();
                dr = ordenSql.ExecuteReader();
                while (dr.Read())
                    lista.Add(
                        new Db_telefonos
                        {
                            nombre = dr.GetString(0),
                            telefono = dr.GetString(1)
                        });
                return lista;
            }
            finally
            {
                dr.Close();
                objConexion.Close();
            }
        }

        public List<Db_telefonos> consultaSP(string tlf)
        {
            try
            {
                List<Db_telefonos> lista = new List<Db_telefonos>();

                string query = "sp_consultaXprefijo";
                ordenSql = new SqlCommand(query, objConexion);
                ordenSql.CommandType = CommandType.StoredProcedure;
                ordenSql.Parameters.AddWithValue("@prefijo", tlf);
                objConexion.Open();
                dr = ordenSql.ExecuteReader();
                while (dr.Read())
                    lista.Add(
                        new Db_telefonos
                        {
                            nombre = dr.GetString(0),
                            telefono = dr.GetString(1)
                        });
                
                return lista;
            }
            finally
            {
                dr.Close();
                objConexion.Close();
            }
        }

        public void updateTelefono(string tfnViejo,string tfnNuevo)
        {
            try
            {
                using (TransactionScope tran=new TransactionScope())
                {
                    string consulta = "sp_modificarTel";
                    ordenSql = new SqlCommand(consulta, objConexion);
                    ordenSql.CommandType = CommandType.StoredProcedure;
                    ordenSql.Parameters.AddWithValue("@tfnNuevo", tfnNuevo);
                    ordenSql.Parameters.AddWithValue("@tfnViejo", tfnViejo);
                    objConexion.Open();
                    ordenSql.ExecuteNonQuery();
                    tran.Complete();
                    System.Windows.Forms.MessageBox.Show("Transaccion completada.");
                }

            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
