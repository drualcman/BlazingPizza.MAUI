namespace BlazingPizzaBusinessObjects.Interfaces;

public interface IGetSpecialsViewModel
{
    List<PizzaSpecialDto> Specials { get; }
    ValueTask GetSpecials();
}
