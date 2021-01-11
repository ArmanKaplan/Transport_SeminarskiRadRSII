using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.MobileApplication.Models.Klijenti;
using Transport.MobileApplication.Views.Klijenti;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
    public class PocetnaViewModel : BaseViewModel
    {

        private readonly APIService _preporukaService = new APIService("Preporuka");
        private readonly INavigation Navigation;

        public PocetnaViewModel(INavigation navigation)
        {
            InitCommand = new Command(async () => await Init());
            KreirajZahtjevCommand = new Command<Model.Zahtjevi>(async (zahtjev) => await KreirajZahtjev(zahtjev));
            this.Navigation = navigation;
        }

        private async Task KreirajZahtjev(Zahtjevi zahtjev)
        {
            await Navigation.PushAsync(new DodajZahtjevPage(zahtjev));
        }

        public ObservableCollection<Zahtjevi> PreporukaList { get; set; } = new ObservableCollection<Zahtjevi>();
        public ICommand InitCommand { get; set; }
        public ICommand KreirajZahtjevCommand { get; set; }

        public async Task Init()
        {
            var list = await _preporukaService.Get<List<Zahtjevi>>(null, "PreporuciLokacijuIstovara");
            PreporukaList.Clear();

            foreach (var zahtjev in list)
            {
                PreporukaList.Add(zahtjev);
            }
        }
    }
}

