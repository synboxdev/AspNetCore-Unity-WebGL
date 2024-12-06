using Microsoft.Extensions.FileProviders;

namespace Bacchus.Configuration.WebApplication;

public static class WebApplicationExtensions
{
    public static Microsoft.AspNetCore.Builder.WebApplication ConfigureWebApplication(this Microsoft.AspNetCore.Builder.WebApplication app)
    {
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, "Assets")),
            RequestPath = "/assets",
            ContentTypeProvider = Razor.StaticFileExtensions.GetFileExtensionContentTypeProvider()
        });

        app.UseMvc(routes =>
        {
            _ = routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}");
        });

        return app;
    }
}