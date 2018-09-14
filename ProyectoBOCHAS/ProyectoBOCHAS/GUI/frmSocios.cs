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
    public partial class frmSocios : Form
    {
        Socios socios = new Socios();

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            llenarGrilla(socios.ConsultarSocio(), dgvSocios);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idSocio"], tabla.Rows[i]["apellido"], tabla.Rows[i]["nombre"], tabla.Rows[i]["direccion"], tabla.Rows[i]["dni"], tabla.Rows[i]["fechaNacimiento"]);
                }
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty || txtDireccion.Text == string.Empty || txtDni.Text == string.Empty)
            {
                MessageBox.Show("No realizo la carga de algun campo obligatorio", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                socios.NuevoSocio(txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtDni.Text, dtpFecha.Value.ToString("MM/dd/yyyy"));
                llenarGrilla(socios.ConsultarSocio(), dgvSocios);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdHabilitar.Visible = true;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtDni.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            frmModSocios frmModSocios = new frmModSocios();
            frmModSocios.ShowDialog();
        }

        private void cmdHabilitar_Click(object sender, EventArgs e)
        {
            cmdHabilitar.Visible = false;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtDni.Enabled = true;
            dtpFecha.Enabled = true;
        }
    }
}
