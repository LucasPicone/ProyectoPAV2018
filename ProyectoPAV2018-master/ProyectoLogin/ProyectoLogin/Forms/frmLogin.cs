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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Flaco tenias que cargar los campos", 
                    "Validacion de datos", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                frmBugs fp=new frmBugs();
                if (fp.validarUsuario(txtUser.Text, txtPassword.Text) == true)
                {
                    MessageBox.Show("Login OK",
                                    "CASI HACKER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.txtPassword.Text = string.Empty;
                    this.txtUser.Text = string.Empty;
                    fp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrectas",
                    "Validacion de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    this.txtUser.Text = string.Empty;
                    this.txtPassword.Text = string.Empty;
                    this.txtUser.Focus();
                }
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de abandonar la aplicacion",
                                "Salida",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
