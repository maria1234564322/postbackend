using Application.Dto;
using DataAccess.Entities;


namespace Application.IServices
{
    public interface IOrdersService
    {
      
            void CreateOrder(CreateOrlerDto createOrderDto);
    }
}
