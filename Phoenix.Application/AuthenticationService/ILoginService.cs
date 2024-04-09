using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Application.AuthenticationService
{
    public interface ILoginService
    {
        AuthenticationResult Handle(string phone, int code);
    }
}
