namespace BlazingPizza.UseCases.GetSpecials;

public class GetSpecialsInteractor : IGetSpecialsInputPort
{
    readonly IBlazingPizzaRepository Repository;

    public GetSpecialsInteractor(IBlazingPizzaRepository repository)
    {
        Repository = repository;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        List<PizzaSpecialDto> result = await Repository.GetSpecials();
        return result.OrderByDescending(s => s.BasePrice).ToList();
    }
}
