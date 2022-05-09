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
            ReportDocument cryRpt = new ReportDocument();
            string path = "../../" + this.informe;
            //string path = this.informe;
            cryRpt.Load(path);
            //cryRpt.SetParameterValue("txtNombreCli", _datos.sNombre);
            //cryRpt.SetParameterValue("txtNIFCli", _datos.sNIF);
            this.crystalReportViewer1.ReportSource = cryRpt;
        }
    }
}
