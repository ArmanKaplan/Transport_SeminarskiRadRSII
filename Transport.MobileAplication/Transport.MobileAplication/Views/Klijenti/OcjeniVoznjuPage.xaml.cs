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
    public partial class OcjeniVoznjuPage : ContentPage
    {
        public OcjeniVoznjuViewModel model ;
        public OcjeniVoznjuPage(Model.Voznje item)
        { 
            InitializeComponent();
            BindingContext = model = new OcjeniVoznjuViewModel(item, Navigation);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }
   

        private async void Ocjeni_Clicked(object sender, EventArgs e)
        {
            await this.model.InitOcjeni();
        }
    }
}