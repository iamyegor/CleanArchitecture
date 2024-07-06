using Microsoft.Extensions.Configuration;

namespace Infrastructure.Utils;

public class ConnectionStringResolver
{
    private readonly IConfiguration _configuration;

    public ConnectionStringResolver(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetBasedOnEnvironment()
    {
        return ApplicationEnvirontment.IsDevelopment()
            ? _configuration.GetConnectionString("Default")!
            : Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
    }
}
