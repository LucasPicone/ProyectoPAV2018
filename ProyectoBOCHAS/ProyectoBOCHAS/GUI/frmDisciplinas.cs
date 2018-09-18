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
    public partial class frmDisciplinas : Form
    {
        Disciplinas Disciplinas = new Disciplinas();
        public frmDisciplinas()
        {
            InitializeComponent();
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {
            llenarGrilla(Disciplinas.ConsultarDisciplinas(), dgvDisciplinas);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idDisciplina"], tabla.Rows[i]["nombre"], tabla.Rows[i]["precioCuota"]);
                }
            }
        }

        private void cmdHabilitar_Click(object sender, EventArgs e)
        {
            cmdHabilitar.Visible = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe cargar todos los campos obligatorios", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Disciplinas.AltaDisciplinas(txtNombre.Text, txtPrecio.Text);
                llenarGrilla(Disciplinas.ConsultarDisciplinas(), dgvDisciplinas);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdHabilitar.Visible = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.ShowDialog();
        }
    }
}
