using Phoenix.Application.Common;
using Phoenix.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Infrastructure
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static readonly List<User> _users = new();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User GetByPhone(string phone)
        {
            return _users.SingleOrDefault(x => x.PhoneNumber == phone);
        }
    }

}
