using DataAccess.Entities;

namespace Application.IServices;

public interface IUserService
{
    void RegisterUser(UserDto dto);
    DbUser FindUserByEmailAndPassword(string email, string password);

}