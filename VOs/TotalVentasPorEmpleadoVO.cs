using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class TotalVentasPorEmpleadoVO
    {
        private int employeeID;
        private string lastName;
        private string firstName;
        private decimal ventasTotales;

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public decimal VentasTotales { get => ventasTotales; set => ventasTotales = value; }
    }
}
