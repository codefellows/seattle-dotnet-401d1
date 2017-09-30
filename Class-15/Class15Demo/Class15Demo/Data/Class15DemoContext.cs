using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class15Demo.Models
{
    public class Class15DemoContext : DbContext
    {
        public Class15DemoContext (DbContextOptions<Class15DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Class15Demo.Models.Movie> Movie { get; set; }
    }
}
