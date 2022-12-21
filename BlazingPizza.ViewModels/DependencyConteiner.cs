namespace BlazingPizza.ViewModels;

public static class DependencyConteiner
{
    public static IServiceCollection AddViewModelsServices(this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsViewModel, GetSpecialsViewModel>();
        return services;
    }
}
