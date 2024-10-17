using DataAccess.Repostories.DbClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repostories.DbDocuments;


    public class DbDocumentRepository : Repository<DataAccess.Entities.DbDocument>, IDbDocumentRepository
{
    public DbDocumentRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }
}

