using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoLogin
{
    class BDHelper
    {
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        
        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public BDHelper()
        {
            cadenaConexion = "";
            conexion = null;
            comando = null;
        }

        public BDHelper(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        private void conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = this.cadenaConexion;
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable consultaSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
    }
}
