using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard_UI
{
    public partial class InformesMReportViewerEnviosPorPais : Form
    {
        public InformesMReportViewerEnviosPorPais()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetTotalEnviosPorPais.Orders' Puede moverla o quitarla según sea necesario.
            this.OrdersTableAdapter.Fill(this.DataSetTotalEnviosPorPais.Orders);
            // TODO: esta línea de código carga datos en la tabla 'DataSetTotalEnviosPorPais.Orders' Puede moverla o quitarla según sea necesario.
            this.OrdersTableAdapter.Fill(this.DataSetTotalEnviosPorPais.Orders);
            this.reportViewer1.RefreshReport();
        }
    }
}
