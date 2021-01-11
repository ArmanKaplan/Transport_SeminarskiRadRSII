using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.MobileAplication.Views;
using Transport.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
    public class KorisnickiPodaciViewModel : BaseViewModel
    {
        private readonly APIService _klijentiService = new APIService("Klijenti");
        private int _klijentId;
        private Model.KlijentiUpdateRequest _klijent;
        public Model.KlijentiUpdateRequest Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }
        public ICommand SpasiProfilCommand { get; set; }
        public KorisnickiPodaciViewModel()
        {
            SpasiProfilCommand = new Command(async () => await SpasiProfil());
        }

        public async Task Init()
        {
            _klijentId = APIService.LogovaniKlijent.KlijentId;
            await LoadUser();
        }
        private async Task LoadUser()
        {
            Klijent = await _klijentiService.GetById<Model.KlijentiUpdateRequest>(_klijentId);

            Title = Klijent.KorisnickoIme+"- Korisnicki podaci";


        }
        private async Task SpasiProfil()
        {
            var entity = await _klijentiService.Update<Model.Klijenti>(APIService.LogovaniKlijent.KlijentId, Klijent);
            if (entity != null)
            {
                APIService.Username = Klijent.KorisnickoIme;
                if (!string.IsNullOrEmpty(Klijent.Password))
                {
                    APIService.Password = Klijent.Password;
                }

                await Application.Current.MainPage.DisplayAlert("Uspjeh", "Izmjene profila su uspješno sačuvane.", "OK");
                Application.Current.MainPage = new MainPage();
            }
        }
    }
}
