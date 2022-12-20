namespace BlazzingPizzaControllers;

public static class DependencyConteiner
{
    public static IServiceCollection AddControllersServices(this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsController, GetSp_ecialsController>();
        return services;
    }
}
