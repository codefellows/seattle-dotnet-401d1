using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo16.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Product => new List<Product>
        {
            new Product {Name = "Mario", Price = 100, SKU = "MAR135"},
            new Product {Name = "Skyrim", Price = 70, SKU= "SKY707"},
            new Product {Name = "Destiny 2" , Price = 120, SKU = "DYT768"},
            new Product {Name = "Tomb Raider" , Price =  30, SKU = "TRR456"}

        };
    }
}
