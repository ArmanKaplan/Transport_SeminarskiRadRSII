using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajZahtjevPage : ContentPage
    {
        private readonly DodajZahtjevViewModel model = null;

        public DodajZahtjevPage()
        {
            InitializeComponent();
            BindingContext = model = new DodajZahtjevViewModel();
        }

        public DodajZahtjevPage(Model.Zahtjevi zahtjevPreporuka)
        {
            InitializeComponent();
            BindingContext = model = new DodajZahtjevViewModel(zahtjevPreporuka);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await model.Init();
        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.model.InitDodajZahtjev();
        }
    }
}