using DataAccess;

namespace Application.User
{
    public interface IUserService
    {
        void RegisterUser(UserDto dto);
        User FindUserByEmailAndPassword(string email, string password);


    }
}