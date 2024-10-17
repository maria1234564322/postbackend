using Common;

namespace DataAccess.Entities;

public class DbLocation : Entity
{
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Street { get; set; }
    public int NumberStreet { get; set; }
    public string Apartment { get; set; }
    public int NumberApartment { get; set; }
    public LocationType TypeOfLocations { get; set; }
}
