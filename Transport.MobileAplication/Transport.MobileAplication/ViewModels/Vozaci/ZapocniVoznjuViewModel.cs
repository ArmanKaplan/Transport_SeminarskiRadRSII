using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels.Vozaci;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Vozaci
{
   public class ZapocniVoznjuViewModel:BaseViewModel1
    {
        private readonly APIService _obavijesti = new APIService("Obavijesti");
        private readonly APIService _voznje = new APIService("Voznje");
        private Model.Voznje _voznja;

        public Model.Voznje Voznja
        {
            get { return _voznja; }
            set { SetProperty(ref _voznja, value); }
        }
        public ZapocniVoznjuViewModel(Model.Voznje voznja)
        {
            InitCommand = new Command(async () => await Init());
            _voznja = voznja;
        }
        public ObservableCollection<Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Obavijesti>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _obavijesti.Get<IEnumerable<Obavijesti>>(null);
            ObavijestiList.Clear();

            foreach (var obavijesti in list)
            {
                
                ObavijestiList.Add(obavijesti);

            }


        }
        public async Task InitZapocniVoznju()
        {
            var listt = await _voznje.Get<IEnumerable<Voznje>>(null);


            foreach (var voznje in listt)
            {
                if (Voznja.VozacId == voznje.VozacId && voznje.Zapoceto == true && voznje.Zavrsen == false)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Već je jedna vožnja aktivna!", "OK");
                    return;
                }
            }

                var request = new VoznjeUpdateRequest()
            {
                Cijena = Voznja.Cijena,
                Kilometraza = Voznja.Kilometraza,
                Napomena = Voznja.Napomena,
                Ocijenjen = false,
                Ocjena = null,
                Odgovoren = Voznja.Odgovoren,
                Prihvacen = Voznja.Prihvacen,
                VozacId = Voznja.VozacId,
                VoznjaID = Voznja.VoznjaId,
                ZahtjevId = Voznja.ZahtjevId,
                Zapoceto = true,
                Zavrsen = Voznja.Zavrsen

            };

            await _voznje.Update<Model.Voznje>(Voznja.VoznjaId, request);

            await Application.Current.MainPage.DisplayAlert("Zapoceta!", "Vožnja je zapoceta!", "OK");

        }
               
            
          
        }
}
