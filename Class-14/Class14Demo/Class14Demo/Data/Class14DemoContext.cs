using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class14Demo.Models
{
    public class Class14DemoContext : DbContext
    {
        public Class14DemoContext (DbContextOptions<Class14DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Class14Demo.Models.Movies> Movies { get; set; }
    }
}
