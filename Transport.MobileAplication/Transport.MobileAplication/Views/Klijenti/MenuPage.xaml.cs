using Transport.MobileAplication.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Transport.MobileApplication.Views;
using Transport.MobileApplication;

namespace Transport.MobileAplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Početna, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.NoviZahtjev, Title="Novi zahtjev" },
                new HomeMenuItem {Id = MenuItemType.Zahtjevi, Title="Moji zahtjevi" },
                 new HomeMenuItem {Id = MenuItemType.AktivneVoznje, Title="Moje vožnje" },
                  new HomeMenuItem {Id = MenuItemType.KorisnickiPodaci, Title="Korisnicki podaci" },
                  new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" }
            };
            
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                if(id == (int)MenuItemType.Odjava)
                {
                    APIService.Username = null;
                    APIService.Password = null;
                    Application.Current.MainPage = new Login();
                    return;
                }
                await RootPage.NavigateFromMenu(id);
            };
        }
        protected async override void OnAppearing()
        {
          klijent.Text = APIService.LogovaniKlijent.KorisnickoIme;
        }
    }
}