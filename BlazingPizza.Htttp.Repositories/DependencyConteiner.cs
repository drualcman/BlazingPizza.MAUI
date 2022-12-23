using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Htttp.Repositories;

public static class DependencyConteiner
{
    public static IServiceCollection AddHttpRepositoriesServices(this IServiceCollection services,
        IConfigurationSection configurationSection,
        Action<IHttpClientBuilder> builderConfiguration = null)
    {
        IHttpClientBuilder builder =
            services.AddHttpClient<IBlazingPizzaRepository, BlazingPizzaRepository>(HttpClient => 
                                                        new BlazingPizzaRepository(HttpClient, configurationSection));

        builderConfiguration?.Invoke(builder);

        return services;
    }
}
