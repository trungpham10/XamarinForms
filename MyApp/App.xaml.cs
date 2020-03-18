using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayout();

            //Padding = Device.OnPlatForm;
            //{
            //    Android: new Thickness(20, 30, 20, 20);
            //    iOS: new Thickness(20, 40, 20, 20);
            //};

            string[] quotes = {"quote1", "quote2", "quote3"};

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
