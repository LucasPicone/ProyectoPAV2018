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
    public partial class frmPrincipal : Form
    {
        private string user = "admin";
        private string pass = "admin";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();
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
