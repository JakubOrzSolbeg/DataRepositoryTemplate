using DataRepository.DbContext;
using DataRepository.Entities;
using DataRepository.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataRepository;

public static class Setup
{
    public static IServiceCollection AddDataRepository(this IServiceCollection services)
    {
        services.AddDbContext<MainDbContext1>();
        // services.AddScoped<Repository<Movie>, MovieRepository>();
        return services;
    }
}