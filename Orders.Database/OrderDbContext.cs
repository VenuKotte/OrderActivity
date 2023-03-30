using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Orders.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Database
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> context) : base(context)  
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // you can replace your your connection string 
            optionsBuilder.UseSqlServer("Server=.;Database=OrderDb;User Id=sa;password=admin@123;Encrypt=false;Trusted_Connection=false;TrustServerCertificate=true;MultipleActiveResultSets=true;",
                 b => b.MigrationsAssembly("Orders.Database"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderNumber)
                .HasDefaultValueSql("NEWID()");
        }

        public  DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set;}
        public DbSet<Customer> customers { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}
