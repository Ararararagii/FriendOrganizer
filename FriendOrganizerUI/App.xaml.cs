using Autofac;
using FriendOrganizerUI.Data;
using FriendOrganizerUI.Startup;
using FriendOrganizerUI.ViewModel;
using System;
using System.Windows;

namespace FriendOrganizerUI
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unexcpected error, inorm admin." + Environment.NewLine + e.Exception.Message, "error");

            e.Handled = true;
        }
    }
}
