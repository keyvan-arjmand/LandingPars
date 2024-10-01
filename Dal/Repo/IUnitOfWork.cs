using Dal.Entity;

namespace Dal.Repo;

public interface IUnitOfWork
{
    IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;
}