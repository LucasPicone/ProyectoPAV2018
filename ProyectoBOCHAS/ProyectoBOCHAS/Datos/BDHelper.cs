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

        private void Desconectar()
        {
            conexion.Close();
        }

        public DBHelper()
        {
            cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDBochas;User ID=sa;password=1234";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            //comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public DataTable ConsultaSQL(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void ComandoSQL(SqlCommand comando)
        {
            //insert/update/delete
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Desconectar();
        }
    }
}