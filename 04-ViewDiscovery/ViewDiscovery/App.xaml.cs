﻿using Prism.Ioc;
using Prism.DryIoc;
using System.Windows;
using ViewDiscovery.Views;

namespace ViewDiscovery
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
