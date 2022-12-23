using BlazingPizza.Razor.View.Helpers;
using BlazingPizza.UI.IoC;

namespace BlazingPizza.WinFormsClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        RegisterServices();
        SetIcon();
    }

    void RegisterServices()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        IServiceCollection services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        services.AddBlazingPizzaServices(configuration.GetSection("BlazzingPizzaEndpoints"));

        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<App>("#app");
    }    
    void SetIcon()
    {
        Stream stream = WWWRoot.GetResourceStream("images/icon-512.png");
        if(stream != null)
        {
            Bitmap bitmap = new Bitmap(stream);
            Icon = Icon.FromHandle(bitmap.GetHicon());
        }
    }
}