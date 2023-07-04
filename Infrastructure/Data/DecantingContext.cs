using Core.Entities;
using Core.Entities.Decanting;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DecantingContext : DbContext
    {
        public DecantingContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<OrderDecant> OrderDecants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Packaging> Packaging { get; set; }
        public DbSet<Transport> Transports { get; set; }
    }
}