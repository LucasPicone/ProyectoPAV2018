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
            SqlCommand comando = new SqlCommand("select * from Socios s join TelefonosXSocios txs on (s.idSocio = txs.idSocio) where s.estado = 'S' and txs.estado like 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void NuevoSocio(string apellido, string nombre, string direccion, string dni, string fecha, string telefono, string responsable)
        {
            SqlCommand comando = new SqlCommand("insert into Socios (nombre, apellido, direccion, dni, fechaNacimiento, estado) values (@nombre, @apellido, @direccion, @dni, @fecha, 'S')");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@fecha", fecha);
            oDatos.ComandoSQL(comando);
            comando = new SqlCommand("select idSocio from Socios where estado = 'S' and apellido = @apellido and nombre = @nombre and dni = @dni");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@dni", dni);
            DataTable tabla = new DataTable();
            tabla = oDatos.ConsultaSQL(comando);
            string id = tabla.Rows[0][0].ToString();
            comando = new SqlCommand("insert into TelefonosXSocios (idSocio, nroTelefono, responsableTelefono, estado) values (@id, @telefono, @responsable, 'S')");
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@responsable", responsable);
            oDatos.ComandoSQL(comando);
        }

        public DataTable BuscarSocio(string apellido, string nombre, string dni) //Busca con o sin parametros
        {
            DataTable tabla = new DataTable();
            string strsql = "select * from Socios s join TelefonosXSocios txs on (s.idSocio = txs.idSocio) where s.estado = 'S' and txs.estado like 'S' and apellido ";
            if (apellido == string.Empty)
                strsql += "like '%' and nombre ";
            else
                strsql += "= @apellido and nombre ";
            if (nombre == string.Empty)
                strsql += "like '%' and dni ";
            else
                strsql += "= @nombre and dni ";
            if (dni == string.Empty)
                strsql += "like '%'";
            else
                strsql += "= @dni";
            SqlCommand comando = new SqlCommand(strsql);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@dni", dni);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void ModificarSocio(int id, string apellido, string nombre, string direccion, string telefono, string responsable)
        {
            SqlCommand comando = new SqlCommand("update Socios set apellido = @apellido, nombre = @nombre, direccion = @direccion where idSocio = @id");
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@id", id);
            oDatos.ComandoSQL(comando);
            comando = new SqlCommand("update TelefonosXSocios set nroTelefono = @telefono, responsableTelefono = @responsable where idSocio = @id");
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@responsable", responsable);
            comando.Parameters.AddWithValue("@id", id);
            oDatos.ComandoSQL(comando);
        }

        public void AgregarTelefono(int id, string telefono, string responsable)
        {
            SqlCommand comando = new SqlCommand("insert into TelefonosXSocios (idSocio, nroTelefono, responsableTelefono, estado) values (@id, @telefono, @responsable, 'S')");
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@responsable", responsable);
            oDatos.ComandoSQL(comando);
        }

        public void EliminarSocio(int id)
        {
            SqlCommand comando = new SqlCommand("update socios set estado = 'N' where idSocio = @id");
            comando.Parameters.AddWithValue("@id", id);
            oDatos.ComandoSQL(comando);
            comando = new SqlCommand("update TelefonosXSocios set estado = 'N' where idSocio = @id");
            comando.Parameters.AddWithValue("@id", id);
            oDatos.ComandoSQL(comando);
        }

        public void EliminarTelefono(int id, string telefono)
        {
            SqlCommand comando = new SqlCommand("update TelefonosXSocios set estado = 'N' where idSocio = @id and nroTelefono = @telefono");
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@telefono", telefono);
            oDatos.ComandoSQL(comando);
        }
    }
}
