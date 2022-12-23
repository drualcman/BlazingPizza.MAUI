using BlazingPizza.Htttp.Repositories;
using BlazingPizza.ViewModels;
using Microsoft.Extensions.Configuration;
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

        string nameSpace = typeof(MainPage).Namespace;
        Assembly assemblySource = Assembly.GetExecutingAssembly();
        using Stream stream = assemblySource.GetManifestResourceStream($"{nameSpace}.appsettings.json");
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();
        
        builder.Services.AddHttpRepositoriesServices(configuration.GetSection("BlazzingPizzaEndpoints"),
#if ANDROID
            builder => 
            {
                builder.ConfigurePrimaryHttpMessageHandler(() => new HttpsClientHandlerService().GetPlatformMessageHandler());
            }
#elif IOS
            builder => 
            {
                builder.ConfigurePrimaryHttpMessageHandler(() => new HttpsClientHandlerService().GetPlatformMessageHandler());
            }
#else
null
#endif
            );
        builder.Services.AddViewModelsServices();

        //builder.Configuration.AddJsonStream(GetResourceStream("appsettings.json"));
        //builder.Services.AddBlazingPizzaServices(builder.Configuration.GetSection("BlazzingPizzaEndpoints"));

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
