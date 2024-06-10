using Coffee_Shop_application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_application.Context
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
