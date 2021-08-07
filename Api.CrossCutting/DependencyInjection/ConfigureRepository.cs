using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.User;
using Api.Service.Services;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof (IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseNpgsql("Server=localhost; Port=5432; Database=ApiTeste; Uid=Junior; Pwd=123456")
                 );
        }
    }
}
