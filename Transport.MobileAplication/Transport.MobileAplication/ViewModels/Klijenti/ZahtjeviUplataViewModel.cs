using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Klijenti
{
   public class ZahtjeviUplataViewModel:BaseViewModel
    {
        private readonly APIService _voznjeServices = new APIService("Voznje");
        private Model.Zahtjevi zahtjev;
     
        public ZahtjeviUplataViewModel(Model.Zahtjevi z)
        {
            InitCommand = new Command(async () => await Init());
            zahtjev = z;
        }

        private Model.Voznje _voznje;
        public Model.Voznje Voznja
        {
            get { return _voznje; }
            set { SetProperty(ref _voznje, value); }
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            var voznjeList = await _voznjeServices.Get<IEnumerable<Model.Voznje>>(null);
            foreach (var voznja in voznjeList)
            {
                if (voznja.ZahtjevId==zahtjev.ZahtjevId)
                    Voznja = voznja;
                
            }


        }
    }
}
