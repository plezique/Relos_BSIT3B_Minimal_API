using Microsoft.EntityFrameworkCore;
using Relos_BSIT3B_Minimal_API.Models;

namespace Relos_BSIT3B_Minimal_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        // One DbSet per model = one table in the database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

