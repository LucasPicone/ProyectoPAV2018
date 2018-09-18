using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
     class Categorias
     {
        DBHelper oDatos = new DBHelper();

         public DataTable consultaCategorias()
         {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from categorias where estado = 'S'");
            tabla =  oDatos.ConsultaSQL(comando);
            return tabla;
         }

         public void LlenarComboDisciplinas(ComboBox combo)
         {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from Disciplinas");
            tabla = oDatos.ConsultaSQL(comando);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ToString();
            combo.DisplayMember = tabla.Columns[1].ToString();
         }

         public void conseguirIdDisciplina(string disc)
         {
             
         }

         public void añadirCategoria(string nombre, string edadDesde, string edadHasta, string idDisciplina, string precioInscripcion, string precioCuota)
         {
            SqlCommand sql = new SqlCommand("USE BDBochas Insert into Categorias(idDisciplina, precioCuota, precioInscripcion, nombre, edadDesde, edadHasta, estado) values (@idDisc, @precioCuo, @precioIns, @nombre, @edadDesde, @edadHasta, 'S')");
            sql.Parameters.AddWithValue("@nombre", nombre);
            sql.Parameters.AddWithValue("@edadDesde", edadDesde);
            sql.Parameters.AddWithValue("@edadHasta", edadHasta);
            sql.Parameters.AddWithValue("@idDisc", idDisciplina);
            sql.Parameters.AddWithValue("@precioIns", precioInscripcion);
            sql.Parameters.AddWithValue("@precioCuo", precioCuota);
            oDatos.ComandoSQL(sql);
         }
     } 
}