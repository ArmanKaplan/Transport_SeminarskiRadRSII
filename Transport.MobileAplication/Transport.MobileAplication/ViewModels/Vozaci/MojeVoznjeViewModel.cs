using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.MobileAplication.ViewModels.Vozaci;
using Transport.MobileApplication.Models.Klijenti;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApplication.ViewModels.Vozaci
{
   public class MojeVoznjeViewModel:BaseViewModel1
    {
        private readonly APIService _mojeVoznjeService = new APIService("Voznje");
        private readonly APIService _zahtjeviService = new APIService("Zahtjevi");
        public MojeVoznjeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            statusVoznjeList.Add(new StatusVoznje() { Id = 1, Status = "Vožnje na čekanju" });
            statusVoznjeList.Add(new StatusVoznje() { Id = 2, Status = "Aktivna vožnja" });
            statusVoznjeList.Add(new StatusVoznje() { Id = 3, Status = "Zavrsene vožnje" });
        }
        public ObservableCollection<Voznje> MojeVoznjeList { get; set; } = new ObservableCollection<Voznje>();
        public ObservableCollection<Zahtjevi> zahtjeviList { get; set; } = new ObservableCollection<Zahtjevi>();
        public ICommand InitCommand { get; set; }
        public ObservableCollection<StatusVoznje> statusVoznjeList { get; set; } = new ObservableCollection<StatusVoznje>();
        StatusVoznje _selectedStatusVoznje = null;
        public StatusVoznje SelectedStatusVoznje
        {
            get { return _selectedStatusVoznje; }
            set
            {
                SetProperty(ref _selectedStatusVoznje, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public async Task Init()
        {
            var list = await _mojeVoznjeService.Get<IEnumerable<Voznje>>(null);
            MojeVoznjeList.Clear();
   
            foreach (var voznje in list)
            {
                
           
                    if (_selectedStatusVoznje == null)
                        zahtjeviList.Clear();
                    else if (_selectedStatusVoznje.Id == 1 && voznje.Prihvacen == true && voznje.Zavrsen == false && voznje.Zapoceto == false)
                    MojeVoznjeList.Add(voznje);
                
                else if (_selectedStatusVoznje.Id == 2 && voznje.Prihvacen == true && voznje.Zavrsen == false && voznje.Zapoceto == true)
                    MojeVoznjeList.Add(voznje);
          
                else if (_selectedStatusVoznje.Id == 3 && voznje.Prihvacen == true && voznje.Zavrsen == true && voznje.Zapoceto == true)
                    MojeVoznjeList.Add(voznje);
               
            }
           
         
        }
    }
}
