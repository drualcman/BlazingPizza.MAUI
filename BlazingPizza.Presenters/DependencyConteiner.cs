namespace BlazingPizza.Presenters;

public static class DependencyConteiner
{
    public static IServiceCollection AddPresentersServices(this IServiceCollection services, string imagesUrl)
    {
        services.AddScoped<IGetSpecialsPresenter>(provider => new GetSpecialsPresenter(imagesUrl));
        return services;
    }
}
