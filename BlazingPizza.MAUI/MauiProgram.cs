using BlazingPizza.Htttp.Repositories;
using BlazingPizza.MAUI.Handlers;
using BlazingPizza.ViewModels;
using System.Reflection;

namespace BlazingPizza.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
                                                                                                  
        builder.Configuration.AddJsonStream(GetResourceStream("appsettings.json"));
        builder.Services.AddHttpRepositoriesServices(builder.Configuration.GetSection("BlazzingPizzaEndpoints"),
#if ANDROID
            builder =>
            {
                builder.ConfigurePrimaryHttpMessageHandler(() => new HttpsClientHandlerService().GetPlatformMessageHandler());
                builder.AddHttpMessageHandler(() => new CustomHttpMessageHandler());
            }
#elif IOS
            builder => 
            {
                builder.ConfigurePrimaryHttpMessageHandler(() => new HttpsClientHandlerService().GetPlatformMessageHandler()); 
                builder.AddHttpMessageHandler(() => new CustomHttpMessageHandler());
            }
#else
null
#endif
            );
        builder.Services.AddViewModelsServices();

        return builder.Build();
    }

    public static Stream GetResourceStream(string resourceRelativeUri)
    {
        // resource like: images/icon-512.png <- file need to be embebed into the assembly
        // converto into: images.icon-512.png
        resourceRelativeUri = resourceRelativeUri.Replace("/", ".");
        Type appType = typeof(MauiProgram);
        Assembly assemblySource = Assembly.GetAssembly(appType);
        // recovery from namespace: BlazingPizza.Razor.View.wwwroot.images.icon-512.png <- this is my embebed file
        Stream result = assemblySource
            .GetManifestResourceStream(
            $"{appType.Namespace}.{resourceRelativeUri}");
        return result;
    }
}
