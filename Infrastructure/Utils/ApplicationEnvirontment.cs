namespace Infrastructure.Utils;

public class ApplicationEnvirontment
{
    public static bool IsDevelopment()
    {
        string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")!;
        bool isDevelopment = environment == "Development";

        return isDevelopment;
    }
}