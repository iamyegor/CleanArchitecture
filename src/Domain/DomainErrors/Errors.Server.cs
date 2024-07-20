namespace Domain.DomainErrors;

public static partial class Errors
{
    public class Server
    {
        public static Error InternalServerError => new("internal.server.error");
    }
}
