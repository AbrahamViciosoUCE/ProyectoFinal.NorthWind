using Microsoft.Extensions.DependencyInjection;
using NorthWind.Infrastructure;
using NorthWind.Winforms.Modals;
using NorthWind.Winforms.Views;

namespace NorthWind.Winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddApplicationLayer();
            serviceCollection.AddInfrastructureLayer();

            serviceCollection.AddScoped<ProductUserControl>();
            serviceCollection.AddScoped<ProductModal>();
            serviceCollection.AddScoped<MainForm>();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(serviceProvider.GetService<MainForm>());
        }
    }
}