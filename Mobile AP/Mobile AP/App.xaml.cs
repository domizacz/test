using Mobile_AP.Services;
using Mobile_AP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_AP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
