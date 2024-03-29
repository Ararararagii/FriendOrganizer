﻿using Autofac;
using FriendOrganizerUI.Data;
using FriendOrganizerUI.Startup;
using FriendOrganizerUI.ViewModel;
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
    }
}
