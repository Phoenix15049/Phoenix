using Phoenix.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Application.Common
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
