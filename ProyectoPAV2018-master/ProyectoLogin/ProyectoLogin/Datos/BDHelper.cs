using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoLogin
{
    class BDHelper //Clase que nos ayuda para la conexión con la base de datos.
    {
        SqlConnection conexion;
        string cadenaConexion;
        SqlCommand comando;

        public SqlConnection Conexion //Creo los metodos get y set de los atributos (propeties)
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }

        public BDHelper() //Creo el constructor de la clase
        {
            comando = null;
            conexion = null;
            cadenaConexion = "";
        }

        public BDHelper(string cadenaConexion) //creamos el constructor de la cadena utilizando un parametro
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        public DataTable consultarTabla(string nombreTabla) //creo un metodo para poder acceder a la base de datos y realizar una consulta
        {
            DataTable tabla;
            tabla = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla; //para poder usar el parametro más fácil
            tabla.Load(comando.ExecuteReader());
            desconectar();         
            return tabla;
        }

        public DataTable consultaSQL(string consultaSql)
        {
            DataTable tabla;
            tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        private void conectar() //método para conectarme a la base de datos, es privado pq se va a usar dentro de la clase
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = this.cadenaConexion;
            comando = new SqlCommand();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void desconectar() //método para desconectarse de la base de datos, privado pq se usa dentro de la clase
        {
            conexion.Close();
        }
    }
}
