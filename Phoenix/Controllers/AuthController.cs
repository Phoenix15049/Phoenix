using Microsoft.AspNetCore.Mvc;
using Phoenix.Application.AuthenticationService;


namespace Phoenix.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;

        public AuthController(IRegisterService registerService, ILoginService loginService)
        {
            _registerService = registerService;
            _loginService = loginService;
        }

        [HttpPost("Register")]
        public ActionResult Register(string firstname,string lastname,string Phone)
        {
            var result = _registerService.Handle(firstname, lastname, Phone);
            return Ok(result);
        }

        [HttpPost("Login")]
        public ActionResult Login(string PhoneNumber,int code)
        {
            var result = _loginService.Handle(PhoneNumber,code);
            return Ok(result);
        }
    }

}
