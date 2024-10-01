using DataAccess.Entities;

namespace Application
{
    public interface IUserService
    {
        void RegisterUser(UserDto dto);
        User FindUserByEmailAndPassword(string email, string password);


    }
}