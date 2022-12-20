namespace BlazingPizza.Presenters.GetSpecials;

public class GetSpecialsPresenter : IGetSpecialsPresenter
{
    readonly string ImagesBaseUrl;
    public GetSpecialsPresenter(string imagesBaseUrl)
    {
        ImagesBaseUrl = imagesBaseUrl;
    }
    public Task<List<PizzaSpecialDto>> GetSpecials(List<PizzaSpecialDto> specials)
    {
        foreach(PizzaSpecialDto item in specials)
        {
            item.ImageUrl= $"{ImagesBaseUrl}/{item.ImageUrl}";
        }
        //specials.ForEach(special => { special.ImageUrl = $"{ImagesBaseUrl}/{special.ImageUrl}" });
        return Task.FromResult(specials);
    }
}
