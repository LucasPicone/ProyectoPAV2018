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
    public partial class frmProductos : Form
    {
        Productos producto = new Productos();

        TiposProductos tipos = new TiposProductos();

        public frmProductos()
        {
            InitializeComponent();
            llenarGrilla(producto.consultarProductos(), dgvProductos);
        }

        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idProductos"], tabla.Rows[i]["descripcion"],tabla.Rows[i]["precioUnitario"],tabla.Rows[i]["idTipoProducto"]);
                }
            }
        }

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
                
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)//pone la descripcion de la fila seleccionada en el txtDescripcion
        {
            string prod = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = prod;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Text == string.Empty || txtPrecio.Text == string.Empty || cbxTipo.Text ==string.Empty)
                MessageBox.Show("Debe cargar un valor en todos los campos", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int tipo = tipos.traerIdTipo(cbxTipo.Text);
                producto.cargarProducto(tipo, txtDescripcion.Text, txtPrecio.Text);
                llenarGrilla(producto.consultarProductos(), dgvProductos);
                MessageBox.Show("Producto agregado", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTipoProducto frmTipoProducto = new frmTipoProducto();
            frmTipoProducto.ShowDialog();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenarCombo(cbxTipo, tipos.consultarTiposProducto(), "n", "nombre");

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            

            if (txtDescripcion.Text == string.Empty)
                MessageBox.Show("Debe seleccionar un producto en la lista", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("¿Seguro desea eliminar el producto '" + txtDescripcion.Text + "'?", "Confimación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                    producto.eliminarProducto(id);
                    MessageBox.Show("Producto eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrilla(producto.consultarProductos(), dgvProductos);

                }

            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Text == string.Empty)
                MessageBox.Show("Debe seleccionar un producto y llenar los campos con los nuevos valores", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int tipo = tipos.traerIdTipo(cbxTipo.Text);
                int id = Int32.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString()); //devuelve el id del elemento seleccionado como int
                producto.modificarProducto(tipo, id, txtDescripcion.Text, txtPrecio.Text);
                llenarGrilla(producto.consultarProductos(), dgvProductos);
                MessageBox.Show("Producto modificado", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

