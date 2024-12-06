using Bacchus.Configuration.Features;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Bacchus.Configuration.Razor;

public static class RazorExtensions
{
    public static void ConfigureFeatureFolders(this RazorViewEngineOptions options)
    {
        // {0} - Action Name
        // {1} - Controller Name
        // {2} - Area Name
        // {3} - Feature Name
        options.AreaViewLocationFormats.Clear();
        options.AreaViewLocationFormats.Add("/Areas/{2}/Features/{3}/{1}/{0}.cshtml");
        options.AreaViewLocationFormats.Add("/Areas/{2}/Features/{3}/{0}.cshtml");
        options.AreaViewLocationFormats.Add("/Areas/{2}/Features/Shared/{0}.cshtml");
        options.AreaViewLocationFormats.Add("/Areas/Shared/{0}.cshtml");

        // replace normal view location entirely
        options.ViewLocationFormats.Clear();
        options.ViewLocationFormats.Add("/Features/{3}/{1}/{0}.cshtml");
        options.ViewLocationFormats.Add("/Features/{3}/Views/{0}.cshtml");
        options.ViewLocationFormats.Add("/Features/{3}/{0}.cshtml");
        options.ViewLocationFormats.Add("/Features/Shared/{0}.cshtml");
        options.ViewLocationFormats.Add("/Features/Shared/Builds/{0}.cshtml");

        options.ViewLocationExpanders.Add(new FeatureViewLocationExpander());
    }
}