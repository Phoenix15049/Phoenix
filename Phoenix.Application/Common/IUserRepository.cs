using Phoenix.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Application.Common
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetByPhone(string phone);
    }
}
