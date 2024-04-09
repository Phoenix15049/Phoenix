using Microsoft.AspNetCore.Identity;
using Phoenix.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Application.AuthenticationService
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;

        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public LoginService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Handle(string phone, int code)
        {

            var existingUser = _userRepository.GetByPhone(phone);
            if (existingUser is null)
            {
                throw new Exception("test");
            }
            var token = _jwtTokenGenerator.GenerateToken(existingUser);
            return new AuthenticationResult(existingUser,token);
        }
    }
}