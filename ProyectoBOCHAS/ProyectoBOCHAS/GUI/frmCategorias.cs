using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoBOCHAS
{
    public partial class frmCategorias : Form
    {
        Categorias categoria = new Categorias();
        Validadores validadores = new Validadores();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            DeshabilitarCarga();
            categoria.LlenarComboDisciplinas(cmbDisciplina);
        }

        private void DeshabilitarCarga()
        {
            txtCategoria.Text = string.Empty;
            txtEdadInicial.Text = string.Empty;
            txtEdadTope.Text = string.Empty;
            txtPrecioCuota.Text = string.Empty;
            txtPrecioInscripcion.Text = string.Empty;
            txtCategoria.Enabled = false;
            txtEdadInicial.Enabled = false;
            txtEdadTope.Enabled = false;
            btnAñadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            cmbDisciplina.Enabled = true;
            btnConsultar.Enabled = true;
            btnNuevaAccion.Enabled = true;
            btnCancelar.Enabled = false;
            txtPrecioCuota.Enabled = false;
            txtPrecioInscripcion.Enabled = false;
            cmbDisciplina.Enabled = false;
        }

        private void HabilitarNuevo()
        {
            btnNuevaAccion.Enabled = false;
            txtCategoria.Enabled = true;
            txtEdadInicial.Enabled = true;
            txtEdadTope.Enabled = true;
            dgvCategorias.Enabled = true;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            txtPrecioCuota.Enabled = true;
            txtPrecioInscripcion.Enabled = true;
            cmbDisciplina.Enabled = true;
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["dnombre"], tabla.Rows[i]["idCategoria"], tabla.Rows[i]["nombre"], tabla.Rows[i]["edadDesde"], tabla.Rows[i]["edadHasta"], tabla.Rows[i]["precioCuota"], tabla.Rows[i]["precioInscripcion"]);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
        }

        private void btnNuevaAccion_Click(object sender, EventArgs e)
        {
            HabilitarNuevo();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0 || txtPrecioCuota.Text.Length == 0 || txtPrecioInscripcion.Text.Length == 0)
                MessageBox.Show("No realizo la carga de ningun campo", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if ((validadores.ValidarTxt(txtPrecioCuota) && (validadores.ValidarTxt(txtPrecioInscripcion))) == false)
                return;
            else if ((validadores.ValidarTxt(txtEdadInicial)) && (validadores.ValidarTxt(txtEdadTope)))
            {
                categoria.añadirCategoria(txtCategoria.Text, txtEdadInicial.Text, txtEdadTope.Text, cmbDisciplina.SelectedValue.ToString(), txtPrecioInscripcion.Text, txtPrecioCuota.Text);
                llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
                MessageBox.Show("Categoria creada", "Creacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0)
                MessageBox.Show("Seleccione una fila de la grilla", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if ((validadores.ValidarTxt(txtPrecioCuota) && (validadores.ValidarTxt(txtPrecioInscripcion))) == false)
                return;
            else if ((validadores.ValidarTxt(txtEdadInicial)) && (validadores.ValidarTxt(txtEdadTope)))
            {
                int id = Int32.Parse(dgvCategorias.CurrentRow.Cells[1].Value.ToString());
                if (MessageBox.Show("¿Seguro desea modificar la categoria " + txtCategoria.Text + "?", "confirmacion de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoria.modificarCategoria(id, txtCategoria.Text, txtEdadInicial.Text, txtEdadTope.Text, cmbDisciplina.SelectedValue.ToString(), txtPrecioInscripcion.Text, txtPrecioCuota.Text);
                    llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
                    MessageBox.Show("Categoria modificada", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0)
                MessageBox.Show("Seleccione una fila de la grilla", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int id = Int32.Parse(dgvCategorias.CurrentRow.Cells[1].Value.ToString());
                if (MessageBox.Show("¿Seguro desea eliminar la categoria " + txtCategoria.Text + "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoria.eliminarCategoria(id, cmbDisciplina.SelectedValue.ToString());
                    llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
                    MessageBox.Show("Categoria eliminada", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (btnNuevaAccion.Enabled)
                return;
            else
            {
                txtCategoria.Text = dgvCategorias.CurrentRow.Cells[2].Value.ToString();
                txtEdadInicial.Text = dgvCategorias.CurrentRow.Cells[3].Value.ToString();
                txtEdadTope.Text = dgvCategorias.CurrentRow.Cells[4].Value.ToString();
                txtPrecioInscripcion.Text = dgvCategorias.CurrentRow.Cells[5].Value.ToString();
                txtPrecioCuota.Text = dgvCategorias.CurrentRow.Cells[6].Value.ToString();
                cmbDisciplina.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCarga();
        }
    }
}