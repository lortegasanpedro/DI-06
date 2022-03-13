using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class ProductoMasVendidoVO
    {
        private int productID;
        private string productName;
        private int ventasUnidadesTotales;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int VentasUnidadesTotales { get => ventasUnidadesTotales; set => ventasUnidadesTotales = value; }
    }
}
