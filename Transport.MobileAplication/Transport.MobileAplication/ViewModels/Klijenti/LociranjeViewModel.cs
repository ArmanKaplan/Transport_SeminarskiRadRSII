using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
    public class LociranjeViewModel : BaseViewModel
    {
        private readonly APIService _lociranjaServices = new APIService("Lociranja");

        public LociranjeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            InitDodajZahtjevCommand = new Command(async () => await InitDodajZahtjev());
        }
        private Model.Lociranja _lociranja;
        public Model.Lociranja Lociranje
        {
            get { return _lociranja; }
            set { SetProperty(ref _lociranja, value); }
        }
        public Model.Voznje Voznja { get; set; }

        public ObservableCollection<Lociranja> Lociranja { get; set; } = new ObservableCollection<Lociranja>();


        public ICommand InitCommand { get; set; }
        public ICommand InitDodajZahtjevCommand { get; set; }

        public async Task Init()
        {
        
          var lociranjaList = await _lociranjaServices.Get<IEnumerable<Model.Lociranja>>(null);
            foreach (var lok in lociranjaList)
            {
                if(lok.VoznjaId==Voznja.VoznjaId)
               Lociranje=lok;
            }

    
          }

    public async Task InitDodajZahtjev()
    {
        var request = new LociranjaInsertRequest()
        {
            KlijentId = APIService.LogovaniKlijent.KlijentId,
            AdministratorId = null,
            Lat = "string",
            Lng = "string",
            Odogovoreno = false,
            Prihvaceno = false,
            VoznjaId = Voznja.VoznjaId


        };

        await _lociranjaServices.Insert<Model.Lociranja>(request);
        await Application.Current.MainPage.DisplayAlert("Obavjest", "Zahtjev za lociranjem je poslat!", "OK");
    
    }


    }
}
