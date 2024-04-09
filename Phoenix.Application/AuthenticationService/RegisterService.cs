using Phoenix.Application.Common;
using Phoenix.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Application.AuthenticationService
{
    public class RegisterService : IRegisterService
    {

        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public RegisterService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Handle(string firstName, string lastName, string Phone) {

            if (_userRepository.GetByPhone(Phone) is not null)
            {
                throw new Exception("User Already Exists");
            }

            var user = new User
            {   FirstName = firstName,
                LastName = lastName,
                PhoneNumber = Phone
            };

            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(user, token);
        
        }

    }
}
