using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels.Vozaci;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Vozaci
{
    public class VoznjeDetaljiViewModel : BaseViewModel1
    {
        private readonly APIService _lociranjaServices = new APIService("Lociranja");
        public VoznjeDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public Voznje Voznje { get; set; }

        private Model.Lociranja _lociranja;
        public Model.Lociranja Lociranja
        {
            get { return _lociranja; }
            set { SetProperty(ref _lociranja, value); }
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

         
            var lociranjaList = await _lociranjaServices.Get<IEnumerable<Model.Lociranja>>(null);
            foreach (var lok in lociranjaList)
            {
                if (lok.VoznjaId == Voznje.VoznjaId && lok.KlijentId!=0&&lok.Odogovoreno==false)
                    Lociranja = lok;
              else if (lok.VoznjaId == Voznje.VoznjaId && lok.AdministratorId != 0&&lok.Odogovoreno==false)
                    Lociranja = lok;
            }


        }
    }
}
