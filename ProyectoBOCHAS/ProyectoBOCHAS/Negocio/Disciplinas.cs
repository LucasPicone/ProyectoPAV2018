﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class Disciplinas
    {
        DBHelper oDatos;

        public Disciplinas()
        {
            oDatos = new DBHelper();
        }

        public DataTable ConsultarDisciplinas()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("Select * from Disciplinas where estado = 'S'");
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void AltaDisciplinas(string nombre, string precio)
        {
            SqlCommand comando = new SqlCommand("insert into disciplinas (nombre, precioCuota, estado) values (@nombre, @precio, 'S')");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            oDatos.ComandoSQL(comando);
        }
    }
}
