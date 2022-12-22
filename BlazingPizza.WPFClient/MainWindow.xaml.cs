using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazingPizza.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RegisterServices();
        }

        void RegisterServices()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            IServiceCollection services = new ServiceCollection();
            services.AddWpfBlazorWebView();
            services.AddHttpRepositoriesServices(configuration.GetSection("BlazzingPizzaEndpoints"));
            services.AddViewModelsServices();

            Resources.Add("Services", services.BuildServiceProvider());
        }
    }
}
