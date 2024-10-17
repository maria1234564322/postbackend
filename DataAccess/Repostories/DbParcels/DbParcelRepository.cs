namespace DataAccess.Repostories.Parcels;

public class DbParcelRepository : Repository<DataAccess.Entities.DbParcel>, IDbParcelRepository
{
	public DbParcelRepository(ApplicationDbContext ctx) : base(ctx)
	{
	}
}
