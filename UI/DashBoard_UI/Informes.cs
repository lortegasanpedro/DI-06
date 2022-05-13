using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Informes : Form
    {
        private string informe;

        public Informes()
        {
            InitializeComponent();
        }

        public string Informe { get => informe; set => informe = value; }

        private void Informes_Load(object sender, EventArgs e)
        {
            string path;
            string pathApp = Application.StartupPath;
            if (pathApp.EndsWith("\\bin\\Debug") || pathApp.EndsWith("\\bin\\Release")) {
                path = "../../" + this.informe;
            } else
            {
                path = this.informe;
            }

            ReportDocument cryRpt = new ReportDocument();
            //
            //string path = this.informe;
            //string path = "../../Inf4VentasTotalesPorClientes.rpt";
            cryRpt.Load(path);

            //cryRpt.SetDataSource("Data Source=192.168.0.19;Initial Catalog=Northwind;Persist Security Info=True;User ID=lortega;Password=P@ssw0rd");

            //cryRpt.SetDatabaseLogon("lortega", "P@ssw0rd", @"localhost", "Northwind");
            //cryRpt.SetParameterValue("txtNombreCli", _datos.sNombre);
            //cryRpt.SetParameterValue("txtNIFCli", _datos.sNIF);
            this.crystalReportViewer1.ReportSource = cryRpt;
        }
    }
}
