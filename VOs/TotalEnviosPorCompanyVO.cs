using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class TotalEnviosPorCompanyVO
    {
        private int shipperID;
        private string companyName;
        private decimal totalEnviosCompany;

        public int ShipperID { get => shipperID; set => shipperID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public decimal TotalEnviosCompany { get => totalEnviosCompany; set => totalEnviosCompany = value; }
    }
}
