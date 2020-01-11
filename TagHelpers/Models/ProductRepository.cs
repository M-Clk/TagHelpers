using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Samsung S7", CategoryId=1, Price=1200, IsApproved=true },
            new Product(){ProductId=2,ProductName="Samsung S8", CategoryId=1, Price=2200, IsApproved=true },
            new Product(){ProductId=3,ProductName="Samsung S9", CategoryId=1, Price=4800, IsApproved=false },

            new Product(){ProductId=1,ProductName="Apple IPad Gold", CategoryId=3, Price=3500, IsApproved=true },
            new Product(){ProductId=2,ProductName="Apple IPad Silver", CategoryId=3, Price=2900, IsApproved=true },
            new Product(){ProductId=3,ProductName="Apple IPad Mini", CategoryId=3, Price=1650, IsApproved=false },

            new Product(){ProductId=1,ProductName="Lenovo", CategoryId=2, Price=9900, IsApproved=true },
            new Product(){ProductId=2,ProductName="Asus", CategoryId=2, Price=7100, IsApproved=true },
            new Product(){ProductId=3,ProductName="Dell", CategoryId=2, Price=6400, IsApproved=false }


        };
        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}
