using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.MobileApp.ViewModels;
using Transport.MobileApplication.Models.Klijenti;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
    public class ZahtjeviViewModel : BaseViewModel
    {
        private readonly APIService _zahtjeviService = new APIService("Zahtjevi");
        private readonly APIService _voznjeService = new APIService("Voznje");
        public ZahtjeviViewModel()
        {
            InitCommand = new Command(async () => await Init());
            vrstaZahtjevaListt.Add(new VrstaZahtjeva() { Id = 1, Vrsta = "Zahtjevi na obradi" });
            vrstaZahtjevaListt.Add(new VrstaZahtjeva() { Id = 2, Vrsta = "Prihvaćeni zahtjevi" });
            vrstaZahtjevaListt.Add(new VrstaZahtjeva() { Id = 3, Vrsta = "Odbijeni zahtjevi" });


        }

        public ObservableCollection<Zahtjevi> zahtjeviList { get; set; } = new ObservableCollection<Zahtjevi>();

        public ICommand InitCommand { get; set; }
        public ObservableCollection<VrstaZahtjeva> vrstaZahtjevaListt { get; set; } = new ObservableCollection<VrstaZahtjeva>();
        VrstaZahtjeva _selectedVrstaZahtjeva = null;
        public VrstaZahtjeva SelectedVrstaZahtjeva
        {
            get { return _selectedVrstaZahtjeva; }
            set
            {
                SetProperty(ref _selectedVrstaZahtjeva, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public async Task Init()
        {


            var zahtjevilist = await _zahtjeviService.Get<IEnumerable<Zahtjevi>>(null);
            var voznjelist = await _voznjeService.Get<IEnumerable<Voznje>>(null);



            zahtjeviList.Clear();
            foreach (var zahtjevi in zahtjevilist)
            {
                if (_selectedVrstaZahtjeva == null)
                    zahtjeviList.Clear();
                else if (_selectedVrstaZahtjeva.Id == 1 && zahtjevi.Obradjen == false)
                    zahtjeviList.Add(zahtjevi);
                else if (_selectedVrstaZahtjeva.Id == 3 && zahtjevi.Odbijen == true&& zahtjevi.Obradjen==true)
                    zahtjeviList.Add(zahtjevi);
                foreach (var voznje in voznjelist)
                {
                    
                    if (zahtjevi.ZahtjevId == voznje.ZahtjevId)
                    {
                        if (_selectedVrstaZahtjeva == null)
                            zahtjeviList.Clear();
                        else if (_selectedVrstaZahtjeva.Id == 2 &&voznje.Prihvacen==true&&zahtjevi.Obradjen==true)
                            zahtjeviList.Add(zahtjevi);
                 
                       

                    }
             

                }
            }
        }
    }
}


       
