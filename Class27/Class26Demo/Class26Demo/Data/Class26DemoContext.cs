using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class26Demo.Models
{
    public class Class26DemoContext : DbContext
    {
        public Class26DemoContext (DbContextOptions<Class26DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Class26Demo.Models.CMS> CMS { get; set; }
    }
}
