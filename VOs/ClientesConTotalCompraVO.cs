using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class ClientesConTotalCompraVO
    {

        private string customerID;
        private string companyName;
        private string productName;
        private decimal totalCompra;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal TotalCompra { get => totalCompra; set => totalCompra = value; }
    }
}