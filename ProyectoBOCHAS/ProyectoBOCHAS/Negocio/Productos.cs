using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    public class Productos
    {
        DBHelper oDatos;

        public Productos()
        {
            oDatos = new DBHelper();
        }

        public DataTable consultarProductos()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select p.idProductos, p.descripcion, p.precioUnitario, p.idTipoProducto, tp.nombre from productos p join TipoProducto tp on (p.idTipoProducto = tp.idTipoProducto) where p.estado = 'S' and tp.estado = 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void cargarProducto(int tipo, string descripcion, string precio)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Productos(idTipoProducto,descripcion,precioUnitario,estado) VALUES(@idTipoProducto,@descripcion,@precio,'S')");
            comando.Parameters.AddWithValue("@idTipoProducto",tipo);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            oDatos.ComandoSQL(comando);
        }

        public void modificarProducto(int idTipoProducto, int idProducto, string descripcion, string precio)
        {
            SqlCommand comando = new SqlCommand("UPDATE Productos SET descripcion=@descripcion, idTipoProducto=@idTipoProducto, precioUnitario=@precio WHERE idProductos=@idProducto");
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            oDatos.ComandoSQL(comando);
        }
       
        public void eliminarProducto(int idProducto)
        {
            SqlCommand comando = new SqlCommand("UPDATE Productos SET estado ='N' WHERE idProductos=@idProducto");
            comando.Parameters.AddWithValue("@idProducto",idProducto);
            oDatos.ComandoSQL(comando);
        }
    }
}
