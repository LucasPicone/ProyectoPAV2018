using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLogin
{
    public partial class frmConsultaBugs : Form
    {
        BDHelper oDatos = new BDHelper(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BUGS;User ID=sa;password=1234"); // intaciar la clase que cree en un objeto datos para poder usarlo
        //BDHelper oDatos;
        public frmConsultaBugs()
        {
            InitializeComponent();
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            this.cargarCombo(cmbEstado, "Estados"); //  utilizo el metodo que cree para cargar todos los combos del form
            this.cargarCombo(cmbCriticidad, "Criticidades");
            this.cargarCombo(cmbPrioridad, "Prioridades");
            this.cargarCombo(cmbProducto, "Productos");
            this.cargarCombo(cmbAsignado, "Perfiles");
        }

        private void cargarCombo(ComboBox combo,string nombreTabla) //creo un metodo para cargar los combos 
        {
            DataTable tabla = oDatos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.grdBugs.DataSource = oDatos.consultarTabla("Bugs");
        }

        //public void recibirbdHelper(BDHelper oDatos)
        //{
            //this.oDatos = oDatos;
        //}
    }
}