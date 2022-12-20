namespace BlazingPizza.EFCore.Repositories;

public static class DependencyConteiner
{
    public static IServiceCollection AddRepositoriesServices(this IServiceCollection services, 
        IConfiguration configuration,
        string connectionStringName)
    {
        services.AddDbContext<BlazinfPizzaContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
        services.AddScoped<IBlazingPizzaRepository, BlazingPizzaRepository>();
        return services;
    }
}
