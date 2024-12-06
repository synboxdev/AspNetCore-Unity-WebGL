using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Bacchus.Configuration.Features;

public class FeatureViewLocationExpander : IViewLocationExpander
{
    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context,
        IEnumerable<string> viewLocations)
    {
        ArgumentNullException.ThrowIfNull(context);

        ArgumentNullException.ThrowIfNull(viewLocations);

        if (context.ActionContext.ActionDescriptor is not ControllerActionDescriptor controllerActionDescriptor)
            throw new NullReferenceException("ControllerActionDescriptor cannot be null.");

        string featureName = controllerActionDescriptor.Properties["feature"] as string;

        foreach (string location in viewLocations)
            yield return location.Replace("{3}", featureName);
    }

    public void PopulateValues(ViewLocationExpanderContext context)
    {
    }
}