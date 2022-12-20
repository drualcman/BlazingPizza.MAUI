namespace BlazingPizza.UseCases;

public static class DependencyConteiner
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();
        return services.AddUseCases();
    }
}
