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
    public partial class frmTipoProducto : Form
    {
        TiposProductos tipo = new TiposProductos();

        public void habilitarMod()
        {
            //Habilita opciones de modificacion

            gbxMod.Enabled = true;
            lblMod.Enabled = true;
            lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Pone el texto en negrita
            cmdMod.Enabled = true;
            cmdEliminar.Enabled = true;
            txtCarga.Enabled = true;

            lbl1.Enabled = true;
            lbl2.Enabled = true;
            txtMod.Enabled = true;
            txtMod2.Enabled = true;



        }

        public void deshabilitarMod()
        {
            gbxMod.Enabled = false;
            lblMod.Enabled = false;
            lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Pone el texto en negrita
            cmdMod.Enabled = false;
            cmdEliminar.Enabled = false;
            txtCarga.Enabled = false;


        }

        public void habilitarCarga()
        {
            gbxCarga.Enabled = true;
            lblCarga.Enabled = true;
            lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCarga.Enabled = true;
            cmdCarga.Enabled = true;

        }

        public void deshabilitarCarga()
        {
            gbxCarga.Enabled = false;
            lblCarga.Enabled = false;
            lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCarga.Enabled = false;
            cmdCarga.Enabled = false;
        }

        public void habilitarPrincipal()
        {
            gbxPrincipal.Enabled = true;
            cmdModElini.Enabled = true;
            cmdCargarTipoIni.Enabled = true;
            lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void deshabilitarPrincipal()
        {
            gbxPrincipal.Enabled = false;
            cmdModElini.Enabled = false;
            cmdCargarTipoIni.Enabled = false;
            lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      

        }

        
        private void llenarGrilla(DataTable tabla, DataGridView grilla)
        {
            grilla.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grilla.Rows.Add(tabla.Rows[i]["idTipoProducto"], tabla.Rows[i]["nombre"]);
                }
            }
        }

        public frmTipoProducto()
        {
            InitializeComponent();
            llenarGrilla(tipo.consultarTiposProducto(), dgvTipoProducto);
        }


        private void cmdCargarTipoIni_Click(object sender, EventArgs e)
        {
            deshabilitarPrincipal();
            habilitarCarga();

        }

        private void cmdModElini_Click(object sender, EventArgs e)
        {
            deshabilitarPrincipal();
            habilitarMod();
        }

        private void cmdCarga_Click(object sender, EventArgs e)
        {
            if(txtCarga.Text == string.Empty)
                MessageBox.Show("Debe cargar el nombre del nuevo tipo", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                tipo.cargarTipoProducto(txtCarga.Text);
                llenarGrilla(tipo.consultarTiposProducto(), dgvTipoProducto);
                MessageBox.Show("Tipo agregado", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habilitarPrincipal();
                deshabilitarMod();
                deshabilitarCarga();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtMod.Text == string.Empty)
                MessageBox.Show("No se ha seleccionado el tipo a eliminar", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int id = Int32.Parse(dgvTipoProducto.CurrentRow.Cells[0].Value.ToString()); //devuelve el id del elemento seleccionado como int
                tipo.eliminarTipoProducto(id);
                llenarGrilla(tipo.consultarTiposProducto(), dgvTipoProducto);
                MessageBox.Show("Tipo eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

            }

        }

        private void dgvTipoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tipo = dgvTipoProducto.CurrentRow.Cells[1].Value.ToString();
            txtMod.Text = tipo;
        }

        private void cmdMod_Click(object sender, EventArgs e)
        {
            if (txtMod.Text == string.Empty)
                MessageBox.Show("No se ha seleccionado el tipo a modificar", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(txtMod2.Text == string.Empty)
                MessageBox.Show("No se ha cargado el nuevo nombre del tipo", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                {

                int id = Int32.Parse(dgvTipoProducto.CurrentRow.Cells[0].Value.ToString()); //devuelve el id del elemento seleccionado como int
                tipo.modificarTipoProducto(id, txtMod2.Text);
                llenarGrilla(tipo.consultarTiposProducto(), dgvTipoProducto);
                MessageBox.Show("Tipo modificado con exito", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frmTipoProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
