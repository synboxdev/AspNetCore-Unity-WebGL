using Bacchus.Configuration.Features;
using Bacchus.Configuration.Razor;

namespace Bacchus.Configuration.WebApplicationBuilder;

public static class WebApplicationBuilder
{
    public static Microsoft.AspNetCore.Builder.WebApplicationBuilder ConfigureWebApplicationBuilder(this Microsoft.AspNetCore.Builder.WebApplicationBuilder builder)
    {
        builder.Services.AddMvc(options =>
        {
            options.Conventions.Add(new FeatureConvention());
            options.EnableEndpointRouting = false;
        }).AddRazorOptions(options =>
        {
            options.ConfigureFeatureFolders();
        });

        builder.Services.AddControllersWithViews();

        return builder;
    }
}