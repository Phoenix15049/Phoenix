using Phoenix.Application.Common;
using Phoenix.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Infrastructure
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(User user)
        {
            return Guid.NewGuid().ToString();
        }
        

    }
}
