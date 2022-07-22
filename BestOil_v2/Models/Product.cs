using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_v2.Models
{
    public class Product
    {

        public string ProductName { get; set; }

        public int ProductCount { get; set; }

        public float ProductPrice { get; set; }

        public Product(string productName, float productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
