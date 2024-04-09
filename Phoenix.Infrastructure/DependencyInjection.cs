using Microsoft.Extensions.DependencyInjection;
using Phoenix.Application.AuthenticationService;
using Phoenix.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepositoryInMemory>();
            services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
            return services;
        }
    }
}
