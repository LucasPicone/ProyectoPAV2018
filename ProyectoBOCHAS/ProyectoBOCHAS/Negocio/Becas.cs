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
            tabla = oDatos.ConsultarTabla("Becas");
            return tabla;
        }

        public void CargarBeca(string nombre, string descripcion)
        {
            string strsql = "insert into Becas (nombre, descripcion, estado) values ('" + nombre + "', '" + descripcion + "', 'S')";
            oDatos.ComandoSQL(strsql);
        }
    }
}
