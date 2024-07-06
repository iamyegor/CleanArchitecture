using Infrastructure.Data;
using Infrastructure.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration config,
        bool isDevelopment
    )
    {
        ConnectionStringResolver connectionStringResolver = new ConnectionStringResolver(config);
        string connectionString = connectionStringResolver.GetBasedOnEnvironment();

        services
            .AddScoped(_ => new ApplicationContext(connectionString, isDevelopment))
            .AddDapper()
            .AddUtils();

        return services;
    }

    private static IServiceCollection AddDapper(this IServiceCollection services)
    {
        services.AddTransient<DapperConnectionFactory>();

        return services;
    }

    private static void AddUtils(this IServiceCollection services)
    {
        services.AddTransient<HttpClient>();
        services.AddTransient<ConnectionStringResolver>();
    }
}
