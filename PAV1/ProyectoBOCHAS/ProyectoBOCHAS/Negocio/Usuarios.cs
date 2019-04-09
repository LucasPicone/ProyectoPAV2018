using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class Usuario
    {
        DBHelper oDatos;

        public Usuario()
        {
            oDatos = new DBHelper();
        }

        public bool ValidarUsuario(string usuario, string password)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE nombreUsuario = @user AND password = @pass AND estado = 'S'");
            comando.Parameters.AddWithValue("@user", usuario);
            comando.Parameters.AddWithValue("@pass", password);
            oDatos.ConsultaSQL(comando);
            tabla = oDatos.ConsultaSQL(comando);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataTable ConsultarUsuario()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from Usuarios where estado = 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void CargarUsuario(string usuario, string password)
        {
            SqlCommand comando = new SqlCommand("insert into Usuarios (nombreUsuario, password, estado) values (@user, @pass, 'S')");
            comando.Parameters.AddWithValue("@user", usuario);
            comando.Parameters.AddWithValue("@pass", password);
            oDatos.ComandoSQL(comando);
        }

        public void EliminarUsuario(string usuario, string password)
        {
            SqlCommand comando = new SqlCommand("use BDBochas Update Usuarios set estado = 'N' where nombreUsuario = @user and password = @pass");
            comando.Parameters.AddWithValue("@user", usuario);
            comando.Parameters.AddWithValue("@pass", password);
            oDatos.ComandoSQL(comando);

        }

        public void ModificarUsuario(string usuario,string usuarioNuevo,string passwordNueva)
        {
            SqlCommand comando = new SqlCommand("use BDBochas Update Usuarios set nombreUsuario = @usern, password = @pass where nombreUsuario = @userv");
            comando.Parameters.AddWithValue("@userv", usuario);
            comando.Parameters.AddWithValue("@pass", passwordNueva);
            comando.Parameters.AddWithValue("@usern", usuarioNuevo);
            oDatos.ComandoSQL(comando);
        }

    }
}
