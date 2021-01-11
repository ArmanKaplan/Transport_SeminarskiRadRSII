using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileApplication.ViewModels.Klijenti;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transport.MobileApplication.Views.Klijenti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZahtjeviUplataPage : ContentPage
    {
        private ZahtjeviUplataViewModel model = null;
        public ZahtjeviUplataPage(Model.Zahtjevi z)
        {
            InitializeComponent();
            BindingContext = model = new ZahtjeviUplataViewModel(z);
           
            var source = new HtmlWebViewSource();
            source.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            string HtmlSource = File.ReadAllText("StripeConfirmPayment.html");
            HtmlSource = HtmlSource.Replace("{APIURL}", APIService.ApiUrl);
            HtmlSource = HtmlSource.Replace("{ZAHTJEV_ID}", z.ZahtjevId.ToString());
            source.Html = HtmlSource;
            PaymentWebView.Source = source;
            PaymentWebView.Navigating += PaymentWebView_Navigating;
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }


        private void PaymentWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if(e.Url.Contains("StripePaymentSuccess"))
            {
                e.Cancel = true;
                Navigation.PushModalAsync(new ZahtjeviPagexaml());
            }
        }
       
    }
}