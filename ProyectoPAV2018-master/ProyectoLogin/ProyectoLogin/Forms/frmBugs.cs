using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLogin
{
    public partial class frmBugs : Form
    {
        BDHelper oDatos = new BDHelper(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BUGS;User ID=sa;password=1234");

        public frmBugs()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public bool validarUsuario(string u, string p)
        {
            DataTable tabla;
            tabla = new DataTable();
            string comando = "SELECT * FROM Users WHERE n_usuario = '" + u + "' AND password = '" + p + "'";
            tabla = oDatos.consultaSQL(comando);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void actualizarUsuarioLogueado(string user)
        {
            lblUser.Text = user;
        }

        private void consultaDeBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBugs fc;
            fc = new frmConsultaBugs();
            fc.ShowDialog();
        }
    }
}
