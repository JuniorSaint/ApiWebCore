
using Api.Domain.Interfaces.Services.City;
using Api.Domain.Interfaces.Services.CodeZip;
using Api.Domain.Interfaces.Services.Uf;
using Api.Domain.Interfaces.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<ICityService, CityService>();
            serviceCollection.AddTransient<IUfService, UfService>();
            serviceCollection.AddTransient<ICodeZipService, CodeZipService>();
        }
    }
}
