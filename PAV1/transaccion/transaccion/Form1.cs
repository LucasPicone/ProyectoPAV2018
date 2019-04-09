using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace transaccion
{
    public partial class frmPedidos : Form
    {
        BDHelper oDatos = new BDHelper();
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int numero;
            if (txtNroCliente.Text == "")
            {
                MessageBox.Show("Debe Ingresar un cliente", "   puto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCliente.Text = string.Empty;
            }
            else if (Int32.TryParse(txtNroCliente.Text, out numero))
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand("select n_clientes from T_CLIENTES where id_clientes = @numero");
                comando.Parameters.AddWithValue("@numero", numero);
                tabla = oDatos.ConsultaSQL(comando);
                if (tabla.Rows.Count > 0)
                {
                    txtCliente.Text = tabla.Rows[0][0].ToString();
                }
                else
                    MessageBox.Show("Cliente no encontrado", "chabon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("tenias que cargar un numero lince");
            }
        }

        private void cmdBuscarArticulo_Click(object sender, EventArgs e)
        {
            int numero;
            if (txtNroArticulo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un articulo", "   puto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtArticulo.Text = string.Empty;
            }
            else if (Int32.TryParse(txtNroArticulo.Text, out numero))
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand("select n_articulo, precio from T_ARTICULOS where id_articulo = @numero");
                comando.Parameters.AddWithValue("@numero", numero);
                tabla = oDatos.ConsultaSQL(comando);
                if (tabla.Rows.Count > 0)
                {
                    txtArticulo.Text = tabla.Rows[0][0].ToString();
                    txtPrecio.Text = tabla.Rows[0][1].ToString();
                }
                else
                    MessageBox.Show("Articulo no encontrado", "chabon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("tenias que cargar un numero lince");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty || txtPrecio.Text == string.Empty)
            { }
            else
            {
                double a, b;
                a = Convert.ToDouble(txtCantidad.Text);
                b = Convert.ToDouble(txtPrecio.Text);
                txtTotal.Text = (a * b).ToString();
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtCantidad.Text, txtNroArticulo.Text, txtArticulo.Text, txtPrecio.Text, txtTotal.Text);
            txtSubtotal.Text = calculartotal().ToString();
        }

        private double calculartotal()
        {
            double total = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if (validar() && dgv.Rows.Count > 0)
            {
                grabarPedido();
                grabarDetalle();
            }
            else
                MessageBox.Show("no cargo un carajo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validar()
        {
            if (dtpFecha.Value == null)
            {
                MessageBox.Show("debe ingresar fecha", "", MessageBoxButtons.OK);
                dtpFecha.Focus();
                return false;
            }
            if(txtSucursal.Text == string.Empty)
            {
                cancer(txtSucursal);
                return false;
            }
            if(txtNroPedido.Text == string.Empty)
            {
                cancer(txtNroPedido);
                return false;
            }
            if(txtNroCliente.Text == string.Empty)
            {
                cancer(txtNroCliente);
                return false;
            }
            return true;
        }
        private void cancer(TextBox txt)
        {
            MessageBox.Show("tenias que ingresar algo", "", MessageBoxButtons.OK);
            txt.ForeColor = Color.Red;
            txt.Focus();
        }
        
        private void grabarPedido()
        {
            //validarPK();
            
        }

        private void grabarDetalle()
        {
            for(int i=0; i<dgv.Rows.Count; i++)
            {
                //comando sql
            }
        }
    }
}
