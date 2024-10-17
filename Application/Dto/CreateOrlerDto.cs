using Common;


namespace Application.Dto;

 public class CreateOrlerDto
 {
     public CreateLocationDto DeparturePoint { get; set; }
     public CreateLocationDto DeliveryPoint { get; set; }
     public CreateClientDto Sender { get; set; }
     public CreateClientDto Customer { get; set; }
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
     public CreateAnimalDto CreateAnimal { get; set; }
     public CreateParcelDto CreateParcel { get; set; }
     public CreateDocumentDto CreateDocument { get; set; }
}
