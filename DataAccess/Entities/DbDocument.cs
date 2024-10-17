using Common;

namespace DataAccess.Entities;

public class DbDocument : Entity
{
    public long OrderId { get; set; }
    public DbOrder Order { get; set; }
    public bool Packaging { get; set; }
    public bool ReturnShipping { get; set; }
}
