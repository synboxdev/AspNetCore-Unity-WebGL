using Microsoft.AspNetCore.StaticFiles;

namespace Bacchus.Configuration.Razor;

public static class StaticFileExtensions
{
    public static FileExtensionContentTypeProvider GetFileExtensionContentTypeProvider()
    {
        var provider = new FileExtensionContentTypeProvider();

        provider.Mappings.Add(".unityweb", "application/octet-stream");
        provider.Mappings.Add(".data", "application/octet-stream");
        provider.Mappings.Add(".br", "application/brotli");
        provider.Mappings.Add(".data.br", "application/brotli");
        provider.Mappings.Add(".wasm.br", "application/wasm");
        provider.Mappings.Add(".js.br", "application/javascript");
        provider.Mappings.Add(".symbols.js.br", "application/octet-stream");
        provider.Mappings.Add(".bundle", "application/octet-stream");

        return provider;
    }
}