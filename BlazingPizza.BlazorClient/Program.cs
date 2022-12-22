var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpRepositoriesServices(builder.Configuration.GetSection("BlazzingPizzaEndpoints"))
                .AddViewModelsServices();

await builder.Build().RunAsync();
