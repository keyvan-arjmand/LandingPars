using Dal.Repo;
using Microsoft.Extensions.DependencyInjection;

namespace Dal;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}