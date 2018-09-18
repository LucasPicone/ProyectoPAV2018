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
    public partial class frmPrincipal : Form
    {
        Usuario usuario = new Usuario();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmación de cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmBecas frmBecas = new frmBecas();
            frmBecas.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSocios frmSocios = new frmSocios();
            frmSocios.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDisciplinas frmDisciplinas = new frmDisciplinas();
            frmDisciplinas.Show();
        }
    }
}
