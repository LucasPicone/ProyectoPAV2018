using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoLogin
{
    public partial class frmPrincipal : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        DataTable tabla;
        String cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Pedidos;User ID=sa;password=1234";

        private string user = "admin";
        private string pass = "admin";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;

            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText="select * from T_CLIENTES";
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            grdCliente.DataSource = tabla;
        }
        public bool validarUsuario(string u, string p)
        {
            if (this.user == u && this.pass == p)
                return true;
            else
                return false;
        }
    }
}
