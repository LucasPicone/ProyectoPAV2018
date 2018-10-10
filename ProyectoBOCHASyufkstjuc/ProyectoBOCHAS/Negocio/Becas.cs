using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    public class Becas
    {
        DBHelper oDatos;

        public Becas()
        {
            oDatos = new DBHelper();
        }

        public DataTable ConsultarBecas()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from Becas where estado = 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void CargarBeca(string nombre, string descripcion)
        {
            SqlCommand comando = new SqlCommand("insert into Becas (nombre, descripcion, estado) values (@nombre, @descripcion, 'S')");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            oDatos.ComandoSQL(comando);
        }

        public void ModificarBeca(int idBeca, string nombre, string descripcion)
        {
            SqlCommand comando = new SqlCommand("update Becas set nombre = @nombre, descripcion = @descripcion where idBeca = @idBeca");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@idBeca", idBeca);
            oDatos.ComandoSQL(comando);
        }

        public void EliminarBeca(int idBeca)
        {
            SqlCommand comando = new SqlCommand("update Becas set estado = 'N' where idBeca = @idBeca");
            comando.Parameters.AddWithValue("@idBeca", idBeca);
            oDatos.ComandoSQL(comando);
        }
    }
}
