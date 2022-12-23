using BlazingPizza.Htttp.Repositories;
using BlazingPizza.ViewModels;

namespace BlazingPizza.UI.IoC;

public static class DependencyConteiner
{
    public static IServiceCollection AddBlazingPizzaServices(this IServiceCollection services,
        IConfigurationSection configuration)
    {
        services.AddHttpRepositoriesServices(configuration);
        services.AddViewModelsServices();
        return services;
    }
}
