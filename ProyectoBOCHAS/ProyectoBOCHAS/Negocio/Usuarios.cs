using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            string comando = "SELECT * FROM Usuarios WHERE nombreusuario = '" + usuario + "' AND password = '" + password + "'";
            tabla = oDatos.ConsultaSQL(comando);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataTable ConsultarUsuario()
        {
            DataTable tabla = new DataTable();
            string strsql = "select * from Usuarios where estado = 'S'";
            tabla = oDatos.ConsultaSQL(strsql);
            return tabla;
        }

        public void CargarUsuario(string usuario, string password)
        {
            string strsql = "insert into Usuarios (nombreUsuario, password, estado) values ('" + usuario + "', '" + password + "', 'S')";
            oDatos.ComandoSQL(strsql);
        }
    }
}
