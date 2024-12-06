using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection;

namespace Bacchus.Configuration.Features;

public class FeatureConvention : IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        string? featureName = GetFeatureName(controller.ControllerType);
        controller.Properties.Add("feature", featureName);
    }

    private static string? GetFeatureName(TypeInfo controllerType)
    {
        string[]? tokens = !string.IsNullOrEmpty(controllerType.FullName) ? controllerType.FullName.Split('.') : null;

        if (tokens is not null && !tokens.Any(t => t == "Features"))
            return string.Empty;

        string featureName = tokens
            .SkipWhile(t => !t.Equals("features", StringComparison.CurrentCultureIgnoreCase))
            .Skip(1)
            .Take(1)
            .FirstOrDefault();

        return featureName;
    }
}