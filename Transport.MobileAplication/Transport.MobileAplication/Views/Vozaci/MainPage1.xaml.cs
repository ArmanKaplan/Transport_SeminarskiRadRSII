using Transport.MobileAplication.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Transport.MobileAplication.Models.Vozaci;
using Transport.MobileApplication.Views.Vozaci;

namespace Transport.MobileAplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage1 : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage1()
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
                    case (int)MenuItemType1.Pocetna:
                        MenuPages.Add(id, new NavigationPage(new PocetnaPage()));
                        break;

                    case (int)MenuItemType1.MojeVoznje:
                        MenuPages.Add(id, new NavigationPage(new MojeVoznjePage()));
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