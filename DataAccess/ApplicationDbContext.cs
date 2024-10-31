using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<DbUser> Users { get; set; }
    public DbSet<DbOrder> Orders { get; set; }
    public DbSet<DbParcel> Parcels { get; set; }
    public DbSet<DbDocument> Documents { get; set; }
    public DbSet<DbLocation> Locations { get; set; }
    public DbSet<DbAnimal> Animals { get; set; }
    public DbSet<DbClient> Clients { get; set; }
    public DbSet<DbIndex> DbIndexs { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }
}

