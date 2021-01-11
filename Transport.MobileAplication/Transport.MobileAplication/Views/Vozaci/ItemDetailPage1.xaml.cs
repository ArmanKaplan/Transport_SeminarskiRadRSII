using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Transport.MobileAplication.ViewModels;
using Transport.MobileAplication.ViewModels.Vozaci;
using Transport.MobileAplication.Models.Vozaci;

namespace Transport.MobileAplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage1 : ContentPage
    {
        ItemDetailViewModel1 viewModel;

        public ItemDetailPage1(ItemDetailViewModel1 viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage1()
        {
            InitializeComponent();

            var item = new Item1
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel1(item);
            BindingContext = viewModel;
        }
    }
}