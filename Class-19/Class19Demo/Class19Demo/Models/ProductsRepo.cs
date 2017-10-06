using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class19Demo.Models
{
    public class ProductsRepo : IRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
          new Product {Name="Spaceship", Price=50000M, SKU="SP9001"},
          new Product {Name="Cat", Price=350M, SKU="kat987"},
          new Product {Name="Dog", Price=10M, SKU="Woof345"}

        };
    }
}
