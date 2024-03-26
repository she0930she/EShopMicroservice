using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories.CustomerRepo;

public class CustomerRepo: BaseRepository<Customer>, ICustomerRepo
{
    public CustomerRepo(EShopDbContext edb) : base(edb)
    {
    }
}