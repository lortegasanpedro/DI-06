using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class TotalEnviosPorPaisVO
    {
        private string shipCountry;
        private decimal totalEnviosPais;
        public string ShipCountry { get => shipCountry; set => shipCountry = value; }
        public decimal TotalEnviosPais { get => totalEnviosPais; set => totalEnviosPais = value; }
    }
}
