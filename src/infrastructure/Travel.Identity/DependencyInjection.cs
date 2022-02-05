using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Application.Common.Interfaces;
using Travel.Identity.Helpers;
using Travel.Identity.Services;

namespace Travel.Identity
{
    public static class DependencyInjection
    {
        public static IServiceCollection
          AddInfrastructureIdentity(this IServiceCollection services,
             IConfiguration config)
        {
            services.Configure<AuthSettings>(config.GetSection(nameof(AuthSettings)));
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
