
using ConsumingApiWithXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumingApiWithXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //var secret = Secrets.AiKey;
            MainPage = new MainPage();
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
