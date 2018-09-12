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
    public partial class frmBecas : Form
    {
        Becas becas = new Becas();

        public frmBecas()
        {
            InitializeComponent();
        }

        private void frmBecas_Load(object sender, EventArgs e)
        {
            llenarGrilla(becas.ConsultarBecas(), dgvBecas);
            DataTable tabla = becas.ConsultarBecas();
        //planeo usar un combobox para controlar si quiere hacer una modificacion
            cmbidbeca.DataSource = tabla;
            cmbidbeca.ValueMember = "idbeca";
            cmbidbeca.SelectedIndex = -1;
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idBeca"], tabla.Rows[i]["nombre"], tabla.Rows[i]["descripcion"]);
                }
            }
        }

        private void cmdNueva_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
                MessageBox.Show("Debe cargar el nombre de la nueva Beca", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                becas.CargarBeca(txtNombre.Text, txtDescripcion.Text);
                llenarGrilla(becas.ConsultarBecas(), dgvBecas);
                MessageBox.Show("Beca creada", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdHabilitar_Click(object sender, EventArgs e)
        {
            cmdNueva.Visible = true;
            cmdModificar.Visible = true;
            cmdEliminar.Visible = true;
            cmdCancelar.Visible = true;
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            cmdHabilitar.Visible = false;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdNueva.Visible = false;
            cmdModificar.Visible = false;
            cmdEliminar.Visible = false;
            cmdCancelar.Visible = false;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cmdHabilitar.Visible = true;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
