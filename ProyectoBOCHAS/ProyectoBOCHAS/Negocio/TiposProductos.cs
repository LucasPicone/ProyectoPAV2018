using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS.Negocio
{
    public class TiposProductos
    {
        DBHelper oDatos;

        public TiposProductos()
        {
            oDatos = new DBHelper();
        }

        public DataTable consultarTiposProducto()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT * FROM TipoProducto WHERE estado='S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void cargarTipoProducto(string nombre)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO TipoProducto(nombre) VALUES(@nombre)");
            comando.Parameters.AddWithValue("@nombre", nombre);
            oDatos.ComandoSQL(comando);
        }

        public void modificarTipoProducto(int idTipoProducto, string nombre)
        {
            SqlCommand comando = new SqlCommand("UPDATE TipoProducto SET nombre=@nombre WHERE idTipoProducto = @idTipoProducto");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            oDatos.ComandoSQL(comando);
        }

        public void eliminarTipoProducto(int idTipoProducto)
        {
            SqlCommand comando = new SqlCommand("UPDATE TipoProducto SET estado='N' WHERE idTipoProducto = @idTipoProducto");
            comando.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            oDatos.ComandoSQL(comando);
        }

        public int traerIdTipo(string nombre) //para saber el id asociado a un string de tipo de dato, ver en la carga de frmProducto
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT idTipoProducto FROM TipoProducto WHERE nombre=@nombre");
            comando.Parameters.AddWithValue("@nombre", nombre);
            tabla = oDatos.ConsultaSQL(comando);

            int tipo = int.Parse(tabla.Rows[0][0].ToString()); //stackoverflow master race
            return tipo;

        }

    }
}
