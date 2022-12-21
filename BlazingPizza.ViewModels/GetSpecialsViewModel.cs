namespace BlazingPizza.ViewModels
{
    public class GetSpecialsViewModel : IGetSpecialsViewModel
    {
        readonly IBlazingPizzaRepository Repository;

        public GetSpecialsViewModel(IBlazingPizzaRepository repository)
        {
            Repository = repository;
        }

        public List<PizzaSpecialDto> Specials { get ; private set; }

        public async ValueTask GetSpecials()
        {
            Specials = await Repository.GetSpecials();
        }
    }
}
