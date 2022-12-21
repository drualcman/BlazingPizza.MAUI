namespace BlazingPizza.Htttp.Repositories;

public class BlazingPizzaRepository : IBlazingPizzaRepository
{
    readonly HttpClient Client;
    readonly IConfigurationSection ConfigurationSection;

    public BlazingPizzaRepository(HttpClient client, IConfigurationSection configurationSection)
    {
        Client = client;
        ConfigurationSection = configurationSection;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        return await Client.GetFromJsonAsync<List<PizzaSpecialDto>>(ConfigurationSection["specials"]);
    }
}
