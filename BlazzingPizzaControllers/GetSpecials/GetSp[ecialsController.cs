namespace BlazzingPizzaControllers.GetSpecials;

public class GetSp_ecialsController : IGetSpecialsController
{
    readonly IGetSpecialsInputPort InputPort;

    public GetSp_ecialsController(IGetSpecialsInputPort inputPort)
    {
        InputPort = inputPort;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        return await InputPort.GetSpecials();
    }
}
