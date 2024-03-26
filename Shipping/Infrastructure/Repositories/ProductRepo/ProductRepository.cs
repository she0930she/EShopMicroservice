using ApplicationCore.Contracts.RepositoryInterface.ProductIRepo;
using ApplicationCore.Contracts.RepositoryInterface.ShipperIRepo;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.CustomerRepo;

namespace Infrastructure.Repositories.ProductRepo;

public class ProductRepository: BaseRepository<Product>, IProductRepository
{
    public ProductRepository(EShopDbContext  tb) : base(tb)
    {
    }
    
    
    
}