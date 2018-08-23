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
        BDHelper oDatos = new BDHelper(@"Data Source=maquis;Initial Catalog=BUGSHISTO73280;User ID=avisuales1;password=avisuales1");
        public frmConsultaBugs()
        {
            InitializeComponent();
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            cargarCombo(cmbEstado, "Estados");
            cargarCombo(cmbAsignado, "Users");
            cargarCombo(cmbCriticidad, "Criticidades");
            cargarCombo(cmbPrioridad, "Prioridades");
            grdBugs.DataSource = oDatos.consultarTabla("Bugs");
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = oDatos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }
    }
}
