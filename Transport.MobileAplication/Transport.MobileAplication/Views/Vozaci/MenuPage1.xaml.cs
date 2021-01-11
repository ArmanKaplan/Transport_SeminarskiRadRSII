using Transport.MobileAplication.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Transport.MobileAplication.Models.Vozaci;
using Transport.MobileApplication.Views;
using Transport.MobileApplication;

namespace Transport.MobileAplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage1 : ContentPage
    {
        MainPage1 RootPage { get => Application.Current.MainPage as MainPage1; }
        List<HomeMenuItem1> menuItems;
        public MenuPage1()
        {
            InitializeComponent();

           
            menuItems = new List<HomeMenuItem1>
            {
                new HomeMenuItem1 {Id = MenuItemType1.Pocetna, Title="Početna" },
                new HomeMenuItem1 {Id = MenuItemType1.MojeVoznje, Title="Moje voznje" },


                  new HomeMenuItem1 {Id = MenuItemType1.Odjava, Title="Odjava" }

            };
       

        ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem1)e.SelectedItem).Id;
                if (id == (int)MenuItemType1.Odjava)
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
            vozac.Text = APIService.LogovaniVozac.KorisnickoIme;
        }
    }
}