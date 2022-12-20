namespace BlazzingPizza.IoC;

public static class DependencyConteiner
{
    public static IServiceCollection AddBlazingPizzaServices(this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName)
    {
        services
            .AddRepositoriesServices(configuration, connectionStringName)
            .AddUseCases()
            .AddControllersServices();
        return services;
    }
}
