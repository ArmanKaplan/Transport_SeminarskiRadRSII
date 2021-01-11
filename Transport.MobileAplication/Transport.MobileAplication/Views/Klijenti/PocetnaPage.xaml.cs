using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PocetnaPage : ContentPage
    {
        private readonly PocetnaViewModel model;

        public PocetnaPage()
        {
            InitializeComponent();
            BindingContext = model = new PocetnaViewModel(Navigation);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Zahtjev = e.SelectedItem as Zahtjevi;
            Navigation.PushAsync(new DodajZahtjevPage(Zahtjev));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


    }
}