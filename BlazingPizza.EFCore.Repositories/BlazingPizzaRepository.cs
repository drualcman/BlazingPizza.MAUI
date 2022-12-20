namespace BlazingPizza.EFCore.Repositories;

public class BlazingPizzaRepository : IBlazingPizzaRepository
{
    readonly BlazinfPizzaContext Context;

    public BlazingPizzaRepository(BlazinfPizzaContext context)
    {
        Context = context;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        return await Context.Specials
                    .AsNoTracking()                         //improve the query avoing the tracking because is a simple query
                    .Select(s => s.ToPizzaSpecialDto())
                    .ToListAsync();
    }
}
