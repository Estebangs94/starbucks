using System.Reflection;
using Application;
using Infrastructure;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<StarbucksDbContext>();
        services.AddScoped<IStarbucksDbContext>(provider => provider.GetRequiredService<StarbucksDbContext>());
        services.AddScoped<StarbucksDbContextInitializer>();

        return services;
    }
}