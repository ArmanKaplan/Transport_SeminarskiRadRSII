using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Vozaci;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AktivnaVoznjaPage : ContentPage
    {
        public Model.Voznje _voznje;
        private AktivnaVoznjaViewModel model = null;
        public AktivnaVoznjaPage(Model.Voznje item)
        {
            InitializeComponent();
            BindingContext = model = new AktivnaVoznjaViewModel(item);

            _voznje = item;

            //var webViewURL = "https://www.google.com/maps/dir/Stolac/" + _voznje.Zahtjev.LokacijaIstovara;

            //WebView.Source = "https://www.google.com/maps/dir/Stolac/Mostar";
        }
        
        protected async override void OnAppearing()
        {
            
            base.OnAppearing();
            await model.Init();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VoznjeDetaljiPage(_voznje));
        }

        private async void PrijaviKvar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrijavaKvaraPage(_voznje));
        }
      
        private async void Zavrsi_Clicked(object sender, EventArgs e)
        {

            await model.InitZavrsiVoznju();
            Application.Current.MainPage = new MobileAplication.Views.Vozaci.MainPage1();
           
        }

        private async void PrikaziRutu_Clicked(object sender, EventArgs e)
        {
            

           

            var placemark = new Placemark
            {
                CountryName = "Bosnia and Herzegovina",

                Thoroughfare = _voznje.Zahtjev.LokacijaIstovara.Substring(_voznje.Zahtjev.LokacijaIstovara.LastIndexOf(',') + 1),
                Locality = _voznje.Zahtjev.LokacijaIstovara.Substring(0, _voznje.Zahtjev.LokacijaIstovara.IndexOf(","))
            };


            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            try
            {

                await Xamarin.Essentials.Map.OpenAsync(placemark, options);
            }
            catch (Exception ex)
            {
                // No map application available to open or placemark can not be located
            }
        }
    }
}