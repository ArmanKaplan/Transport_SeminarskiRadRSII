using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Transport.MobileAplication.Models.Vozaci;
using Transport.MobileAplication.Views.Vozaci;
using Transport.MobileAplication.ViewModels.Vozaci;

namespace Transport.MobileAplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage1 : ContentPage
    {
        ItemsViewModel1 viewModel;

        public ItemsPage1()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel1();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item1;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage1(new ItemDetailViewModel1(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage1()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}