using DataAccess.Entities;

namespace DataAccess.Repostories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private readonly ApplicationDbContext _ctx;
    public Repository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public TEntity Create(TEntity entity)
    {
        var savedObj = _ctx.Set<TEntity>().Add(entity).Entity;
        _ctx.SaveChanges();
        return savedObj;
    }

    public void Delete(long id)
    {
        var entity = _ctx.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        _ctx.Remove<TEntity>(entity);
        _ctx.SaveChanges();
    }

    public TEntity Get(long id)
    {
        var entity = _ctx.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        return entity;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _ctx.Set<TEntity>().AsEnumerable();
    }

    public void Update(TEntity entity)
    {
        _ctx.Set<TEntity>().Update(entity);
        _ctx.SaveChanges();
    }
}
