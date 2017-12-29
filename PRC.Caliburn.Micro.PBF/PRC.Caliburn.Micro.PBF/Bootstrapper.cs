using System.Windows;
using Caliburn.Micro;

namespace PRC.Caliburn.Micro.PBF
{
    public class Bootstrapper : BootstrapperBase
    {
        public HelloBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}