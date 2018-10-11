using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace transaccion
{
    class BDHelper
    {
         string cadenaConexion;
        SqlConnection conexion;
        SqlCommand comando;

        private void Desconectar()
        {
            conexion.Close();
        }

        public BDHelper()
        {
            cadenaConexion = @"Data Source=maquis;Initial Catalog=Pedidos;User ID=avisuales1;password=avisuales1";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        public DataTable ConsultaSQL(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void ComandoSQL(SqlCommand comando)
        {
            //insert/update/delete
            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            Desconectar();
        }

        public void TransaccionSQL(List<SqlCommand> comandos)
        {
            conexion.Open();
            SqlTransaction transaccion;
            transaccion = conexion.BeginTransaction("transaccion");
            try
            {
                for (int i = 0; i < comandos.Count; i++)
                {
                    comandos[i].Connection = conexion;
                    comandos[i].Transaction = transaccion;
                    comandos[i].ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch(Exception e)
            {
                transaccion.Rollback();
                Console.WriteLine(e);
            }
            Desconectar();
        }
    }
}
