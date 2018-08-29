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

        frmBugs fp = new frmBugs();
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
                
                if (fp.validarUsuario(txtUser.Text, txtPassword.Text) == true)
                {
                    MessageBox.Show("Login OK",
                                    "CASI HACKER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    fp.actualizarUsuarioLogueado(txtUser.Text);
                    limpiarInfoLogin();
                    fp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrectas",
                    "Validacion de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    limpiarInfoLogin();
                    this.txtUser.Focus();
                }
            }
        }

        private void limpiarInfoLogin()
        {
            this.txtUser.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
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

        private void cmbLabsis_Click(object sender, EventArgs e)
        {
            string cadena = @"Data Source=maquis;Initial Catalog=clase73280;User ID=avisuales1;password=avisuales1";
            fp.cambioStringConexion(cadena);
        }

        private void cmbCasa_Click(object sender, EventArgs e)
        {
            string cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BUGS;User ID=sa;password=1234";
            fp.cambioStringConexion(cadena);
        }
    }
}
