using ApplicationCore.Contracts.RepositoryInterface.Order.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories.CustomerRepo;

namespace Infrastructure.Repositories.OrderRepo;

public class OrderRepository: BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(EShopDbContext edb) : base(edb)
    {
    }
    
}