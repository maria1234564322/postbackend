using Application.Dto;
using Application.IServices;
using Common;
using DataAccess.Entities;
using DataAccess.Repostories.Animal;
using DataAccess.Repostories.DbClients;
using DataAccess.Repostories.DbLocations;
using DataAccess.Repostories.Order;
using DataAccess.Repostories.Parcels;


namespace Application.Services;

public class OrdersService : IOrdersService
{
    private readonly IDbOrderRepository _orderRepository;
    private readonly IDbLocationRepository _locationRepository;
    private readonly IDbClientRepository _clientRepository;
    private readonly IDbParcelRepository _parcelRepository;
    private readonly IDbAnimalRepository _animalRepository;
    private readonly IDbDocumentRepository _documentRepository;

    public OrdersService(
        IDbOrderRepository orderRepository,
        IDbLocationRepository locationRepository,
        IDbClientRepository clientRepository,
        IDbParcelRepository parcelRepository,
        IDbAnimalRepository animalRepository,
        IDbDocumentRepository documentRepository)
    {
        _orderRepository = orderRepository;
        _locationRepository = locationRepository;
        _clientRepository = clientRepository;
        _parcelRepository = parcelRepository;
        _animalRepository = animalRepository;
        _documentRepository = documentRepository;
    }

   
    public void CreateOrder(CreateOrlerDto createOrderDto)
    {
        var departureLocation = _locationRepository.Create(new DbLocation()
        {
            City = createOrderDto.DeparturePoint.City,
            State = createOrderDto.DeparturePoint.State,
            PostalCode = createOrderDto.DeparturePoint.PostalCode,
            Street = createOrderDto.DeparturePoint.Street,
            NumberStreet = createOrderDto.DeparturePoint.NumberStreet,
            Apartment = createOrderDto.DeparturePoint.Apartment,
            NumberApartment = createOrderDto.DeparturePoint.NumberApartment,
            TypeOfLocations = createOrderDto.DeparturePoint.LocationType
        });
        var deliveryPoint = _locationRepository.Create(new DbLocation()
        {
            City = createOrderDto.DeparturePoint.City,
            State = createOrderDto.DeparturePoint.State,
            PostalCode = createOrderDto.DeparturePoint.PostalCode,
            Street = createOrderDto.DeparturePoint.Street,
            NumberStreet = createOrderDto.DeparturePoint.NumberStreet,
            Apartment = createOrderDto.DeparturePoint.Apartment,
            NumberApartment = createOrderDto.DeparturePoint.NumberApartment,
            TypeOfLocations = createOrderDto.DeparturePoint.LocationType
        });
        var sender =_clientRepository.Create (new DbClient()
        { 
            Surname = createOrderDto.Sender.Surname,
            Name= createOrderDto.Sender.Surname,
            MiddleName = createOrderDto.Sender.MiddleName,
            Phone = createOrderDto.Sender.Phone,
            IsRegistered = createOrderDto.Sender.IsRegistered,
        });
        var customer = _clientRepository.Create(new DbClient()
        {
            Surname = createOrderDto.Sender.Surname,
            Name = createOrderDto.Sender.Surname,
            MiddleName = createOrderDto.Sender.MiddleName,
            Phone = createOrderDto.Sender.Phone,
            IsRegistered = createOrderDto.Sender.IsRegistered,
        });


        var newOrder = new DbOrder
        {
            Customer = customer,
            Sender = sender,
            DeliveryPoint = deliveryPoint,
            DeparturePoint = departureLocation,
            DeparturePointId = departureLocation.Id,
            DeliveryPointId = deliveryPoint.Id,
            SenderId = sender.Id,
            CustomerId = customer.Id,
            Height = createOrderDto.Height,
            Width = createOrderDto.Width,
            Length = createOrderDto.Length,
            Weight = createOrderDto.Weight,
            DeliveryPrice = createOrderDto.DeliveryPrice,
            DateArrival = createOrderDto.DateArrival,
            DateCreation = createOrderDto.DateCreation,
            PromoCode = createOrderDto.PromoCode,
            OrderType = createOrderDto.OrderType,
            OrderPayer = createOrderDto.OrderPayer,
        };
       var orderEntity =  _orderRepository.Create(newOrder);

        switch (createOrderDto.OrderType)
        {
            case OrderType.Animal:
                _animalRepository.Create( new DbAnimal
                {
                    AnimalTyp = createOrderDto.CreateAnimal.AnimalTyp,
                    Notes = createOrderDto.CreateAnimal.Notes,
                    Feed = createOrderDto.CreateAnimal.Feed,
                    OrderId = orderEntity.Id
                });
                break;

            case OrderType.Document:
                _documentRepository.Create( new DbDocument
                {
                    Packaging = createOrderDto.CreateDocument.Packaging,
                    ReturnShipping = createOrderDto.CreateDocument.ReturnShipping,
                    OrderId = orderEntity.Id
                });
                break;

            case OrderType.Parcel:
                _parcelRepository.Create( new DbParcel
                {
                    Description = createOrderDto.CreateParcel.Description,
                    EstimatedValue = createOrderDto.CreateParcel.EstimatedValue,
                    Remittancel = createOrderDto.CreateParcel.Remittancel,
                    OrderId = orderEntity.Id
                });
                break;
            default: throw new NotImplementedException();
        };


        _orderRepository.Create(newOrder);
    }

   
}

