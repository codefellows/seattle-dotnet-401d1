using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class19Demo.Models
{
   public interface IRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
