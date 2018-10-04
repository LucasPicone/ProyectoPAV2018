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
        string cadenaConexion = "Data Source=maquis;Initial Catalog=Pedidos;User ID=avisuales1;password=avisuales1";
        SqlConnection conexion;

        public BDHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public DataTable ConsultaSQL(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public void ComandoSQL(SqlCommand comando)
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
