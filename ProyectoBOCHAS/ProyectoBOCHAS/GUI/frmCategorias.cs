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
            dgvCategorias.Enabled = false;
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

        private bool validarTxtNumericos (TextBox textBox1)
        {
            int i;
            if (textBox1.Text != string.Empty)
            {

                if (!int.TryParse(textBox1.Text, out i)) //valida que sean solo caracteres numericos en los textbox de numeros
                {
                    if (MessageBox.Show("Solo se permiten caracteres numericos", "Error de tipo", MessageBoxButtons.OK) == DialogResult.OK)
                        textBox1.Clear();
                    return false;
                }
                else
                    if (int.Parse(textBox1.Text.ToString()) <= 0 || int.Parse(textBox1.Text.ToString()) >= 99)
                    {
                        if (MessageBox.Show("Esta ingresando valores muy chicos o muy grandes. Debe reintentarlo", "Valores erroneos", MessageBoxButtons.OK) == DialogResult.OK)
                            textBox1.Clear();
                        return false;
                    }
                    else
                        return true;
            }
            return false;
        }

        private void btnAñadir_Click(object sender, EventArgs e) //FALTA VALIDAR LOS PRECIOS
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0)
                MessageBox.Show("No realizo la carga de ningun campo", "Campos vacios", MessageBoxButtons.OK);
            else if ((validarTxtNumericos(txtEdadInicial)) && (validarTxtNumericos(txtEdadTope)))
            {
                categoria.añadirCategoria(txtCategoria.Text, txtEdadInicial.Text, txtEdadTope.Text, cmbDisciplina.SelectedValue.ToString(), txtPrecioInscripcion.Text, txtPrecioCuota.Text);
                llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0)
                MessageBox.Show("Seleccione una fila de la grilla", "Campos vacios", MessageBoxButtons.OK);
            else 
            {
                int id = Int32.Parse(dgvCategorias.CurrentRow.Cells[1].Value.ToString());
                categoria.modificarCategoria(id,txtCategoria.Text, txtEdadInicial.Text, txtEdadTope.Text, cmbDisciplina.SelectedValue.ToString(), txtPrecioInscripcion.Text, txtPrecioCuota.Text);
                llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length == 0 || txtEdadInicial.Text.Length == 0 || txtEdadTope.Text.Length == 0)
                MessageBox.Show("Seleccione una fila de la grilla", "Campos vacios", MessageBoxButtons.OK);
            else
            {
                int id = Int32.Parse(dgvCategorias.CurrentRow.Cells[1].Value.ToString());
                categoria.eliminarCategoria(id, cmbDisciplina.SelectedValue.ToString());
                llenarGrilla(categoria.consultaCategorias(), dgvCategorias);
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