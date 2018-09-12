using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBOCHAS;

namespace ProyectoBOCHAS.GUI
{
    public partial class frmModUser : Form
    {

        Usuario usr = new Usuario();

        public frmModUser()
        {
            InitializeComponent();

        }

        private void frmModUser_Load(object sender, EventArgs e)
        {

        }

        private void habilitarBuscar()
        {
            txtNuevoNombre.Enabled = true;
            txtNuevaPass.Enabled = true;
            cmdModificar.Enabled = true;
            cmdEliminar.Enabled = true;

        }

        private void deshabilitarCancelar()
        {
            txtNuevoNombre.Enabled = false;
            txtNuevaPass.Enabled = false;
            cmdModificar.Enabled = false;
            cmdEliminar.Enabled = false;

        }
           

        private void cmdBscarUsuarioMod_Click(object sender, EventArgs e)
        {
            if (txtModBuscar.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga del usuario", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usr.ValidarUsuario(txtModBuscar.Text, txtPassModificar.Text) == false)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    habilitarBuscar();     
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Eliminación de usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) ;

            else
            {
                usr.EliminarUsuario(txtModBuscar.Text, txtPassModificar.Text);
                MessageBox.Show("Usuario eliminado con éxito", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
           
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombre.Text == string.Empty || txtNuevaPass.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga de alguno de los campos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtNuevoNombre.Text.Length > 20)
                {
                    MessageBox.Show("El nombre de usuario debe tener 20 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtNuevoNombre.Text.Length > 10)
                    {
                        MessageBox.Show("La contraseña debe tener 10 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        usr.ModificarUsuario(txtModBuscar.Text, txtNuevoNombre.Text, txtNuevaPass.Text);
                        MessageBox.Show("El usuario se ha modificado con éxito", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
