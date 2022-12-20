namespace BlazingPizza.EFCore.Repositories.DataContexts;

internal class BlazingPizzaContextFactory : IDesignTimeDbContextFactory<BlazinfPizzaContext>
{
    public BlazinfPizzaContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BlazinfPizzaContext> optionsBuilder = new DbContextOptionsBuilder<BlazinfPizzaContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=BlazzingPizzaMaui");
        return new BlazinfPizzaContext(optionsBuilder.Options);
    }
}
