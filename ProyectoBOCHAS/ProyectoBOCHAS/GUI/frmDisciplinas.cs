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
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
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
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
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
            if (txtNombre.Text == string.Empty)
                MessageBox.Show("Debe seleccionar una disciplina de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("¿Seguro desea eliminar la disciplina " + txtNombre.Text + "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Disciplinas.EliminarDisciplina(txtNombre.Text);
                MessageBox.Show("Disciplina eliminada", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrilla(Disciplinas.ConsultarDisciplinas(), dgvDisciplinas);
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtPrecio.Text == string.Empty)
                MessageBox.Show("Deben estar cargados ambos campos", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (MessageBox.Show("¿Seguro desea modificar la disciplina " + txtNombre.Text + "?", "Confirmación modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = dgvDisciplinas.CurrentRow.Cells[0].Value.ToString();
                Disciplinas.ModificarDisciplina(id, txtNombre.Text, txtPrecio.Text);
                MessageBox.Show("Disciplina modificada", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarGrilla(Disciplinas.ConsultarDisciplinas(), dgvDisciplinas);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            cmdHabilitar.Visible = true;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void cmdCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.ShowDialog();
        }

        private void dgvDisciplinas_SelectionChanged(object sender, EventArgs e)
        {
            if (cmdHabilitar.Visible)
                return;
            else
            {
                txtNombre.Text = dgvDisciplinas.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgvDisciplinas.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
