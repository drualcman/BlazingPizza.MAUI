namespace BlazingPizzaBusinessObjects.Interfaces;

public interface IGetSpecialsController
{          
    Task<List<PizzaSpecialDto>> GetSpecials();
}
