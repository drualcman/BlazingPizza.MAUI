using BlazingPizza.MAUI.Properties;
using Microsoft.Extensions.Configuration;

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

        string dbPath = System.IO.Path.Combine("Resources", "appsettings.json");
        builder.Configuration.AddJsonFile(dbPath);

        builder.Services.AddHttpRepositoriesServices(builder.Configuration.GetSection("BlazzingPizzaEndpoints"))
                .AddViewModelsServices();

        return builder.Build();
    }
}
