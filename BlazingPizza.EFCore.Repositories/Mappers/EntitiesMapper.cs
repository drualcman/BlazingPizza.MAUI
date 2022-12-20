

namespace BlazingPizza.EFCore.Repositories.Mappers;

static internal class EntitiesMapper
{
    public static PizzaSpecialDto ToPizzaSpecialDto(this PizzaSpecial special) =>
        new PizzaSpecialDto
        {
            Id = special.Id,
            Name = special.Name,
            BasePrice = special.BasePrice,
            Description = special.Description,
            ImageUrl = special.ImageUrl
        };
}
