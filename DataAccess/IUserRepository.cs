using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUserRepository
    {
        void Create(User user);
        User FindByEmailAndPassword(string email, string password);

    }
}
