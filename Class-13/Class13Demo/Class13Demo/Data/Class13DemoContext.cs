using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class13Demo.Models
{
    public class Class13DemoContext : DbContext
    {
        public Class13DemoContext (DbContextOptions<Class13DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Class13Demo.Models.Movies> Movies { get; set; }
    }
}
