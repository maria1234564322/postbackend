using DataAccess.Repostories.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repostories.DbClients;

public class DbClientRepository : Repository<Entities.DbClient>, IDbClientRepository
{
    public DbClientRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }
}
