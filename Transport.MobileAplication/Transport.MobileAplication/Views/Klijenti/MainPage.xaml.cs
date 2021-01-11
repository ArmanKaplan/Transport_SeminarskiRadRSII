using Transport.MobileAplication.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Transport.Model;
using Transport.MobileApplication.Views.Klijenti;
using Transport.MobileApplication.Views.Vozaci;

namespace Transport.MobileAplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Početna:
                        MenuPages.Add(id, new NavigationPage(new MobileApplication.Views.Klijenti.PocetnaPage()));
                        break;
                    case (int)MenuItemType.NoviZahtjev:
                        MenuPages.Add(id, new NavigationPage(new DodajZahtjevPage()));
                        break;
                    case (int)MenuItemType.Zahtjevi:
                        MenuPages.Add(id, new NavigationPage(new ZahtjeviPagexaml()));
                        break;
                    case (int)MenuItemType.AktivneVoznje:
                        MenuPages.Add(id, new NavigationPage(new MobileApplication.Views.Klijenti.AktivneVoznjePage()));
                        break;
                    case (int)MenuItemType.KorisnickiPodaci:
                        MenuPages.Add(id, new NavigationPage(new KorisnickiPodaciPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}