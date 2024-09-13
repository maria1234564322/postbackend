using Microsoft.EntityFrameworkCore;

namespace DataAccess.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _ctx;

        public UserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Create(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
        }

        public User FindByEmailAndPassword(string email, string password)
        {
            return _ctx.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
