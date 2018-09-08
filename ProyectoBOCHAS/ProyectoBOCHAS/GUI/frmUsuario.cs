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
    public partial class frmUsuario : Form
    {
        Usuario usuario = new Usuario();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idUsuario"], tabla.Rows[i]["nombreUsuario"], tabla.Rows[i]["password"]);
                }
            }
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //esconde la contraseña en el la grilla stackoverflow FTW
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            HabilitarNuevo();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga de alguno de los campos.", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtUsuario.Text.Length > 20)
                {
                    MessageBox.Show("El nombre de usuario debe tener 20 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtPassword.Text.Length > 10)
                    {
                        MessageBox.Show("La contraseña debe tener 10 caracteres o menos", "Validación de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        usuario.CargarUsuario(txtUsuario.Text, txtPassword.Text);
                        llenarGrilla(usuario.ConsultarUsuario(), dgvUsuario);
                        cmdCargar.Enabled = false;
                        cmdNuevo.Enabled = true;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarNuevo();
        }

        private void DeshabilitarNuevo()
        {
            txtPassword.Text = string.Empty;
            txtPassword.Enabled = false;
            txtUsuario.Text = string.Empty;
            txtUsuario.Enabled = false;
            checkBox1.Enabled = false;
            cmdCancelar.Enabled = false;
            cmdNuevo.Enabled = true;
            cmdCargar.Enabled = false;
        }

        private void HabilitarNuevo()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            checkBox1.Enabled = true;
            cmdCargar.Enabled = true;
            cmdCancelar.Enabled = true;
            cmdNuevo.Enabled = false;
        }
    }
}
