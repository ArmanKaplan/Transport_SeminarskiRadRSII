using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Vozaci;
using Transport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZapocniVoznjuPage : ContentPage
    {
        private ZapocniVoznjuViewModel model = null;
        public Voznje _voznja;
        public ZapocniVoznjuPage(Model.Voznje item)
        {
            _voznja = item;
            InitializeComponent();
            BindingContext = model = new ZapocniVoznjuViewModel(item);
        }
  
    

       
         

        private async void Zapocni_Clicked(object sender, EventArgs e)
        {
            await this.model.InitZapocniVoznju();
            await Navigation.PushAsync(new AktivnaVoznjaPage(_voznja));
         

        }

        private async void Odustani_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MojeVoznjePage());
        }
    }
}