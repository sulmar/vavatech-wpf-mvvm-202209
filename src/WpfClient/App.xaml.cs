using Bogus;
using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Fakers;
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
using WpfClient.Services;
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

                services.AddSingleton<CustomersView>();
                services.AddSingleton<CustomersViewModel>();
                services.AddSingleton<ICustomerRepository, FakeCustomerRepository>();
                services.AddSingleton<Faker<Customer>, CustomerFaker>();

                services.AddSingleton<ProductsView>();
                services.AddSingleton<ProductsViewModel>();
                services.AddSingleton<IProductRepository, FakeProductRepository>();
                services.AddSingleton<Faker<Product>, ProductFaker>();

                services.AddSingleton<HomeView>();

                services.AddSingleton<DashboardView>();
                services.AddSingleton<DashboardViewModel>();

                services.AddSingleton<CounterView>();
                services.AddSingleton<CounterViewModel>();

                services.AddSingleton<MapCustomersView>();

                services.AddSingleton<INavigationService, FrameNavigationService>();
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
