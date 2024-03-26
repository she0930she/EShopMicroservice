
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public class EShopDbContext: DbContext
{
    public EShopDbContext (DbContextOptions<EShopDbContext> options):base(options)
    {

    }
    // set table name
    public DbSet<Product> Products { get; set; }
    public DbSet<Reviews> ReviewTables { get; set; }
    public DbSet<Shipping> Shippings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}