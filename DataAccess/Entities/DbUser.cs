namespace DataAccess.Entities;

public class DbUser : Entity
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public string MiddleName { get; set; }
    public string Phone { get; set; }
    public long UserLocationId { get; set; }
    public DbLocation UserLocation { get; set; }
}
