using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace class28Demo.Models
{
    public class class28DemoContext : DbContext
    {
        public class28DemoContext (DbContextOptions<class28DemoContext> options)
            : base(options)
        {
        }

        public DbSet<class28Demo.Models.CMS> CMS { get; set; }
    }
}
