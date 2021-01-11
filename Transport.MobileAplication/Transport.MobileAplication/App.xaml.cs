using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Transport.MobileAplication.Views;
using Transport.MobileApplication.Views;
using Transport.MobileAplication.Views.Vozaci;
using Transport.MobileApplication.Views.Klijenti;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Transport.MobileAplication
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
