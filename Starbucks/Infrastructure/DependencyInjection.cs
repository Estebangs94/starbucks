using System.Reflection;
using Application;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<StarbucksDbContext>(options =>
            options.UseNpgsql(configuration["ConnectionStrings:DefaultConnection"]));
        services.AddScoped<IStarbucksDbContext>(provider => provider.GetRequiredService<StarbucksDbContext>());
        services.AddScoped<StarbucksDbContextInitializer>();

        return services;
    }
}