using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepoBranchTest.Models;

namespace RepoBranchTest
{
    public class DbContextfor:DbContext
    {
        
        public DbContextfor()
            {

            }

            public DbContextfor(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS ;Database = REPOTEST; Integrated Security=true;");
            }
        }
}
