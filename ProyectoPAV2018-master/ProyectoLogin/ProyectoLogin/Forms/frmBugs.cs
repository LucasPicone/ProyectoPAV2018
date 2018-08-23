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
        BDHelper oDatos = new BDHelper();
        /*SqlConnection conexion;
        SqlCommand comando;
        DataTable tabla;
        //hacer la conexion a la base BUGS o BUGSHISTO
        String cadenaConexion = @"";
        */
        //hay que hacer el login contra la BD
        private string user = "admin";
        private string pass = "admin";
        
        public frmBugs()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //oDatos.cargarCombo("Prioridad");
        }

        public bool validarUsuario(string u, string p)
        {
            if (this.user == u && this.pass == p)
                return true;
            else
                return false;
        }

        private void cmdConsultaBugs_Click(object sender, EventArgs e)
        {
            frmConsultaBugs fc = new frmConsultaBugs();
            fc.ShowDialog();
        }
    }
}
