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
    public partial class InformesMReportViewerStocksProductos : Form
    {
        public InformesMReportViewerStocksProductos()
        {
            InitializeComponent();
        }

        private void InformesMReportViewerStocksProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetStocksProductos.Products' Puede moverla o quitarla según sea necesario.
            this.ProductsTableAdapter.Fill(this.DataSetStocksProductos.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
