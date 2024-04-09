using System.Reflection.Metadata;
using Phoenix.Domain;
namespace Phoenix.Application.AuthenticationService
{
    public record AuthenticationResult(
        User user,
        string Token
        );

}