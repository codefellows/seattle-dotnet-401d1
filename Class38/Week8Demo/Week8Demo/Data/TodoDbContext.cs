using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8Demo.Models;

namespace Week8Demo.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItems> TodoItems { get; set; }
        public DbSet<TaskList> TaskList { get; set; }
    }
}
