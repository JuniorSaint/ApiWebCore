using System;
using Api.Domain.Interfaces.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserServices>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
