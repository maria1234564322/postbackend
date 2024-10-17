using Common;

namespace DataAccess.Entities;

public class DbAnimal : Entity
{
    public long OrderId { get; set; }
    public DbOrder Order { get; set; }
    public bool Feed { get; set; }
    public string Notes { get; set; }
    public AnimalType AnimalTyp { get; set; }
}
