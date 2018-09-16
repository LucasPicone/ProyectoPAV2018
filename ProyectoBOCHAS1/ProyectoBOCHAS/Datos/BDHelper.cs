using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoBOCHAS
{
    class DBHelper
    {
        string cadenaConexion;
        SqlConnection conexion;
        SqlCommand comando;

        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public DBHelper()
        {
            cadenaConexion = @"Data Source=USUARIO-3WU9RFG\SQLEXPRESS;Initial Catalog=BDBochas;Integrated Security=True";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public DataTable ConsultaSQL(string strsql)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = strsql;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void ComandoSQL(string strsql)
        {
            //insert/update/delete
            Conectar();
            comando.CommandText = strsql;
            comando.ExecuteNonQuery();
            Desconectar();
        }

        internal void ComandoSQL(SqlCommand sql)
        {
            throw new NotImplementedException();
        }
    }
}