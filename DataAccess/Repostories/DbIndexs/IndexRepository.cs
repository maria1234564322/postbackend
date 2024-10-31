using DataAccess.Entities;
using DataAccess.Repostories;
using DataAccess.Repostories.DbIndexs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class IndexRepository  : Repository<DataAccess.Entities.DbIndex>, IIndexRepository
{

    public IndexRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }

    public List<DbIndex> Search(string district, string region, string city, string street, string numberStreet)
    {
       
        var query = _ctx.DbIndexs.AsQueryable();
        if (!string.IsNullOrEmpty(district))
        {
            query = query.Where(x => x.District.Contains(district));
        }
        if (!string.IsNullOrEmpty(region))
        {
            query = query.Where(x => x.Region.Contains(region));
        }
        if (!string.IsNullOrEmpty(city))
        {
            query = query.Where(x => x.Region.Contains(city));
        }
        if (!string.IsNullOrEmpty(street))
        {
            query = query.Where(x => x.Region.Contains(street));
        }
        if (!string.IsNullOrEmpty(numberStreet))
        {
            query = query.Where(x => x.Region.Contains(numberStreet));
        }

        return query.ToList();
    }

    public DbIndex FindByUniqueFields(string district, string region, string city, string street, string numberStreet)
    {
        var query = _ctx.DbIndexs.AsQueryable();

        if (!string.IsNullOrEmpty(district))
        {
            query = query.Where(x => x.District.Contains(district));
        }
        if (!string.IsNullOrEmpty(region))
        {
            query = query.Where(x => x.Region.Contains(region));
        }
        if (!string.IsNullOrEmpty(city))
        {
            query = query.Where(x => x.City.Contains(city));
        }
        if (!string.IsNullOrEmpty(street))
        {
            query = query.Where(x => x.Street.Contains(street));
        }
        if (!string.IsNullOrEmpty(numberStreet))
        {
            query = query.Where(x => x.NumberStreet.Contains(numberStreet));
        }

        return query.FirstOrDefault();
    }
    public DbIndex GetById(long id)
    {
        return _ctx.DbIndexs.Find(id);
    }
}




