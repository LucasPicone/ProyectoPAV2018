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
        List<SqlCommand> lista = new List<SqlCommand>();
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
            txtTotal2.Text = txtSubtotal.Text;
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
                transaccion();
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
            SqlCommand comando = new SqlCommand("insert into t_pedidos values (@pedido, @sucursal, @idcliente, @fecha, @subtotal, @descuento, @total)");
            comando.Parameters.AddWithValue("@pedido", txtNroPedido.Text);
            comando.Parameters.AddWithValue("@sucursal", txtSucursal.Text);
            comando.Parameters.AddWithValue("@idcliente", txtNroCliente.Text);
            comando.Parameters.AddWithValue("@fecha", dtpFecha.Value.ToShortDateString());
            double subtotal = Convert.ToDouble(txtDescuento.Text);
            comando.Parameters.AddWithValue("@subtotal", subtotal);
            double descuento = Convert.ToDouble(txtDescuento.Text);
            comando.Parameters.AddWithValue("@descuento", descuento);
            double total = Convert.ToDouble(txtTotal2.Text);
            comando.Parameters.AddWithValue("@total", total);
            lista.Add(comando);
        }

        private void grabarDetalle()
        {
            for(int i=0; i<dgv.Rows.Count; i++)
            {
                SqlCommand comando = new SqlCommand("insert into t_detalle_pedido values(@pedido, @sucursal, @id, @cantidad, @precio)");
                comando.Parameters.AddWithValue("@pedido", txtNroPedido.Text);
                comando.Parameters.AddWithValue("@sucursal", txtSucursal.Text);
                int id = Convert.ToInt32(dgv.Rows[i].Cells["id"].Value.ToString());
                comando.Parameters.AddWithValue("@id", id);
                int cantidad = Convert.ToInt32(dgv.Rows[i].Cells["cantidad"].Value.ToString());
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                double precio = Convert.ToDouble(dgv.Rows[i].Cells["subtotal"].Value.ToString());
                comando.Parameters.AddWithValue("@precio", precio);
                lista.Add(comando);
            }
        }

        private void transaccion()
        {
            grabarPedido();
            grabarDetalle();
            oDatos.TransaccionSQL(lista);
            lista = new List<SqlCommand>();
        }
    }
}
