namespace DataAccess.Entities;

public class Entity
{
    public long Id  { get; set; }
    public DateTime Created  { get; set; }
    public DateTime Modified  { get; set; }
    public bool? IsDeleted  { get; set; }
}
