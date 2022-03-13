using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class EmpleadoConTotalVentasPorProductoVO
    {
        private int employeeID;
        private string lastName;
        private string firstName;
        private int productID;
        private string productName;
        private decimal ventasTotales;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public int ProductID { get => productID; set => productID = value; }
        public decimal VentasTotales { get => ventasTotales; set => ventasTotales = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
    }
}
