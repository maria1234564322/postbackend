using DataAccess.Repostories.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repostories.DbLocations;

public class DbLocationRepository : Repository<DataAccess.Entities.DbLocation>, IDbLocationRepository
{
    public DbLocationRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }
}
