using Microsoft.Practices.Unity;
using Prism.Unity;
using CarPC.WPFApp.Views;
using System.Windows;

namespace CarPC.WPFApp
{
    class Bootstrapper : UnityBootstrapper
    {
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
