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
    public partial class reporte2 : Form
    {
        BDHelper oDatos = new BDHelper();
        public reporte2()
        {
            InitializeComponent();
        }

        private void reporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BUGSDataSet.Bugs' Puede moverla o quitarla según sea necesario.
            //this.BugsTableAdapter.Fill(this.BUGSDataSet.Bugs);

            //this.reportViewer1.RefreshReport();
        }

        private void cmdBotoncito_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from bugs");
            this.BugsBindingSource.DataSource = oDatos.ConsultaSQL(comando);
            this.reportViewer1.RefreshReport();
        }
    }
}
