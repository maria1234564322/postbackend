using Common;

namespace Application.Dto;

public class CreateLocationDto
{
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Street { get; set; }
    public int NumberStreet { get; set; }
    public string Apartment { get; set; }
    public int NumberApartment { get; set; }
    public LocationType LocationType { get; set; }
}
