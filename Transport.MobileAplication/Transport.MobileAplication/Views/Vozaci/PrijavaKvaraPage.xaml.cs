using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Vozaci;
using Transport.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrijavaKvaraPage : ContentPage
    {
        private readonly APIService _kvaroviService = new APIService("Kvarovi");
 

        private readonly PrijavaKvaraViewModel model = null;
        public PrijavaKvaraPage(Voznje item)
        {
            InitializeComponent();
            
            BindingContext = model = new PrijavaKvaraViewModel() { Voznja = item
        };
        }



        public async void GetLocation()
        {


            Location location = await Geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)

                }); ;
            }
            else
            {


                if (ValidirajUnos())
                {
                    var request = new KvaroviInsertRequest()
                    {

                        Lat = location.Latitude.ToString(),
                        Lng = location.Longitude.ToString(),
                        Lokacija = model.Kvar.Lokacija,
                        Opis = model.Kvar.Opis,
                        VoznjaId = model.Voznja.VoznjaId,
                        Prioritetno = model.Kvar.Prioritetno



                    };

                    await _kvaroviService.Insert<Model.Kvarovi>(request);
                    await Application.Current.MainPage.DisplayAlert("Kvar prijavljen", "Uspješno ste locirani, kvar je prijavljen, sacekajte na toj lokaciji dok pomoć ne stigne!", "OK");
                    await Navigation.PushAsync(new AktivnaVoznjaPage(model.Voznja));
                }
                else
                {

                }

            }

        }
        public bool ValidirajUnos()
        {
            if (model.Kvar.Lokacija == null || model.Kvar.Lokacija == "")
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti lokaciju.", "OK");
                return false;
            }
           if (model.Kvar.Opis == null || model.Kvar.Opis == "")
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti opis.", "OK");
                return false;
            }
            return true;
        }
        private  void Button_Clicked(object sender, EventArgs e)
        {
            GetLocation();
        }
    }
}