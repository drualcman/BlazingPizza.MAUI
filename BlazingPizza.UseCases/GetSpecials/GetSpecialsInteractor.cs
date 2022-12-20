namespace BlazingPizza.UseCases.GetSpecials;

public class GetSpecialsInteractor : IGetSpecialsInputPort
{
    readonly IBlazingPizzaRepository Repository;
    readonly IGetSpecialsPresenter Presenter;

    public GetSpecialsInteractor(IBlazingPizzaRepository repository, IGetSpecialsPresenter presenter)
    {
        Repository = repository;
        Presenter = presenter;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        List<PizzaSpecialDto> result = await Repository.GetSpecials();
        result.OrderByDescending(s => s.BasePrice).ToList();
        return await Presenter.GetSpecials(result);
    }
}
