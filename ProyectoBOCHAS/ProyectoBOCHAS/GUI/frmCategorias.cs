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

        }

        private void HabilitarNuevo()
        {
            txtCategoria.Enabled = true;
            txtEdadInicial.Enabled = true;
            txtEdadTope.Enabled = true;
            dgvCategorias.Enabled = true;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            cmbDisciplina.Enabled = false;
            btnConsultar.Enabled = false;
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idDisciplina"], tabla.Rows[i]["idCategoria"], tabla.Rows[i]["nombre"], tabla.Rows[i]["edadDesde"], tabla.Rows[i]["edadHasta"], tabla.Rows[i]["precioCuota"], tabla.Rows[i]["precioInscripcion"]);
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
    }
}