using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
   public class OcjeniVoznjuViewModel:BaseViewModel
    {
        private readonly APIService _voznjeService = new APIService("Voznje");
        private readonly INavigation Navigation;
        private Model.Voznje _voznja;

        public Model.Voznje Voznja
        {
            get { return _voznja; }
            set { SetProperty(ref _voznja, value); }
        }
        public OcjeniVoznjuViewModel(Voznje _voznja, INavigation navigation)
        {
            
            InitOcjeniCommand = new Command(async () => await InitOcjeni());
            Voznja = _voznja;
            this.Navigation = navigation;
        }
   
        public ICommand InitOcjeniCommand { get; set; }
        public async Task InitOcjeni()
        {
            if (ValidirajUnos())
            {
                var request = new VoznjeUpdateRequest()
                {
                    Cijena = Voznja.Cijena,
                    Kilometraza = Voznja.Kilometraza,
                    Napomena = Voznja.Napomena,
                    Ocijenjen = true,
                    Ocjena = Voznja.Ocjena,
                    Odgovoren = Voznja.Odgovoren,
                    Prihvacen = Voznja.Prihvacen,
                    VozacId = Voznja.VozacId,
                    VoznjaID = Voznja.VoznjaId,
                    ZahtjevId = Voznja.ZahtjevId,
                    Zapoceto = Voznja.Zapoceto,
                    Zavrsen = Voznja.Zavrsen

                };

                await _voznjeService.Update<Model.Voznje>(Voznja.VoznjaId, request);


                await Application.Current.MainPage.DisplayAlert("Ocjenjeno!", "Vožnja je ocjenjena!", "OK");
                await Navigation.PopAsync();
            }
            else
            {

            }

        }
        public bool ValidirajUnos()
        {
            if (Voznja.Ocjena<1||Voznja.Ocjena>5)
            {
                Application.Current.MainPage.DisplayAlert("Greška!", "Ocjena mora biti od 1 do 5.", "OK");
                return false;
            }
            return true;
        }
        }
  
}
