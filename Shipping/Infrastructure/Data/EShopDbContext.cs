using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class EShopDbContext: DbContext
{
    public EShopDbContext (DbContextOptions<EShopDbContext> options):base(options)
    {

    }
    // set table name
    public DbSet<Product> Products { get; set; }
    public DbSet<Reviews> ReviewsTable { get; set; }
    public DbSet<Shipping> Shippings { get; set; }
}