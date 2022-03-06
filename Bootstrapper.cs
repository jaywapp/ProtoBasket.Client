using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Mvvm;

namespace ProtoBasket.Client
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            // Register MainWindow
            ViewModelLocationProvider.Register<MainWindow, MainWindowModel>();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
