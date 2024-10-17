using DataAccess.Entities;

namespace DataAccess.Repostories;

public interface IRepository<TEntity> where TEntity : Entity
{
    TEntity Create(TEntity entity);
    void Delete(long id);
    void Update(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity Get(long id);
}
