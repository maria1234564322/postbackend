using DataAccess.Entities;

namespace DataAccess.Repostories.Users;

public interface IUserRepository
{
    void Create(DbUser user);
    DbUser FindByEmailAndPassword(string email, string password);

}
