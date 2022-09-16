using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ViewModels;

namespace WpfClient.Services
{
    internal class FrameNavigationService : INavigationService
    {
        private readonly IServiceProvider serviceProvider;

        public FrameNavigationService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Navigate(Type viewType)
        {
            var frame = Get("ContentFrame");

            var view = serviceProvider.GetService(viewType);

            frame.Navigate(view);

        }

        private Frame Get(string name)
        {
            if (Application.Current.MainWindow.FindName(name) is Frame frame)
            {
                return frame;
            }

            throw new KeyNotFoundException(name);
        }
    }
}
