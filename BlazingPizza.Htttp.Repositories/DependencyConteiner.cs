using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Htttp.Repositories;

public static class DependencyConteiner
{
    public static IServiceCollection AddHttpRepositoriesServices(this IServiceCollection services,
        IConfigurationSection configurationSection)
    {
        services.AddHttpClient<IBlazingPizzaRepository, BlazingPizzaRepository>(HttpClient => 
                                                     new BlazingPizzaRepository(HttpClient, configurationSection));
        return services;
    }
}
