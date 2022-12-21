namespace BlazingPizza.Razor.View.Components;

public partial class Specials
{
    [Inject] IGetSpecialsViewModel ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ViewModel.GetSpecials();
    }
}
