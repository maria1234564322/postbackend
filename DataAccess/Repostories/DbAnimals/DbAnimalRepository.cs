using DataAccess.Entities;

namespace DataAccess.Repostories.Animal;

public class DbAnimalRepository : Repository<Entities.DbAnimal>, IDbAnimalRepository
{
    public DbAnimalRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }

}
