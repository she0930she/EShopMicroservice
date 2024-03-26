using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories.CustomerRepo;

public class ShoppingCartRepository: BaseRepository<Product>, IShoppingCartRepo
{
    public ShoppingCartRepository(EShopDbContext edb) : base(edb)
    {
    }
    
    
}