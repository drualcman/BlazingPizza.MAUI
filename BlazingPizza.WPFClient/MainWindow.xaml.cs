using BlazingPizza.Razor.View.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

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
            SetIcon();
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

        void SetIcon()
        {
            Stream stream = WWWRoot.GetResourceStream("images/icon-512.png");
            if(stream != null)
            {
                Icon = BitmapFrame.Create(stream);
            }
        }
    }
}
