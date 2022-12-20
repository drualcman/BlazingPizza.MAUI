namespace BlazingPizza.WebApi.EndPoints;

public static class Specials
{
    public static WebApplication UseSpecialsEndPoints(this WebApplication app)
    {
        app.MapGet("/specials", async (IGetSpecialsController controller) =>
        {
            List<PizzaSpecialDto> result = await controller.GetSpecials();
            return Results.Ok(result);
        });
        return app;
    }
}
