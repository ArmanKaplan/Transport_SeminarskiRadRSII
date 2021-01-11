using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Transport.MobileApplication.Views.Vozaci;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AktivneVoznjePage : ContentPage
    {
        private readonly APIService _mojeVoznjeService = new APIService("Voznje");
        private MojeVoznjeViewModel model = null;
        public AktivneVoznjePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeVoznjeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Voznje;
            var list = await _mojeVoznjeService.Get<IEnumerable<Voznje>>(null);
            //if (e.SelectedItem is Voznje v&&v.Prihvacen == true && v.Zavrsen == false && v.Zapoceto == false && model.SelectedStatusVoznje.Id == 1)
            //{
            //    await Navigation.PushAsync(new LocirajVoznjuPage(item));
            //}
            //else if(e.SelectedItem is Voznje k && k.Prihvacen == true && k.Zavrsen == false && k.Zapoceto == true && model.SelectedStatusVoznje.Id == 2)
            //{
            //    await Navigation.PushAsync(new OcjeniVoznjuPage(item));

            //}

            foreach (var voznje in list)
            {

                if (voznje.Prihvacen == true && voznje.Zavrsen == false && voznje.Zapoceto == true && model.SelectedStatusVoznje.Id == 1)
                {
                    await Navigation.PushAsync(new LocirajVoznjuPage(item));
                    return;
                }
                else if (voznje.Prihvacen == true && voznje.Zavrsen == true && voznje.Zapoceto == true && model.SelectedStatusVoznje.Id == 2)
                {
                    await Navigation.PushAsync(new OcjeniVoznjuPage(item));
                    return;
                }


            }
        }

        }
    }
