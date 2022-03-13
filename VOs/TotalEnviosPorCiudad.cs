using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class TotalEnviosPorCiudadVO
    {
        private string shipCity;
        private decimal totalEnviosCiudad;
        public string ShipCity { get => shipCity; set => shipCity = value; }
        public decimal TotalEnviosCiudad { get => totalEnviosCiudad; set => totalEnviosCiudad = value; }
    }
}
