using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MapWithRoutesExample.Views;
using MapWithRoutesExample.Services;
namespace MapWithRoutesExample
{
    public class Constants
    {
        //Generate Google Api Key at: https://console.cloud.google.com/ for Places API, Directions API, Maps SDK For android!
        //Generate Bing Api Key at: https://www.bingmapsportal.com/
        public const string GoogleApiKey = "YOUR GOOGLE API KEY";
        public const string BingApiKey = "YOUR BING API KEY";
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Set up google map api key
            GoogleMapsApiService.Initialize(Constants.GoogleApiKey);
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
