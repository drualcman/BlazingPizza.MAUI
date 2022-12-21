namespace BlazzingPizza.IoC;

public static class DependencyConteiner
{
    public static IServiceCollection AddBlazingPizzaServices(this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName, 
        string imageBaseUrlName)
    {
        services
            .AddRepositoriesServices(configuration, connectionStringName)
            .AddUseCases()
            .AddControllersServices()
            .AddPresentersServices(configuration[imageBaseUrlName]);
        return services;
    }
}
