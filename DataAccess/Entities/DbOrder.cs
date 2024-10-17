using Common;

namespace DataAccess.Entities;

public class DbOrder : Entity
{

    public long DeparturePointId { get; set; }    
    public DbLocation DeparturePoint { get; set; } 
    public long DeliveryPointId { get; set; }
    public DbLocation DeliveryPoint { get; set; }
    public long SenderId { get; set; }
    public DbClient Sender { get; set; }
    public long CustomerId { get; set; }
    public DbClient Customer { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public decimal DeliveryPrice { get; set; }
    public DateTime DateArrival { get; set; }
    public DateTime DateCreation { get; set; }
    public string PromoCode { get; set; }
    public OrderType OrderType { get; set; }
    public OrderPayer OrderPayer { get; set; }
}

