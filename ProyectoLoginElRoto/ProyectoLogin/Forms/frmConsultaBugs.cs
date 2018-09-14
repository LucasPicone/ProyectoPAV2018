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
        //BDHelper oDatos = new BDHelper(@"Data Source=maquis;Initial Catalog=avisuales_73280;User ID=avisuales1;password=avisuales1"); // intaciar la clase que cree en un objeto datos para poder usarlo
        BDHelper oDatos;
        public frmConsultaBugs(BDHelper helper)
        {
            InitializeComponent();
            oDatos = helper;
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
            string strsql = "select b.id_bug, b.titulo, p.nombre, b.fecha_alta, e.n_estado, c.n_criticidad, pr.n_prioridad from bugs b, Estados e, Productos p, Prioridades pr, Criticidades c WHERE 1=1 ";
            strsql += "and b.fecha_alta>= " + dtpFechaDesde.Value.ToShortDateString() + " ";
            strsql += "AND (b.id_estado=e.id_estado) and (b.id_criticidad=c.id_criticidad) and (b.id_prioridad=pr.id_prioridad) and (b.id_producto=p.id_producto) ORDER BY fecha_alta DESC";
            this.grdBugs.DataSource = oDatos.consultaSQL(strsql);
        }
    }
}