using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Transport.MobileAplication.Models.Vozaci;
using Transport.MobileAplication.Views.Vozaci;

namespace Transport.MobileAplication.ViewModels.Vozaci
{
    public class ItemsViewModel1 : BaseViewModel1
    {
        public ObservableCollection<Item1> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel1()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item1>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage1, Item1>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item1;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}