using System.Collections;
using Dal.Entity;

namespace Dal.Repo;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataBase.AppContext _db;
    private Hashtable? _repositories;

    public UnitOfWork(DataBase.AppContext db)
    {
        _db = db;
    }

    public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity
    {
        if (_repositories is null)
            _repositories = new Hashtable();

        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance =
                Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _db);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>)_repositories[type];
    }
}