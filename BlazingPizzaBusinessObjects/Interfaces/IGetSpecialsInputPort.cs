namespace BlazingPizzaBusinessObjects.Interfaces;

public interface IGetSpecialsInputPort
{
    Task<List<PizzaSpecialDto>> GetSpecials();
}
