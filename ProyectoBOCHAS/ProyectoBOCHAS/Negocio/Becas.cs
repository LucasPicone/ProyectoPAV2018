using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            string strsql = "select * from Becas where estado = 'S'";
            tabla = oDatos.ConsultaSQL(strsql);
            return tabla;
        }

        public void CargarBeca(string nombre, string descripcion)
        {
            string strsql = "insert into Becas (nombre, descripcion, estado) values ('" + nombre + "', '" + descripcion + "', 'S')";
            oDatos.ComandoSQL(strsql);
        }

        public void ModificarBeca(int idBeca, string nombre, string descripcion)
        {
            string strsql = "update Becas set nombre = '" + nombre + "', descripcion = '" + descripcion + "' where idBeca = " + idBeca;
            oDatos.ComandoSQL(strsql);
        }

        public void EliminarBeca(int idBeca)
        {
            string strsql = "update Becas set estado = 'N' where idBeca = " + idBeca;
            oDatos.ComandoSQL(strsql);
        }
    }
}
