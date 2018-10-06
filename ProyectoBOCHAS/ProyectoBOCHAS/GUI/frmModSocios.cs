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
                    grilla.Rows.Add(tabla.Rows[i]["idSocio"], tabla.Rows[i]["apellido"], tabla.Rows[i]["nombre"], tabla.Rows[i]["direccion"], tabla.Rows[i]["dni"], tabla.Rows[i]["fechaNacimiento"], tabla.Rows[i]["nroTelefono"], tabla.Rows[i]["responsableTelefono"]);
                }
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e) //aca no hace falta validar porque busca con o sin parametros #NADIEPARAMETRIZAALBOBBY
        {
            llenarGrilla(socios.BuscarSocio(txtApellido.Text, txtNombre.Text, txtDni.Text), dgvSocios);
        }

        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            txtApellidoNuevo.Enabled = true;
            txtNombreNuevo.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtResponsable.Enabled = true;
            cmdModificar.Enabled = true;
            cmdEliminar.Enabled = true;
            cmdTelefono.Enabled = true;
            cmdCancelar.Enabled = true;
            cmdEliminarTelefono.Enabled = true;
            txtApellidoNuevo.Text = dgvSocios.CurrentRow.Cells[1].Value.ToString();
            txtNombreNuevo.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvSocios.CurrentRow.Cells[6].Value.ToString();
            txtResponsable.Text = dgvSocios.CurrentRow.Cells[7].Value.ToString();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtApellidoNuevo.Text == string.Empty || txtNombreNuevo.Text == string.Empty)
            {
                MessageBox.Show("Debe asegurarse de tener cargados los campos obligatorios", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(MessageBox.Show("¿Seguro desea modificar al socio '" + dgvSocios.CurrentRow.Cells[1].Value.ToString() +" "+ dgvSocios.CurrentRow.Cells[2].Value.ToString() + "'?", "Confirmación de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvSocios.CurrentRow.Cells[0].Value.ToString());
                    socios.ModificarSocio(id, txtApellidoNuevo.Text, txtNombreNuevo.Text, txtDireccion.Text, txtTelefono.Text, txtResponsable.Text);
                    MessageBox.Show("Socio modificado", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdBuscar_Click(sender, e);
                    cmdCancelar_Click(sender, e);
                }
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtApellidoNuevo.Text == string.Empty || txtNombreNuevo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un socio de la lista", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("¿Seguro desea eliminar al socio '" + dgvSocios.CurrentRow.Cells[1].Value.ToString() + " " + dgvSocios.CurrentRow.Cells[2].Value.ToString() + "'?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvSocios.CurrentRow.Cells[0].Value.ToString());
                    socios.EliminarSocio(id);
                    MessageBox.Show("Socio eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdBuscar_Click(sender, e);
                    cmdCancelar_Click(sender, e);
                }
            }
        }

        private void cmdTelefono_Click(object sender, EventArgs e)
        {
            txtTelefonoNuevo.Visible = true;
            txtResponsableNuevo.Visible = true;
            lblNuevoTelefono.Visible = true;
            lblResponsableNuevo.Visible = true;
            cmdAgregar.Visible = true;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtApellidoNuevo.Enabled = false;
            txtNombreNuevo.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtResponsable.Enabled = false;
            cmdModificar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdTelefono.Enabled = false;
            cmdCancelar.Enabled = false;
            txtTelefonoNuevo.Visible = false;
            txtResponsableNuevo.Visible = false;
            lblNuevoTelefono.Visible = false;
            lblResponsableNuevo.Visible = false;
            cmdAgregar.Visible = false;
            cmdEliminarTelefono.Enabled = false;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtTelefonoNuevo.Text == string.Empty || txtResponsableNuevo.Text == string.Empty)
            {
                MessageBox.Show("Debe asegurarse de tener cargados los campos obligatorios", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("¿Seguro desea agregar un telefono a '" + dgvSocios.CurrentRow.Cells[1].Value.ToString() + " " + dgvSocios.CurrentRow.Cells[2].Value.ToString() + "'?", "Confirmación de agregación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvSocios.CurrentRow.Cells[0].Value.ToString());
                    socios.AgregarTelefono(id, txtTelefonoNuevo.Text, txtResponsableNuevo.Text);
                    MessageBox.Show("Telefono agregado", "Agregación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdBuscar_Click(sender, e);
                    cmdCancelar_Click(sender, e);
                }
            }
        }

        private void cmdEliminarTelefono_Click(object sender, EventArgs e)
        {
            if (txtApellidoNuevo.Text == string.Empty || txtNombreNuevo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un socio de la lista", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("¿Seguro desea eliminar al telefono del socio '" + dgvSocios.CurrentRow.Cells[1].Value.ToString() + " " + dgvSocios.CurrentRow.Cells[2].Value.ToString() + "'?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgvSocios.CurrentRow.Cells[0].Value.ToString());
                    string telefono = dgvSocios.CurrentRow.Cells[6].Value.ToString();
                    socios.EliminarTelefono(id, telefono);
                    MessageBox.Show("Telefono eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdBuscar_Click(sender, e);
                    cmdCancelar_Click(sender, e);
                }
            }
        }
    }
}
