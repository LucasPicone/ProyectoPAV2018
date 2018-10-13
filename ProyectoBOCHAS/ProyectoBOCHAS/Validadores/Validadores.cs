using System.Windows.Forms;

namespace ProyectoBOCHAS
{
    class Validadores
    {
        public Validadores()
        {

        }

        public bool ValidarTxt(TextBox textBox1)
        {
            int i;
            if (textBox1.Text != string.Empty)
            {

                if (!int.TryParse(textBox1.Text, out i)) //valida que sean solo caracteres numericos en los textbox de numeros
                {
                    MessageBox.Show("Solo se permiten caracteres numericos", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    return false;
                }
                else
                    if (int.Parse(textBox1.Text.ToString()) <= 0)
                {
                    MessageBox.Show("No puede ingresar valores negativos", "Valores erroneos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    return false;
                }
                else
                    return true;
            }
            return false;
        }
    }
}
