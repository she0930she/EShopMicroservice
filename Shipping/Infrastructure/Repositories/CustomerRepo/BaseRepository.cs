using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories.CustomerRepo;

public class BaseRepository<T>: IRepository<T> where T : class
{
    public readonly EShopDbContext _eShopDb;

    public BaseRepository(EShopDbContext edb)
    {
        _eShopDb = edb;
    }


    public int Insert(T entity)
    {
        _eShopDb.Set<T>().Add(entity);
        return _eShopDb.SaveChanges();
    }

    public int Update(T entity)
    {
        _eShopDb.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return _eShopDb.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        _eShopDb.Set<T>().Remove(entity);
        return _eShopDb.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return _eShopDb.Set<T>().ToList(); 
        // Set() method for accessing entity in entityFrameworkCore
        // return DbSet instance
    }

    public T GetById(int id)
    {
        return _eShopDb.Set<T>().Find(id);
    }
}