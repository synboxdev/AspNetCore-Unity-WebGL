using Bacchus.Configuration.WebApplication;
using Bacchus.Configuration.WebApplicationBuilder;

var builder = WebApplication.CreateBuilder(args).ConfigureWebApplicationBuilder();
var app = builder.Build().ConfigureWebApplication();

await app.RunAsync();