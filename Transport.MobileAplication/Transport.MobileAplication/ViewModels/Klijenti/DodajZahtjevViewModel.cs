using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
    public class DodajZahtjevViewModel : BaseViewModel
    {
        private readonly APIService _zahtjeviService = new APIService("Zahtjevi");
        private readonly APIService _tipRobeService = new APIService("TipRobe");
        private readonly APIService _tipVozilaService = new APIService("TipVozila");
        //private readonly APIService _dogadjajiDetalji = new APIService("DogadjajDetalji");

        public DodajZahtjevViewModel()
        {
            InitCommand = new Command(async () => await Init());
            InitDodajZahtjevCommand = new Command(async () => await InitDodajZahtjev());
        }

        public DodajZahtjevViewModel(Zahtjevi zahtjev)
        {
            Zahtjev = new Zahtjevi
            {
                LokacijaUtovara = zahtjev.LokacijaUtovara,
                LokacijaIstovara = zahtjev.LokacijaIstovara,
                TipRobeId = zahtjev.TipRobeId,
                TipVozilaId = zahtjev.TipVozilaId,
                VrstaRobe = zahtjev.VrstaRobe
            };
            InitCommand = new Command(async () => await Init());
            InitDodajZahtjevCommand = new Command(async () => await InitDodajZahtjev());
        }

        public ObservableCollection<Model.Zahtjevi> DogadjajList { get; set; } = new ObservableCollection<Model.Zahtjevi>();
        public ObservableCollection<Model.TipVozila> TipVozilaList { get; set; } = new ObservableCollection<Model.TipVozila>();


        Model.TipVozila _selectedTipVozila = null;
        public ObservableCollection<Model.TipoviRoba> TipoviRobaList { get; set; } = new ObservableCollection<Model.TipoviRoba>();


        Model.TipoviRoba _selectedTipoviRoba = null;

        //    Position Position = new Position();

        //Pin marker = new Pin();



        private Model.Zahtjevi _zahtjev = new Model.Zahtjevi();
        public Model.Zahtjevi Zahtjev
        {
            get { return _zahtjev; }
            set { SetProperty(ref _zahtjev, value); }
        }

        public Model.TipVozila SelectedTipVozila
        {
            get { return _selectedTipVozila; }
            set
            {
                SetProperty(ref _selectedTipVozila, value);

            }
        }
        public Model.TipoviRoba SelectedTipoviRoba
        {
            get { return _selectedTipoviRoba; }
            set
            {
                SetProperty(ref _selectedTipoviRoba, value);

            }
        }

        public ICommand InitCommand { get; set; }
        public ICommand InitDodajZahtjevCommand { get; set; }

        public async Task Init()
        {
            var tipVozila = await _tipVozilaService.Get<IEnumerable<Model.TipVozila>>(null);
            var tipRoba = await _tipRobeService.Get<IEnumerable<Model.TipoviRoba>>(null);

            TipVozilaList.Clear();
            foreach (var tipvozila in tipVozila)
            {
                TipVozilaList.Add(tipvozila);
            }
            TipoviRobaList.Clear();
            foreach (var tiproba in tipRoba)
            {
                TipoviRobaList.Add(tiproba);
            }

            if(Zahtjev.TipVozilaId != 0)
            {
                foreach (var tipvozila in tipVozila)
                {
                    if (Zahtjev.TipVozilaId == tipvozila.TipVozilaId)
                        SelectedTipVozila = tipvozila;
                }
            }
            if(Zahtjev.TipRobeId != 0)
            {
                foreach (var tiproba in tipRoba)
                {
                    if (Zahtjev.TipRobeId == tiproba.TipRobeId)
                        SelectedTipoviRoba = tiproba;
                }
            }
        }


        //public async Task InitPosition(double latitude, double longitude)
        //{
        //    Position = new Position(latitude, longitude);

        //    marker = new Pin()
        //    {
        //        Position = Position,
        //        Type = PinType.Generic,
        //        Label = "Lokacija događaja"
        //    };
        //}


        public async Task InitDodajZahtjev()
        {
            //double lat = Position.Latitude;


            //double lng = Position.Longitude;



            if (ValidirajUnos())
            {
                var request = new ZahtjevInsertRequest()
                {
                    KlijentId = APIService.LogovaniKlijent.KlijentId,
                    TipVozilaId = SelectedTipVozila.TipVozilaId,
                    DatumTransporta = Zahtjev.DatumTransporta,
                    LokacijaIstovara = Zahtjev.LokacijaIstovara,
                    LokacijaUtovara = Zahtjev.LokacijaUtovara,
                    Napomena = Zahtjev.Napomena,
                    Obradjen = false,
                    VrstaRobe = Zahtjev.VrstaRobe,
                    TipRobeId = SelectedTipoviRoba.TipRobeId,
                    Transakcija = null,
                    Uplaceno = false,
                    Odbijen = false

                };

                await _zahtjeviService.Insert<Model.Zahtjevi>(request);

                await Application.Current.MainPage.DisplayAlert("Zahtjev poslan!", "Poslali ste novi zahtjev.", "OK");

                Application.Current.MainPage = new MobileAplication.Views.MainPage();
            }
            else
            {

            }

        }

        public bool ValidirajUnos()
        {
            if (_selectedTipVozila == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Odaberite tip vozila.", "OK");
                return false;
            }
            if (_selectedTipoviRoba == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Odaberite tip robe.", "OK");
                return false;
            }


            if (Zahtjev.LokacijaUtovara == null || Zahtjev.LokacijaUtovara == "")
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti adresu utovara.", "OK");
                return false;
            }

            if (Zahtjev.LokacijaIstovara == null || Zahtjev.LokacijaIstovara == "")
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti adresu istovara.", "OK");
                return false;
            }

            if (Zahtjev.DatumTransporta == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti datum transporta.", "OK");
                return false;
            }




            if (Zahtjev.VrstaRobe == null && Zahtjev.VrstaRobe == "")
            {
                Application.Current.MainPage.DisplayAlert("Greška !", "Obavezno unijeti vrstu robe", "OK");
                return false;
            }

            return true;
        }
    }
}
