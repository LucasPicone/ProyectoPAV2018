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
    public partial class frmModSocios : Form
    {
        Socios socios = new Socios();
        public frmModSocios()
        {
            InitializeComponent();
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty || txtNombre.Text == string.Empty || txtDni.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar al menos un campo de busqueda", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }
    }
}
