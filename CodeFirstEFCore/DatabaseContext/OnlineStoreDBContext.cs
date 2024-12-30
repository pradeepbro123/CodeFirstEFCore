using CodeFirstEFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore.DatabaseContext
{
    public class OnlineStoreDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ADIREDDY;Initial Catalog=OnlineStoreDB;TrustServerCertificate=True;Integrated Security=True");
        }

    }
}
