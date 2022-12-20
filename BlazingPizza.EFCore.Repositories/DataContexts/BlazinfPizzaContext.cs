namespace BlazingPizza.EFCore.Repositories.DataContexts;

public class BlazinfPizzaContext : DbContext
{
	public BlazinfPizzaContext(DbContextOptions options) : base(options) { }

	public DbSet<PizzaSpecial> Specials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
