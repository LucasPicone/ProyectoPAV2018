using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBOCHAS
{
    public partial class frmLogin : Form
    {
        Usuario usuario = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = cmdIngresar;
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
        
        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsuario.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar?", "Confirmación de Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga de alguno de los campos.", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
            }
            else
            {
                if (usuario.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
                {
                    MessageBox.Show("Ingreso Exitoso", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal fp = new frmPrincipal();
                    fp.ShowDialog();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }
            }
        }

        private void cmbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
