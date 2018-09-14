using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class Socios
    {
        DBHelper oDatos;
        
        public Socios()
        {
            oDatos = new DBHelper();
        }

        public DataTable ConsultarSocio()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from Socios where estado = 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void NuevoSocio(string apellido, string nombre, string direccion, string dni, string fecha)
        {
            SqlCommand comando = new SqlCommand("insert into Socios (nombre, apellido, direccion, dni, fechaNacimiento, estado) values (@nombre, @apellido, @direccion, @dni, @fecha, 'S')");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@fecha", fecha);
            oDatos.ComandoSQL(comando);
        }

        public DataTable BuscarSocio(string apellido, string nombre, string dni)
        {
            DataTable tabla = new DataTable();
            
            return tabla;
        }
    }
}
