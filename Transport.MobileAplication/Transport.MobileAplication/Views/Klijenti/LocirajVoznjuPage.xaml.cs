using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Transport.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocirajVoznjuPage : ContentPage
    {
        private LociranjeViewModel model = null;
        private readonly APIService _lociranjaServices = new APIService("Lociranja");
        public  LocirajVoznjuPage(Model.Voznje item)
        {
            InitializeComponent();
            BindingContext = model = new LociranjeViewModel()
            {
                Voznja = item

            };
     
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
             Lociranje();
        }
        public  void Lociranje()
        {
            if (model.Lociranje == null)
            {
                map.IsVisible = false;
                labela.Text = "Želite locirati vozača?";
                Lociraj.IsVisible = true;
            }
           else if (model.Lociranje.Odogovoreno == true && model.Lociranje.Prihvaceno == true && model.Lociranje.KlijentId!=null)
            {
                double lat = 0;
                double longt = 0;

                Lociraj.IsVisible = true;
                lat = /*Convert.ToDouble(loc.Lat);*/double.Parse(model.Lociranje.Lat.Replace(',', '.'), CultureInfo.InvariantCulture);
                longt = /*Convert.ToDouble(loc.Lng);*/double.Parse(model.Lociranje.Lng.Replace(',', '.'), CultureInfo.InvariantCulture);
             
                Pin lokacija = new Pin()
                {
                    
                    Position = new Position(lat, longt),
                    Label = "Lokacija vozača",
                    Type = PinType.Generic
                };

                map.Pins.Add(lokacija);
                
                Position pozicija = new Position(lat, longt);
                map.MoveToRegion(new MapSpan(pozicija, 0.1, 0.1));
            }
            else if (model.Lociranje.Odogovoreno == true && model.Lociranje.Prihvaceno == false && model.Lociranje.KlijentId != null)
            {
                map.IsVisible = false;
                Lociraj.IsVisible = true;
                labela.Text = "Vaš posljednji zahtjev je odbijen!\n \nKlikni na lociraj za ponovno slanje";
                Application.Current.MainPage.DisplayAlert("Obavjest!", "Vozač je odbio vas zadnji posalni zahtjev!", "OK");
            }
            else if (model.Lociranje.Odogovoreno == false && model.Lociranje.Prihvaceno == false && model.Lociranje.KlijentId != null)
            {
                map.IsVisible = false;
                labela.Text = "Vozač jos uvijek nije prihvatio zahtjev!";
                Lociraj.IsVisible = false;
                Application.Current.MainPage.DisplayAlert("Obavjest!", "Na poslani zahtjev jos nije odgovoreno!", "OK");
            }
          



        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
     
             await model.InitDodajZahtjev();
            await Application.Current.MainPage.DisplayAlert("Obavjest!", "Zahtjev za lokacijom poslat!", "OK");
            map.IsVisible = false;
            labela.Text = "Vozač jos uvijek nije prihvatio zahtjev!";
            Lociraj.IsVisible = false;




        }

   
    }
}