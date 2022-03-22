using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions.DependencyRegistration.AppSettings
{
    public static class Authentication
    {
        public static IServiceCollection BindAuthenticationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("Authentication");
            services.Configure<Models.Dtos.Responses.Authentications.AuthenticationResponse>(config);
            return services;
        }
    }
}
