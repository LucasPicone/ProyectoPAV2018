using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProyectoBOCHAS
{
     class Categorias
    {
        DBHelper oDatos = new DBHelper();

        public DataTable consultaCategorias(string disciplina)
        { 
          DataTable tabla = new DataTable();
          string strSql1 = "Select c.idCategoria, c.nombre, c.edadDesde, c.edadHasta from CategoriasXDisciplinas cd Join Categorias c on (cd.idCategoria = c.idCategoria) join Disciplinas d on (d.idDisciplina = cd.idDisciplina) ";
          string strSql2 = "where d.nombre = '" + disciplina + "'";
          string strSql = strSql1 + strSql2;
          tabla =  oDatos.ConsultaSQL(strSql);
          return tabla;
        }

        public void LlenarComboDisciplinas(ComboBox combo)
        {
            DataTable tabla = new DataTable();
            string sql = "Select * from Disciplinas";
            tabla = oDatos.ConsultaSQL(sql);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ToString();
            combo.DisplayMember = tabla.Columns[1].ToString();
           
        }
         public void añadirCategoria (string nombre, string edadDesde, string edadHasta)
        {
            string strsql = "Use BDBochas Insert into Categorias (nombre, edadDesde, edadHasta) values ('" + nombre + "', " + edadDesde + ", " + edadHasta + ")";
            oDatos.ComandoSQL(strsql); 
        }

         public void conseguirIdDisciplina(string disc)
         {
             
         }

         public void añadirCategxDisc(int idCategoria, int idDisciplina, int precioInscripcion, int precioCuota)
         {
             SqlCommand sql = new SqlCommand("USE BDBochas Insert into CategoriasXDisciplinas (idCategoria, idDisciplina, precioCuota, precioInscripcion) values (@idCat, @idDisc, @precioCuo, @precioIns)");
             sql.Parameters.AddWithValue("@idCat", idCategoria);
             sql.Parameters.AddWithValue("@idDis", idDisciplina);
             sql.Parameters.AddWithValue("@precioIns", precioInscripcion);
             sql.Parameters.AddWithValue("@precioCuo", precioCuota);
             oDatos.ComandoSQL(sql);
          
         }
    }
        
        
}
     
   
    
        
    

