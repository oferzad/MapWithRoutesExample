using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MapWithRoutesExample.Views;
using MapWithRoutesExample.Services;
namespace MapWithRoutesExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Set up google map api key
            GoogleMapsApiService.Initialize("AIzaSyC8mA7SxaosrTtXneUrPNH2HZtUga0vypA");
            MainPage = new ShowMap();
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
