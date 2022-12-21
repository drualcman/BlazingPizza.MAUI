namespace BlazzingPizzaControllers.GetSpecials;

public class GetSp_ecialsController : IGetSpecialsController
{
    readonly IGetSpecialsInputPort InputPort; 
    readonly IGetSpecialsPresenter Presenter;

    public GetSp_ecialsController(IGetSpecialsInputPort inputPort, IGetSpecialsPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;
    }

    public async Task<List<PizzaSpecialDto>> GetSpecials()
    {
        return await Presenter.GetSpecials(await InputPort.GetSpecials());
    }
}
