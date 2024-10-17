using DataAccess.Entities;
using DataAccess.Repostories.Order;
using DataAccess.Repostories.Parcels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repostories.Orders;

public class DbOrderRepository : Repository<DbOrder>, IDbOrderRepository
{
    public DbOrderRepository(ApplicationDbContext ctx) : base(ctx)
    {
    }
}


