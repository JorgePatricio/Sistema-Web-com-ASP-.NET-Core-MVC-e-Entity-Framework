using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebTest.Models;

namespace SalesWebTest.Data
{
    public class SalesWebTestContext : DbContext
    {
        public SalesWebTestContext (DbContextOptions<SalesWebTestContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebTest.Models.Department> Department { get; set; }
    }
}
