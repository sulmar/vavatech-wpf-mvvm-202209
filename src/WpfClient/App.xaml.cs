using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModels;
using WpfClient.Views;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        // PM> Install-Package Microsoft.Extensions.Hosting.Abstractions
        public static IHost AppHost { get; private set; }

        public App()
        {
            // PM> Install-Package Microsoft.Extensions.Hosting
            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices(services =>
            {
                services.AddSingleton<ShellView>();
                services.AddSingleton<ShellViewModel>();
            });


            AppHost = builder.Build();

        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            // var startupView = new ShellView(new ViewModels.ShellViewModel());

            await AppHost.StartAsync();

            var startupView = AppHost.Services.GetRequiredService<ShellView>();

            startupView.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();

            base.OnExit(e);
        }
    }
}
