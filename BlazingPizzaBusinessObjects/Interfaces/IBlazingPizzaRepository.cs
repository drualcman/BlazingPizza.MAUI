namespace BlazingPizzaBusinessObjects.Interfaces
{
    public interface IBlazingPizzaRepository
    {
        Task<List<PizzaSpecialDto>> GetSpecials();
    }
}
