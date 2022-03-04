using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Workshop.Models
{
    public class WorkshopContext : DbContext
    {
        public WorkshopContext (DbContextOptions<WorkshopContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
