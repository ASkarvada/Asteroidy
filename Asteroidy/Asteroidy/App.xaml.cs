using Asteroidy.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asteroidy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AsteroidView());
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
