using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.MobileAplication.Models.Vozaci;

namespace Transport.MobileAplication.Services.Vozaci
{
    public class MockDataStore1 : IDataStore1<Item1>
    {
        List<Item1> items;

        public MockDataStore1()
        {
            items = new List<Item1>();
            var mockItems = new List<Item1>
            {
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item1 { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item1 item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item1 item)
        {
            var oldItem = items.Where((Item1 arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item1 arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item1> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item1>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}