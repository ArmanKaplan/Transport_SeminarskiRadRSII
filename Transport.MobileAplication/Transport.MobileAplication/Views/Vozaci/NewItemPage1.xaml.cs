using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Transport.MobileAplication.Models.Vozaci;

namespace Transport.MobileAplication.Views.Vozaci
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage1 : ContentPage
    {
        public Item1 Item { get; set; }

        public NewItemPage1()
        {
            InitializeComponent();

            Item = new Item1
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}