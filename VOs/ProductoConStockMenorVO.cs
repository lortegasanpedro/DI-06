using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_lortega.VOs
{
    public class ProductoConStockMenorVO
    {
        private int productID;
        private int categoryID;
        private string categoryName;
        private string description;
        private int unitsInStock;
        private string productName;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public int UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductID { get => productID; set => productID = value; }
    }
}
