using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Transport.MobileAplication.ViewModels.Vozaci
{
    public class AboutViewModel1 : BaseViewModel1
    {
        public  AboutViewModel1()
        {
            Title = "About";

            OpenWebCommand = new Command(() =>  Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}