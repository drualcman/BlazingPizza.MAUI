namespace BlazingPizza.Razor.View.Helpers;

public static class WWWRoot
{
    public static Stream GetResourceStream(string resourceRelativeUri)
    {
        // resource like: images/icon-512.png <- file need to be embebed into the assembly
        // converto into: images.icon-512.png
        resourceRelativeUri = resourceRelativeUri.Replace("/", ".");
        Type appType = typeof(App);
        Assembly assemblySource = Assembly.GetAssembly(appType);
        // recovery from namespace: BlazingPizza.Razor.View.wwwroot.images.icon-512.png <- this is my embebed file
        Stream result = assemblySource
            .GetManifestResourceStream(
            $"{appType.Namespace}.wwwroot.{resourceRelativeUri}");
        return result;
    }
}
