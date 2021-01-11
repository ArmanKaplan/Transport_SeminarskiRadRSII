using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Vozaci;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojeVoznjePage : ContentPage
    {
        private readonly APIService _mojeVoznjeService = new APIService("Voznje");
        private readonly APIService _lociranjaService = new APIService("Lociranja");
        private MojeVoznjeViewModel model = null;
        public MojeVoznjePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeVoznjeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
          
     
        }

   
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Voznje;
            var list = await _mojeVoznjeService.Get<IEnumerable<Voznje>>(null);

         



            foreach (var voznje in list)
            {
                if (voznje.Prihvacen == true && voznje.Zavrsen == false && voznje.Zapoceto == false && model.SelectedStatusVoznje.Id == 1)
                {
                    await Navigation.PushAsync(new ZapocniVoznjuPage(item));
                    return;
                }
                else if (voznje.Prihvacen == true && voznje.Zavrsen == false && voznje.Zapoceto == true && model.SelectedStatusVoznje.Id == 2)
                {
                    await Navigation.PushAsync(new AktivnaVoznjaPage(item));
                    return;
                }
                 

              
            }


        }

    }
}