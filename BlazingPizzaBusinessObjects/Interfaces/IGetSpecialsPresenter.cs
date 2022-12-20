namespace BlazingPizzaBusinessObjects.Interfaces;

public interface IGetSpecialsPresenter
{
    Task<List<PizzaSpecialDto>> GetSpecials(List<PizzaSpecialDto> spacials);
}
