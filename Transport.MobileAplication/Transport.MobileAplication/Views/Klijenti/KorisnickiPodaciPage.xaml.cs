using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnickiPodaciPage : ContentPage
    {
        private readonly KorisnickiPodaciViewModel VM;
        public KorisnickiPodaciPage()
        {
            InitializeComponent();
            BindingContext = VM = new KorisnickiPodaciViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }
    }
}