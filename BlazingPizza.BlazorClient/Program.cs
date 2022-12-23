using BlazingPizza.UI.IoC;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazingPizzaServices(builder.Configuration.GetSection("BlazzingPizzaEndpoints"));

await builder.Build().RunAsync();
