namespace BlazingPizza.MAUI.Handlers;

internal class CustomHttpMessageHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
        if(request.RequestUri.AbsoluteUri.EndsWith("specials"))
        {
            string content = await response.Content.ReadAsStringAsync();
            content = content.Replace("https://localhost:7111/images/pizzas", "https://tivc01.blob.core.windows.net/tests");
            response.Content = new StringContent(content);
        }
        return response;
    }
}
