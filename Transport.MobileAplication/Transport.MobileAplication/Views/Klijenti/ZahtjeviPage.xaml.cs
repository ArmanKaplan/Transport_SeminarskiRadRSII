using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.Models.Klijenti;
using Transport.MobileApplication.ViewModels.Klijenti;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZahtjeviPagexaml : ContentPage
    {
        private ZahtjeviViewModel model = null;
        public ZahtjeviPagexaml()
        {
            InitializeComponent();
            BindingContext = model = new ZahtjeviViewModel();
            
       
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
           
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item is Zahtjevi z&& z.Uplaceno!=true&&model.SelectedVrstaZahtjeva.Id==2) {
                Navigation.PushAsync(new ZahtjeviUplataPage(z));
            }
        }
    }
}