using Api;
using Application;
using Infrastructure.DapperConfig;

DapperConfiguration.ConfigureSnakeCaseMapping(typeof(IApplication).Assembly);
WebApplication.CreateBuilder(args).ConfigureServices().ConfigureMiddlewares().Run();

namespace Api
{
    public partial class Program { }
}
