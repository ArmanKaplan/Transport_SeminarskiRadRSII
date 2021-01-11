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
    public partial class RegistracijaPage : ContentPage
    {
        private RegistracijaViewModel VM;

        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = VM = new RegistracijaViewModel();
        }

        private void LoginLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }
    }
}