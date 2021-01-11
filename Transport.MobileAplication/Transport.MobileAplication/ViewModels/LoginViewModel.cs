using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transport.MobileAplication.ViewModels;
using Transport.MobileAplication.Views;
using Transport.MobileApplication;
using Transport.MobileApplication.Views;
using Transport.Model;
using Xamarin.Forms;

namespace Transport.MobileApp.ViewModels
{
   public class LoginViewModel:BaseViewModel
    {
        private readonly APIService serviceKlijenti = new APIService("Klijenti");
        private readonly APIService serviceVozaci = new APIService("Vozaci");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
             
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            var request = new LoginSearchRequest
            {
                KorisnickoIme = Username,
                Lozinka = Password
            };
            try
            {
                var klijent = await serviceKlijenti.Get<Model.Klijenti>(request, "login", true);
                if (klijent != null) {
                
                    Application.Current.MainPage = new MobileAplication.Views.MainPage();
                    APIService.LogovaniKlijent = klijent;
                    return;
                }
            }
            catch (Exception ex)
            {
            
            }

            try
            {
                var vozac = await serviceVozaci.Get<Model.Vozaci>(request, "login");
                if (vozac != null)
                {
                    Application.Current.MainPage = new MobileAplication.Views.Vozaci.MainPage1();
                    APIService.LogovaniVozac = vozac;
                    return;
                }
            }
            catch (Exception ex1)
            {
            }
       
            IsBusy = false;
            
        } 
    }

}
