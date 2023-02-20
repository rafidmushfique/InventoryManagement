using InventoryManagement.Models.Domain;
using InventoryManagement.Models.Account;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Models
{
    public class INVDbContext:DbContext
    {
        public INVDbContext(DbContextOptions<INVDbContext> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
